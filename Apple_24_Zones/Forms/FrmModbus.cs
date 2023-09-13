using EasyModbus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleSoftware.Forms
{
    public partial class FrmModbus : Form
    {

        ModbusClient modbusClient = new ModbusClient("COM3");


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmModbus()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void FrmChartTesting_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            cboxPort.Items.AddRange(puertos);
            cboxPort.SelectedIndex = 0;
            btnClose.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;

            try
            {
                serialPort1.PortName = cboxPort.Text;
                serialPort1.Open();
                timer1.Start();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSendByte_Click_1(object sender, EventArgs e)
        {
            //string hexCommand = "CC 00 01 F0 02 00 FA 12";
            string hexCommand = "CC 00 01 F0 02 00 C8 44";
            string[] hexBytes = hexCommand.Split(' ');

            // string binaryValue = Convert.ToString(Convert.ToInt32(hexBytes, 16), 2).PadLeft(hexBytes.Length * 4, '0');


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // string hexCommand = "CC 00 01 F0 02 00 FA 12";

                //Request Current Value
                string hexCommand = "01 03 00 00 00 01 84 0A";

                // string hexCommand = "CC 00 01 F0 02 00 C8 44";
                string[] hexBytes = hexCommand.Split(' ');

                byte[] binaryData = new byte[hexBytes.Length];

                for (int i = 0; i < hexBytes.Length; i++)
                {
                    binaryData[i] = Convert.ToByte(hexBytes[i], 16);

                }

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(binaryData, 0, binaryData.Length);
                }

                // serialPort1.Write("#010\r");

                //  serialPort1.WriteLine("01 03 00 00 00 01 84 0A");

                // Binary



                // NOTES:
                // Setpoint 25 C° = CC 00 01 F0 02 00 FA 12
                // Binary = 11001100, 00000000, 00000001, 11110000, 00000010, 00000000, 11111010, 00010010

                // Decimal = byte[] bytes = { 204,00,01,240,2,0,250,18 }
                //
                // CC for RS485
                // 00 Most significant byte = ?
                // 01 Least significant byte = ?
                // F0 Command 240
                // 02
                // 00
                // FA = 250 = 25C ???
                // 12 

                // Request Current Value
                // Hex: CC 00 01 20 00 DE

                // Request Current Setpoint
                // Hex: CA 00 01 70 00 8E

                //Setpoint 20 C° test
                //Hex: CC 00 01 F0 02 00 C8 44
                //11001100, 00000000, 00000001, 11110000, 00000010, 00000000, 11001000, 01000100

                //
                //Setpoint 23: 11001100, 00000000, 00000001, 11110000, 00000010, 00000000, 11100110, 00100110

                //setpoint 10: 11001100, 00000000, 00000001, 11110000, 00000010, 00000000, 01100100, 10101000
                //setpoint 9:11001100, 00000000, 00000001, 11110000, 00000010, 00000000, 01011010, 10110010

                //setpoint 5: 11001100, 00000000, 00000001, 11110000, 00000010, 00000000, 00110010, 11011010
                //setpoint 30: 11001100, 00000000, 00000001, 11110000, 00000010, 00000001, 00101100, 11011111

                //setpoint 40: 11001100, 00000000, 00000001, 11110000, 00000010, 00000001, 10010000, 01111011

                //Command off: 11001100, 00000000, 00000001, 10000001, 00001000, 00000000, 00000010, 00000010, 00000010, 00000010, 00000010, 00000010, 00000010, 01100111
                //Command on: 11001100, 00000000, 00000001, 10000001, 00001000, 00000001, 00000010, 00000010, 00000010, 00000010, 00000010, 00000010, 00000010, 01100110
            }
            catch (Exception)
            {

                throw;
            }
        }




        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtReceive.Text = serialPort1.ReadLine();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmChartTesting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // dos lineas llegan, serial config cambia chiller a tc's 

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Hexa
            //if (e.EventType == SerialData.Eof)
            //    return;

            //byte[] buffer = new byte[serialPort1.BytesToRead];
            //serialPort1.Read(buffer, 0, buffer.Length);

            //// Convierte los bytes hexadecimales a una cadena legible
            //string receivedData = BitConverter.ToString(buffer).Replace("-", " ");

            //// Muestra los datos en un control de Windows Forms (por ejemplo, un TextBox)
            //Invoke(new Action(() =>
            //{
            //    txtReceive.AppendText(receivedData + Environment.NewLine);
            //}));

            int bytesToRead = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytesToRead];
            serialPort1.Read(buffer, 0, bytesToRead);

            // Verifica si los datos recibidos no están vacíos
            if (bytesToRead > 0)
            {
                // Convierte los datos a una cadena hexadecimal
                string hexData = BitConverter.ToString(buffer).Replace("-", "");

                // Guarda la cadena hexadecimal en la variable "temp"
                temp = hexData;

                // Puedes realizar cualquier otro procesamiento con la variable "temp" según tus necesidades.
            }

            // Guarda la cadena hexadecimal en la variable "temp"
        }

        private string temp = "";

        string T1 = "";
        string T2 = "";
        string T3 = "";
        string T4 = "";
        string T5 = "";
        string T6 = "";
        string T7 = "";
        string T8 = "";
        string T9 = "";
        string T10 = "";
        string T11 = "";
        string T12 = "";

        string T13 = "";
        string T14 = "";
        string T15 = "";
        string T16 = "";
        string T17 = "";
        string T18 = "";
        string T19 = "";
        string T20 = "";
        string T21 = "";
        string T22 = "";
        string T23 = "";
        string T24 = "";

        double TC1Num = 0;
        double TC2Num = 0;
        double TC3Num = 0;
        double TC4Num = 0;
        double TC5Num = 0;
        double TC6Num = 0;
        double TC7Num = 0;
        double TC8Num = 0;
        double TC9Num = 0;
        double TC10Num = 0;


        private void ReadData(string data)
        {
            // Paso 1 Quitar cualquier espacio
            string tcs = data.Trim();
            //Paso 2 quitar el >+ inicial
            tcs = tcs.Substring(2);
            //Paso 3 separar por +
            string[] TC = tcs.Split('+');

            //Paso 4 asignar cada TC
            if (TC.Length == 10)
            {
                T1 = TC[0];
                T2 = TC[1];
                T3 = TC[2];
                T4 = TC[3];
                T5 = TC[4];
                T6 = TC[5];
                T7 = TC[6];
                T8 = TC[7];
                T9 = TC[8];
                T10 = TC[9];
            }

            // Paso 5 reasignar valores

            T1 = T1.Substring(2);
            T2 = T2.Substring(2);
            T3 = T3.Substring(2);
            T4 = T4.Substring(2);
            T5 = T5.Substring(2);
            T6 = T6.Substring(2);
            T7 = T7.Substring(2);
            T8 = T8.Substring(2);
            T9 = T9.Substring(2);
            T10 = T10.Substring(2);

            // Paso 6 Separar a las con numeros a las con C°

            TC1Num = Convert.ToDouble(T1);
            TC2Num = Convert.ToDouble(T2);
            TC3Num = Convert.ToDouble(T3);
            TC4Num = Convert.ToDouble(T4);
            TC5Num = Convert.ToDouble(T5);
            TC6Num = Convert.ToDouble(T6);
            TC7Num = Convert.ToDouble(T7);
            TC8Num = Convert.ToDouble(T8);
            TC9Num = Convert.ToDouble(T9);
            TC10Num = Convert.ToDouble(T10);

            // Paso Final
            T1 = T1 + " C°";
            T2 = T2 + " C°";
            T3 = T3 + " C°";
            T4 = T4 + " C°";
            T5 = T5 + " C°";
            T6 = T6 + " C°";
            T7 = T7 + " C°";
            T8 = T8 + " C°";
            T9 = T9 + " C°";
            T10 = T10 + " C°";

            //TODO GRAFICAR.

            txtReceive.Text = T1 + " \n" + T2 + " \n" + T3;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (temp.Length == 14)
            {
                txtSend.Text = temp.Substring(6, 4);

                string hexa = txtSend.Text;

                long decimalValue = Convert.ToInt64(hexa, 16);

                string decima = decimalValue.ToString();

                if (decima.Length % 2 == 0 && decima.Length >= 2)
                {
                    int middleIndex = decima.Length / 2;
                    StringBuilder sb = new StringBuilder(decima);
                    sb.Insert(middleIndex, '.');
                    string result = sb.ToString();
                    txtSend.Text = result + " °C";
                }

                txtComplete.Text = temp;
            }

        }

        public static byte calculateLRC(byte[] bytes)
        {
            byte LRC = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                LRC ^= bytes[i];
            }
            return LRC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                txtReceive.Text += "case " + '"' + i.ToString() + '"' + ":\n\nbreak;";


            }

        }



        static byte[] HexToBytes(string input)
        {
            byte[] result = new byte[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }



        public static String decimalHexadecimal(int numero)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
            String hexadecimal = "";
            const int DIVISOR = 16;
            long resto = 0;
            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                resto = i % DIVISOR;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }
            return hexadecimal;
        }
        public static int hexadecimalDecimal(String hexadecimal)
        {
            int numero = 0;
            const int DIVISOR = 16;
            for (int i = 0, j = hexadecimal.Length - 1; i < hexadecimal.Length; i++, j--)
            {
                if (hexadecimal[i] >= '0' && hexadecimal[i] <= '9')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32(hexadecimal[i] + "");
                }
                else if (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32((hexadecimal[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }
            }
            return numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Cycle()
        {
            serialPort1.DiscardOutBuffer();
            txtSend.Text = "#03";
            serialPort1.Write(txtSend.Text + "\r");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Cycle();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            Application.Exit();

        }

        private void FrmChartTesting_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
