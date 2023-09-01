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
            else if (index ==1)
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

                lbZoneView.Text = "ZONE #1";

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

                panelGhost.Location = new Point(572, 311);
                panelGhost.Visible = true;
            }
            else if(index == 2)
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

                lbZoneView.Text = "ZONE #2";

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

                panelGhost.Location = new Point(572, 311);
                panelGhost.Visible = true;
            }
        }

                   

        private void button3_Click_1(object sender, EventArgs e)
        {
            // 1- Crear las variables constantes

            string hexConstante = "CC 00 01 F0 02";

            // 2- Obtener el valor deseado en temperatura y hacerle el x10

            if (double.TryParse(txtTempTest.Text, out double inputValue))
            {
                double multipliedValue = inputValue * 10;

                string hexValue = ((int)multipliedValue).ToString("X4"); // Formato hexadecimal con 4 caracteres

                // 3 - Guardar el hexa de la temperatura

                string hexTemp = hexValue;
                // Contiene 00FA

                // 4 - Unir las cadenas con hexConstante y la temperatura para que solo quede faltante el checksum

                string hexTempConFormato = string.Join(" ", Enumerable.Range(0, hexTemp.Length / 2).Select(i => hexTemp.Substring(i * 2, 2)));

                string hexCombinado = hexConstante + " " + hexTempConFormato;
                // Contiene CC 00 01 F0 02 00 FA

                // 5- Iniciar con el calculo del checkSum

                // 6- Sumar la constante hex con hex Temperatura

                string hexConstanteSumada = "F3";
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
                    // Contiene 1ED
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

                // Asegura que la representación binaria tenga 8 dígitos (un byte)
                binaryValue = binaryValue.PadLeft(8, '0');

                // 9- Hacer el swap

                char[] invertedChars = binaryValue.Select(c => c == '0' ? '1' : '0').ToArray();

                string invertedBinaryString = new string(invertedChars);
                // Contiene 00010010

                // 10- Convertir este binario a un hexa

                int decimalValue = Convert.ToInt32(invertedBinaryString, 2);

                string hexCheckSum = decimalValue.ToString("X");

                // 11- Unir todo el comando del paso 4

                string setTempCommand = hexCombinado + " " + hexCheckSum;

                txtResult.Text = setTempCommand;
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
            Pen borderPen = new Pen(Color.Black, 3);
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
        }

        private void panelControlZone2_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }

        private void panelControlZone1_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }




    }
}