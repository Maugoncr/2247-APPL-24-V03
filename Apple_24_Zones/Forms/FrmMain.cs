using AppleSoftware.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Apple_24_Zones.Forms
{
    public partial class FrmMain : Form


    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmMain()
        {
            InitializeComponent();
        }


        private void IconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaxin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void IconMinima_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ChangeViewChartZone(int index = 0)
        {
            if (index == 0)
            {
                panelGhost.Location = new Point(579, 1020);
                panelGhost.Visible = false;
                panelBoth.Visible = true;
            }
            else if (index == 1)
            {
                panelBoth.Visible = false;

                // Chart

                chartView.Series.Clear();
                chartView.Series.Add("T-1");
                chartView.Series.Add("T-2");
                chartView.Series.Add("T-3");
                chartView.Series.Add("T-4");
                chartView.Series.Add("T-5");
                chartView.Series.Add("T-6");
                chartView.Series.Add("T-7");
                chartView.Series.Add("T-8");
                chartView.Series.Add("T-9");
                chartView.Series.Add("T-10");
                chartView.Series.Add("T-11");
                chartView.Series.Add("T-12");

                chartView.Series["T-1"].IsVisibleInLegend = false;
                chartView.Series["T-2"].IsVisibleInLegend = false;
                chartView.Series["T-3"].IsVisibleInLegend = false;
                chartView.Series["T-4"].IsVisibleInLegend = false;
                chartView.Series["T-5"].IsVisibleInLegend = false;
                chartView.Series["T-6"].IsVisibleInLegend = false;
                chartView.Series["T-7"].IsVisibleInLegend = false;
                chartView.Series["T-8"].IsVisibleInLegend = false;
                chartView.Series["T-9"].IsVisibleInLegend = false;
                chartView.Series["T-10"].IsVisibleInLegend = false;
                chartView.Series["T-11"].IsVisibleInLegend = false;
                chartView.Series["T-12"].IsVisibleInLegend = false;

                chartView.Series["T-1"].Color = Color.Red;
                chartView.Series["T-2"].Color = Color.Blue;
                chartView.Series["T-3"].Color = Color.Yellow;
                chartView.Series["T-4"].Color = Color.Green;
                chartView.Series["T-5"].Color = Color.Purple;
                chartView.Series["T-6"].Color = Color.Cyan;
                chartView.Series["T-7"].Color = Color.Orange;
                chartView.Series["T-8"].Color = Color.Maroon;
                chartView.Series["T-9"].Color = Color.Lime;
                chartView.Series["T-10"].Color = Color.Magenta;
                chartView.Series["T-11"].Color = Color.Olive;
                chartView.Series["T-12"].Color = Color.Black;


                chartView.Series["T-1"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-2"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-3"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-4"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-5"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-6"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-7"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-8"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-9"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-10"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-11"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-12"].ChartType = SeriesChartType.Spline;

                chartView.Series["T-1"].BorderWidth = 2;


                // Labels

                lbZoneView.Text = "TEMP ZONE 1";

                lbView1.Text = "T-1";
                lbView2.Text = "T-2";
                lbView3.Text = "T-3";
                lbView4.Text = "T-4";
                lbView5.Text = "T-5";
                lbView6.Text = "T-6";
                lbView7.Text = "T-7";
                lbView8.Text = "T-8";
                lbView9.Text = "T-9";
                lbView10.Text = "T-10";
                lbView11.Text = "T-11";
                lbView12.Text = "T-12";

                checkView1.Text = "T-1";
                checkView2.Text = "T-2";
                checkView3.Text = "T-3";
                checkView4.Text = "T-4";
                checkView5.Text = "T-5";
                checkView6.Text = "T-6";
                checkView7.Text = "T-7";
                checkView8.Text = "T-8";
                checkView9.Text = "T-9";
                checkView10.Text = "T-10";
                checkView11.Text = "T-11";
                checkView12.Text = "T-12";

                panelGhost.Location = new Point(560, 91);
                panelGhost.Visible = true;
            }
            else if (index == 2)
            {
                panelBoth.Visible = false;

                // Chart

                chartView.Series.Clear();

                chartView.Series.Add("T-13");
                chartView.Series.Add("T-14");
                chartView.Series.Add("T-15");
                chartView.Series.Add("T-16");
                chartView.Series.Add("T-17");
                chartView.Series.Add("T-18");
                chartView.Series.Add("T-19");
                chartView.Series.Add("T-20");
                chartView.Series.Add("T-21");
                chartView.Series.Add("T-22");
                chartView.Series.Add("T-23");
                chartView.Series.Add("T-24");

                chartView.Series["T-13"].IsVisibleInLegend = false;
                chartView.Series["T-14"].IsVisibleInLegend = false;
                chartView.Series["T-15"].IsVisibleInLegend = false;
                chartView.Series["T-16"].IsVisibleInLegend = false;
                chartView.Series["T-17"].IsVisibleInLegend = false;
                chartView.Series["T-18"].IsVisibleInLegend = false;
                chartView.Series["T-19"].IsVisibleInLegend = false;
                chartView.Series["T-20"].IsVisibleInLegend = false;
                chartView.Series["T-21"].IsVisibleInLegend = false;
                chartView.Series["T-22"].IsVisibleInLegend = false;
                chartView.Series["T-23"].IsVisibleInLegend = false;
                chartView.Series["T-24"].IsVisibleInLegend = false;

                chartView.Series["T-13"].Color = Color.Red;
                chartView.Series["T-14"].Color = Color.Blue;
                chartView.Series["T-15"].Color = Color.Yellow;
                chartView.Series["T-16"].Color = Color.Green;
                chartView.Series["T-17"].Color = Color.Purple;
                chartView.Series["T-18"].Color = Color.Cyan;
                chartView.Series["T-19"].Color = Color.Orange;
                chartView.Series["T-20"].Color = Color.Maroon;
                chartView.Series["T-21"].Color = Color.Lime;
                chartView.Series["T-22"].Color = Color.Magenta;
                chartView.Series["T-23"].Color = Color.Olive;
                chartView.Series["T-24"].Color = Color.Black;

                // Labels

                lbZoneView.Text = "TEMP ZONE 2";

                lbView1.Text = "T-13";
                lbView2.Text = "T-14";
                lbView3.Text = "T-15";
                lbView4.Text = "T-16";
                lbView5.Text = "T-17";
                lbView6.Text = "T-18";
                lbView7.Text = "T-19";
                lbView8.Text = "T-20";
                lbView9.Text = "T-21";
                lbView10.Text = "T-22";
                lbView11.Text = "T-23";
                lbView12.Text = "T-24";

                checkView1.Text = "T-13";
                checkView2.Text = "T-14";
                checkView3.Text = "T-15";
                checkView4.Text = "T-16";
                checkView5.Text = "T-17";
                checkView6.Text = "T-18";
                checkView7.Text = "T-19";
                checkView8.Text = "T-20";
                checkView9.Text = "T-21";
                checkView10.Text = "T-22";
                checkView11.Text = "T-23";
                checkView12.Text = "T-24";

                panelGhost.Location = new Point(560, 91);
                panelGhost.Visible = true;
            }
        }

        private void bothZonesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeViewChartZone();
        }

        private void tempZone1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewChartZone(1);
        }

        private void tempZone2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewChartZone(2);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmInformation);
            if (frm == null)
            {
                FrmInformation nt = new FrmInformation();
                nt.ShowDialog();
            }
            else
            {
                frm.BringToFront();
                return;
            }
        }

        private void cSVFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmFilterCSVFile);

            if (frm == null)
            {
                FrmFilterCSVFile nt = new FrmFilterCSVFile();

                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }
        }

        private void CreateBorderLabel(object sender, PaintEventArgs e)
        {
            Label label = (Label)sender;
            Pen borderPen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, label.Width - 1, label.Height - 1));
        }

        private void CreateBorderPanel(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Pen borderPen = new Pen(Color.Black, 5);
            e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, panel.Width - 1, panel.Height - 1));
        }

        private void lbCurrentSetpoint2_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderLabel(sender, e);
        }

        private void lbAVGTemp2_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderLabel(sender, e);
        }

        private void lbCurrentSetpoint1_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderLabel(sender, e);
        }

        private void lbAVGTemp1_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderLabel(sender, e);
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dddd, MM/dd/yyyy");
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fecha);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
            FrmCargarDefault();
        }

        private void FrmCargarDefault()
        {
            // Recalibrar Pantalla Conexion
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int panelWidth = panelConexion.Width;
            int panelHeight = panelConexion.Height;
            int panelX = (screenWidth - panelWidth) / 2;
            int panelY = (screenHeight - panelHeight) / 2;
            panelConexion.Location = new Point(panelX, panelY);
            panelConexion.Visible = false;

            string[] puertos = SerialPort.GetPortNames();
            cbCOMSelect1.Items.AddRange(puertos);

        }

        private void panelControlZone2_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }

        private void panelControlZone1_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }

        private void btnCloseConexionPanel_Click(object sender, EventArgs e)
        {
            panelConexion.Visible = false;
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelConexion.Visible = true;
        }

        private void btnConnectCOM1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbCOMSelect1.Text;
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }


        private string ReturnCommandSetpointChiller(string temperature, int adress)
        {
            string commandResult = "";

            //Chiller 1
            if (adress == 0)
            {
                // Constante que debemos cambiar si cambia el ADRESS
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                string hexConstante = "CC 00 01 F0 02";
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                // 2- Obtener el valor deseado en temperatura y hacerle el x10
                if (double.TryParse(temperature, out double inputValue))
                {
                    lbCurrentSetpoint2.Text = inputValue.ToString();
                    double multipliedValue = inputValue * 10;
                    string hexValue = ((int)multipliedValue).ToString("X4"); // Formato hexadecimal con 4 caracteres
                    // 3 - Guardar el hexa de la temperatura
                    string hexTemp = hexValue;
                    // 4 - Unir las cadenas con hexConstante y la temperatura para que solo quede faltante el checksum
                    string hexTempConFormato = string.Join(" ", Enumerable.Range(0, hexTemp.Length / 2).Select(i => hexTemp.Substring(i * 2, 2)));
                    string hexCombinado = hexConstante + " " + hexTempConFormato;
                    // Contiene CC 00 01 F0 02 00 FA
                    // 5- Iniciar con el calculo del checkSum
                    // 6- Sumar la constante hex con hex Temperatura
                    //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                    string hexConstanteSumada = "F3";
                    //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                    int intValue1 = Convert.ToInt32(hexConstanteSumada, 16);
                    int intValue2;
                    int intValue3;
                    int sum;
                    // Se verifica si la cadena con el valor hex es de dos digitos o de tres ejemplo: 00FA "•2" || 01FA "•1"
                    if (hexTemp.Substring(2, 1) != "0")
                    {
                        intValue2 = Convert.ToInt32(hexTemp.Substring(1, 1), 16);
                        intValue3 = Convert.ToInt32(hexTemp.Substring(2), 16);
                        sum = intValue1 + intValue2 + intValue3;
                    }
                    else
                    {
                        intValue3 = Convert.ToInt32(hexTemp.Substring(2), 16);
                        sum = intValue1 + intValue3;
                    }
                    // 7- Tomar los ultimos 2 digitos
                    string hexSumadoCheck = sum.ToString("X");
                    string lastTwoDigits;
                    if (hexSumadoCheck.Length == 1)
                    {
                        lastTwoDigits = "0" + hexSumadoCheck;
                    }
                    else
                    {
                        lastTwoDigits = hexSumadoCheck.Substring(hexSumadoCheck.Length - 2);
                    }
                    // 8- Pasar estos dos ultimos digitos a binario y realizar el swap 1 - 0 
                    string binaryValue = Convert.ToString(Convert.ToInt32(lastTwoDigits, 16), 2);
                    binaryValue = binaryValue.PadLeft(8, '0');
                    // 9- Hacer el swap
                    char[] invertedChars = binaryValue.Select(c => c == '0' ? '1' : '0').ToArray();
                    string invertedBinaryString = new string(invertedChars);
                    // 10- Convertir este binario a un hexa
                    int decimalValue = Convert.ToInt32(invertedBinaryString, 2);
                    string hexCheckSum = decimalValue.ToString("X");
                    // 11- Unir todo el comando del paso 4
                    commandResult = hexCombinado + " " + hexCheckSum;
                    return commandResult;
                }

            }
            // Chiller 2
            else if (adress == 1)
            {
                // Constante que debemos cambiar si cambia el ADRESS
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                string hexConstante = "CC 00 01 F0 02";
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                // 2- Obtener el valor deseado en temperatura y hacerle el x10
                if (double.TryParse(temperature, out double inputValue))
                {
                    lbCurrentSetpoint2.Text = inputValue.ToString();
                    double multipliedValue = inputValue * 10;
                    string hexValue = ((int)multipliedValue).ToString("X4"); // Formato hexadecimal con 4 caracteres
                    // 3 - Guardar el hexa de la temperatura
                    string hexTemp = hexValue;
                    // 4 - Unir las cadenas con hexConstante y la temperatura para que solo quede faltante el checksum
                    string hexTempConFormato = string.Join(" ", Enumerable.Range(0, hexTemp.Length / 2).Select(i => hexTemp.Substring(i * 2, 2)));
                    string hexCombinado = hexConstante + " " + hexTempConFormato;
                    // Contiene CC 00 01 F0 02 00 FA
                    // 5- Iniciar con el calculo del checkSum
                    // 6- Sumar la constante hex con hex Temperatura
                    //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                    string hexConstanteSumada = "F3";
                    //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                    int intValue1 = Convert.ToInt32(hexConstanteSumada, 16);
                    int intValue2;
                    int intValue3;
                    int sum;
                    // Se verifica si la cadena con el valor hex es de dos digitos o de tres ejemplo: 00FA "•2" || 01FA "•1"
                    if (hexTemp.Substring(2, 1) != "0")
                    {
                        intValue2 = Convert.ToInt32(hexTemp.Substring(1, 1), 16);
                        intValue3 = Convert.ToInt32(hexTemp.Substring(2), 16);
                        sum = intValue1 + intValue2 + intValue3;
                    }
                    else
                    {
                        intValue3 = Convert.ToInt32(hexTemp.Substring(2), 16);
                        sum = intValue1 + intValue3;
                    }
                    // 7- Tomar los ultimos 2 digitos
                    string hexSumadoCheck = sum.ToString("X");
                    string lastTwoDigits;
                    if (hexSumadoCheck.Length == 1)
                    {
                        lastTwoDigits = "0" + hexSumadoCheck;
                    }
                    else
                    {
                        lastTwoDigits = hexSumadoCheck.Substring(hexSumadoCheck.Length - 2);
                    }
                    // 8- Pasar estos dos ultimos digitos a binario y realizar el swap 1 - 0 
                    string binaryValue = Convert.ToString(Convert.ToInt32(lastTwoDigits, 16), 2);
                    binaryValue = binaryValue.PadLeft(8, '0');
                    // 9- Hacer el swap
                    char[] invertedChars = binaryValue.Select(c => c == '0' ? '1' : '0').ToArray();
                    string invertedBinaryString = new string(invertedChars);
                    // 10- Convertir este binario a un hexa
                    int decimalValue = Convert.ToInt32(invertedBinaryString, 2);
                    string hexCheckSum = decimalValue.ToString("X");
                    // 11- Unir todo el comando del paso 4
                    commandResult = hexCombinado + " " + hexCheckSum;
                    return commandResult;
                }
            }
            return commandResult;
        }

        private void ApagarChiller(int Adress) 
        {
            if (Adress == 0)
            {
                    string commandOnChiller = "CC 00 01 81 08 01 02 02 02 02 02 02 02 66";
                    string[] hexBytesOn = commandOnChiller.Split(' ');
                    byte[] binaryDataOn = new byte[hexBytesOn.Length];
                    for (int i = 0; i < hexBytesOn.Length; i++)
                    {
                        binaryDataOn[i] = Convert.ToByte(hexBytesOn[i], 16);
                    }
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(binaryDataOn, 0, binaryDataOn.Length);
                    }
                    Thread.Sleep(1000);
            }
            else if (Adress == 1)
            {
                    string commandOnChiller = "CC 00 01 81 08 01 02 02 02 02 02 02 02 66";
                    string[] hexBytesOn = commandOnChiller.Split(' ');
                    byte[] binaryDataOn = new byte[hexBytesOn.Length];
                    for (int i = 0; i < hexBytesOn.Length; i++)
                    {
                        binaryDataOn[i] = Convert.ToByte(hexBytesOn[i], 16);
                    }
                    if (serialPort2.IsOpen)
                    {
                        serialPort2.Write(binaryDataOn, 0, binaryDataOn.Length);
                    }
                    Thread.Sleep(1000);
            }
        }

        private void SendSetpointChiller(string Command, int Adress)
        {
            // 12- Pasar al lenguaje que entiende el chiller el comando
            // 9600
            // 8 bits, parity none
            // writetimeout -1
            if (Adress == 0)
            {
                string[] hexBytes = Command.Split(' ');
                byte[] binaryData = new byte[hexBytes.Length];
                for (int i = 0; i < hexBytes.Length; i++)
                {
                    binaryData[i] = Convert.ToByte(hexBytes[i], 16);

                }
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(binaryData, 0, binaryData.Length);
                }
            }
            else if (Adress == 1)
            {
                string[] hexBytes = Command.Split(' ');
                byte[] binaryData = new byte[hexBytes.Length];
                for (int i = 0; i < hexBytes.Length; i++)
                {
                    binaryData[i] = Convert.ToByte(hexBytes[i], 16);

                }
                if (serialPort2.IsOpen)
                {
                    serialPort2.Write(binaryData, 0, binaryData.Length);
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // 13- Apagar Chiller this command is correct? let me check

            string commandOffChiller = "CC 00 01 81 08 00 02 02 02 02 02 02 02 67";

            string[] hexBytesOff = commandOffChiller.Split(' ');

            byte[] binaryDataOff = new byte[hexBytesOff.Length];

            for (int i = 0; i < hexBytesOff.Length; i++)
            {
                binaryDataOff[i] = Convert.ToByte(hexBytesOff[i], 16);

            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(binaryDataOff, 0, binaryDataOff.Length);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // 13- Apagar Chiller this command is correct? let me check

            string commandOffChiller = "CC 00 01 81 08 00 02 02 02 02 02 02 02 67";

            string[] hexBytesOff = commandOffChiller.Split(' ');

            byte[] binaryDataOff = new byte[hexBytesOff.Length];

            for (int i = 0; i < hexBytesOff.Length; i++)
            {
                binaryDataOff[i] = Convert.ToByte(hexBytesOff[i], 16);

            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(binaryDataOff, 0, binaryDataOff.Length);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // 13- Encender Chiller CC 00 01 81 08 01 02 02 02 02 02 02 02 66

            string commandOnChiller = "CC 00 01 81 08 01 02 02 02 02 02 02 02 66";

            string[] hexBytesOn = commandOnChiller.Split(' ');

            byte[] binaryDataOn = new byte[hexBytesOn.Length];

            for (int i = 0; i < hexBytesOn.Length; i++)
            {
                binaryDataOn[i] = Convert.ToByte(hexBytesOn[i], 16);

            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(binaryDataOn, 0, binaryDataOn.Length);
            }
        }

        private bool ValidRange(decimal input)
        {
            // Valid range Chiller
            decimal number = input;
            return number > 0 && number <= 40;
        }

        private void txtPutSetpoint1_Leave(object sender, EventArgs e)
        {
            if (!ValidRange(txtPutSetpoint1.Value))
            {
                txtPutSetpoint1.Value = 0;
                txtPutSetpoint1.ResetText();
            }
        }

        private void txtPutSetpoint1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparator))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == decimalSeparator) && ((sender as NumericUpDown).Text.IndexOf(decimalSeparator) > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPutSetpoint2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparator))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == decimalSeparator) && ((sender as NumericUpDown).Text.IndexOf(decimalSeparator) > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPutSetpoint2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            decimal valor = txtPutSetpoint2.Value;
            // Verifica si el valor está fuera del rango deseado
            if (valor <= 0 || valor > 40)
            {
                // Muestra un mensaje de error
                MessageBox.Show("El valor debe estar entre 1 y 40.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Establece el foco de nuevo en el control para corregir el valor
                txtPutSetpoint2.Focus();
                // Cancela la validación para que el usuario pueda corregir el valor
                e.Cancel = true;
            }
        }

        private void btnApplySetpoint1_Click(object sender, EventArgs e)
        {

        }

        private void btnApplySetpoint2_Click(object sender, EventArgs e)
        {

        }

        private void cbProcess2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProcess2.SelectedIndex == 0)
            {
                ChangeProcessHeatingCoolingLED("Heating",2);
            }
            else if (cbProcess2.SelectedIndex == 1)
            {
                ChangeProcessHeatingCoolingLED("Cooling", 2);
            }
        }

        private void ChangeProcessHeatingCoolingLED(string process, int which)
        {
            // Zone 1
            if (which == 1)
            {
                if (process == "Heating")
                {
                    picCooling1.Image.Dispose();
                    picCooling1.Image = Properties.Resources.ledRectangleOff;
                    picHeating1.Image.Dispose();
                    picHeating1.Image = Properties.Resources.ledRectangleOn;

                }
                else if (process == "Cooling")
                {
                    picCooling1.Image.Dispose();
                    picCooling1.Image = Properties.Resources.ledRectangleOn;
                    picHeating1.Image.Dispose();
                    picHeating1.Image = Properties.Resources.ledRectangleOff;
                }
            }
            // Zone 2
            else if (which == 2)
            {
                if (process == "Heating")
                {
                    picCooling2.Image.Dispose();
                    picCooling2.Image = Properties.Resources.ledRectangleOff;
                    picHeating2.Image.Dispose();
                    picHeating2.Image = Properties.Resources.ledRectangleOn;
                }
                else if (process == "Cooling")
                {
                    picCooling2.Image.Dispose();
                    picCooling2.Image = Properties.Resources.ledRectangleOn;
                    picHeating2.Image.Dispose();
                    picHeating2.Image = Properties.Resources.ledRectangleOff;
                }
            }
        
        
        }

        private void cbProcess1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProcess1.SelectedIndex == 0)
            {
                ChangeProcessHeatingCoolingLED("Heating", 1);
            }
            else if (cbProcess1.SelectedIndex == 1)
            {
                ChangeProcessHeatingCoolingLED("Cooling", 1);
            }
        }
    }
}