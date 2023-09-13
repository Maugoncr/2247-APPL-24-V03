using Apple_24_Zones.Properties;
using AppleSoftware.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MidoriValveTest.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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
            InicializarComboboxes();

            txtView1.Paint += TextBox_Paint;
            txtView2.Paint += TextBox_Paint;
            txtView3.Paint += TextBox_Paint;
            txtView4.Paint += TextBox_Paint;
            txtView5.Paint += TextBox_Paint;
            txtView6.Paint += TextBox_Paint;
            txtView7.Paint += TextBox_Paint;
            txtView8.Paint += TextBox_Paint;
            txtView9.Paint += TextBox_Paint;
            txtView10.Paint += TextBox_Paint;
            txtView11.Paint += TextBox_Paint;
            txtView12.Paint += TextBox_Paint;

            txtTC1.Paint += TextBox_Paint;
            txtTC2.Paint += TextBox_Paint;
            txtTC3.Paint += TextBox_Paint;
            txtTC4.Paint += TextBox_Paint;
            txtTC5.Paint += TextBox_Paint;
            txtTC6.Paint += TextBox_Paint;
            txtTC7.Paint += TextBox_Paint;
            txtTC8.Paint += TextBox_Paint;
            txtTC9.Paint += TextBox_Paint;
            txtTC10.Paint += TextBox_Paint;
            txtTC11.Paint += TextBox_Paint;
            txtTC12.Paint += TextBox_Paint;
            txtTC13.Paint += TextBox_Paint;
            txtTC14.Paint += TextBox_Paint;
            txtTC15.Paint += TextBox_Paint;
            txtTC16.Paint += TextBox_Paint;
            txtTC17.Paint += TextBox_Paint;
            txtTC18.Paint += TextBox_Paint;
            txtTC19.Paint += TextBox_Paint;
            txtTC20.Paint += TextBox_Paint;
            txtTC21.Paint += TextBox_Paint;
            txtTC22.Paint += TextBox_Paint;
            txtTC23.Paint += TextBox_Paint;
            txtTC24.Paint += TextBox_Paint;
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

        private void FillChartZones(int which) 
        {
            if (which == 1)
            {
                chartZone1.Series.Clear();
                chartZone1.Series.Add("T-1");
                chartZone1.Series.Add("T-2");
                chartZone1.Series.Add("T-3");
                chartZone1.Series.Add("T-4");
                chartZone1.Series.Add("T-5");
                chartZone1.Series.Add("T-6");
                chartZone1.Series.Add("T-7");
                chartZone1.Series.Add("T-8");
                chartZone1.Series.Add("T-9");
                chartZone1.Series.Add("T-10");
                chartZone1.Series.Add("T-11");
                chartZone1.Series.Add("T-12");

                chartZone1.Series["T-1"].IsVisibleInLegend = false;
                chartZone1.Series["T-2"].IsVisibleInLegend = false;
                chartZone1.Series["T-3"].IsVisibleInLegend = false;
                chartZone1.Series["T-4"].IsVisibleInLegend = false;
                chartZone1.Series["T-5"].IsVisibleInLegend = false;
                chartZone1.Series["T-6"].IsVisibleInLegend = false;
                chartZone1.Series["T-7"].IsVisibleInLegend = false;
                chartZone1.Series["T-8"].IsVisibleInLegend = false;
                chartZone1.Series["T-9"].IsVisibleInLegend = false;
                chartZone1.Series["T-10"].IsVisibleInLegend = false;
                chartZone1.Series["T-11"].IsVisibleInLegend = false;
                chartZone1.Series["T-12"].IsVisibleInLegend = false;

                chartZone1.Series["T-1"].Color = Color.Red;
                chartZone1.Series["T-2"].Color = Color.Blue;
                chartZone1.Series["T-3"].Color = Color.Yellow;
                chartZone1.Series["T-4"].Color = Color.Green;
                chartZone1.Series["T-5"].Color = Color.Purple;
                chartZone1.Series["T-6"].Color = Color.Cyan;
                chartZone1.Series["T-7"].Color = Color.Orange;
                chartZone1.Series["T-8"].Color = Color.Maroon;
                chartZone1.Series["T-9"].Color = Color.Lime;
                chartZone1.Series["T-10"].Color = Color.Magenta;
                chartZone1.Series["T-11"].Color = Color.Olive;
                chartZone1.Series["T-12"].Color = Color.Black;

                chartZone1.Series["T-1"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-2"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-3"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-4"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-5"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-6"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-7"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-8"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-9"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-10"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-11"].ChartType = SeriesChartType.Spline;
                chartZone1.Series["T-12"].ChartType = SeriesChartType.Spline;

            }
            else if (which == 2)
            {
                chartZone2.Series.Clear();
                chartZone2.Series.Add("T-13");
                chartZone2.Series.Add("T-14");
                chartZone2.Series.Add("T-15");
                chartZone2.Series.Add("T-16");
                chartZone2.Series.Add("T-17");
                chartZone2.Series.Add("T-18");
                chartZone2.Series.Add("T-19");
                chartZone2.Series.Add("T-20");
                chartZone2.Series.Add("T-21");
                chartZone2.Series.Add("T-22");
                chartZone2.Series.Add("T-23");
                chartZone2.Series.Add("T-24");

                chartZone2.Series["T-13"].IsVisibleInLegend = false;
                chartZone2.Series["T-14"].IsVisibleInLegend = false;
                chartZone2.Series["T-15"].IsVisibleInLegend = false;
                chartZone2.Series["T-16"].IsVisibleInLegend = false;
                chartZone2.Series["T-17"].IsVisibleInLegend = false;
                chartZone2.Series["T-18"].IsVisibleInLegend = false;
                chartZone2.Series["T-19"].IsVisibleInLegend = false;
                chartZone2.Series["T-20"].IsVisibleInLegend = false;
                chartZone2.Series["T-21"].IsVisibleInLegend = false;
                chartZone2.Series["T-22"].IsVisibleInLegend = false;
                chartZone2.Series["T-23"].IsVisibleInLegend = false;
                chartZone2.Series["T-24"].IsVisibleInLegend = false;

                chartZone2.Series["T-13"].Color = Color.Red;
                chartZone2.Series["T-14"].Color = Color.Blue;
                chartZone2.Series["T-15"].Color = Color.Yellow;
                chartZone2.Series["T-16"].Color = Color.Green;
                chartZone2.Series["T-17"].Color = Color.Purple;
                chartZone2.Series["T-18"].Color = Color.Cyan;
                chartZone2.Series["T-19"].Color = Color.Orange;
                chartZone2.Series["T-20"].Color = Color.Maroon;
                chartZone2.Series["T-21"].Color = Color.Lime;
                chartZone2.Series["T-22"].Color = Color.Magenta;
                chartZone2.Series["T-23"].Color = Color.Olive;
                chartZone2.Series["T-24"].Color = Color.Black;

                chartZone2.Series["T-13"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-14"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-15"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-16"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-17"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-18"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-19"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-20"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-21"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-22"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-23"].ChartType = SeriesChartType.Spline;
                chartZone2.Series["T-24"].ChartType = SeriesChartType.Spline;
            }

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

               // chartView.Series["T-1"].BorderWidth = 2;
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

                chartView.Series["T-13"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-14"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-15"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-16"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-17"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-18"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-19"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-20"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-21"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-22"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-23"].ChartType = SeriesChartType.Spline;
                chartView.Series["T-24"].ChartType = SeriesChartType.Spline;

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

      

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dddd, MM/dd/yyyy");
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fecha);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
            FillChartZones(1);
            FillChartZones(2);
            FrmCargarDefault();
           // timerSimulationCharts.Start();
        }

        private void FrmCargarDefault()
        {
            // Disconectar

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
            }

            // Default variables
            rt = 0;
            temp = 0;

            //Reset Images

            picCooling1.Image.Dispose();
            picCooling2.Image.Dispose();
            picHeating1.Image.Dispose();
            picHeating2.Image.Dispose();
            picRed.Image.Dispose();
            picYellow.Image.Dispose();
            picGreen.Image.Dispose();
            picUpDown1.Image.Dispose();
            picUpDown2.Image.Dispose();

            picCooling1.Image = Resources.ledRectangleOff;
            picCooling2.Image = Resources.ledRectangleOff;
            picHeating1.Image = Resources.ledRectangleOff;
            picHeating2.Image = Resources.ledRectangleOff;
            picRed.Image = Resources.tc1off;
            picYellow.Image = Resources.tc3off;
            picGreen.Image = Resources.tc8off;
            picUpDown1.Image = Resources.neutroWhite;
            picUpDown2.Image = Resources.neutroWhite;

            // Botones que deben venir por defecto desactivados

            btnConnectCOM1.Enabled = false;
            btnConnectCOM2.Enabled = false;


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
            cbCOMSelect1.Items.Clear();
            cbCOMSelect2.Items.Clear();
            cbCOMSelect1.Items.AddRange(puertos);
            cbCOMSelect2.Items.AddRange(puertos);

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

        private List<ComboBox> comboBoxes;

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectedComboBox = (ComboBox)sender;
            bool isItemSelectedInOtherComboBox = false;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != selectedComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(selectedComboBox.SelectedItem))
                {
                    isItemSelectedInOtherComboBox = true;
                    break;
                }
            }
            if (isItemSelectedInOtherComboBox)
            {
                MessageBox.Show("Cannot select the same item in multiple ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedComboBox.SelectedIndex = -1;
            }
            else
            {
                selectedComboBox = comboBoxes.Find(comboBox => comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(selectedComboBox.SelectedItem));
                if (selectedComboBox != null)
                {
                    if (selectedComboBox == cbCOMSelect1)
                    {
                        ActivarConnect(1);
                    }
                    else if (selectedComboBox == cbCOMSelect2)
                    {
                        ActivarConnect(2);
                    }
                }
            }

        }

        private void ActivarConnect(int wich)
        {
            if (wich == 1)
            {
                btnConnectCOM1.Enabled = true;
            }
            else if (wich == 2)
            {
                btnConnectCOM2.Enabled = true;
            }
        }

        private void InicializarComboboxes()
        {
            comboBoxes = new List<ComboBox> { cbCOMSelect1, cbCOMSelect2};

            // Suscribe al evento SelectedIndexChanged para todos los ComboBox
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void btnConnectCOM1_Click(object sender, EventArgs e)
        {
            btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            timerSimulationCharts.Start();
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

            if (cbProcess2.SelectedIndex == 0)
            {
                if (serialPort1.IsOpen)
                {
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    byte[] bytes = { 4, 6, 33, 3, 0, 0, 115, 163 };
                    serialPort1.Write(bytes, 0, bytes.Length);
                    lbCurrentSetpoint2.Text = "0.0 °C";
                 //   BanderaRespuestaParaTCS = false;
                 //   Thread.Sleep(1000);
                 //  SetConfigSerialPortForTCS();
                 // Temporizador.Stop();
                }
            }
            else if (cbProcess2.SelectedIndex == 1)
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
        
            
        private void btnApplySetpoint1_Click(object sender, EventArgs e)
        {
            double determinarSiSubeOBaja = Convert.ToDouble(txtPutSetpoint1.Text);

            if (determinarSiSubeOBaja > setpoint)
            {
                // Vamos a calentar
                picUpDown1.Image.Dispose();
                picUpDown1.Image = Resources.arrowUpRed21;
            }
            else if (determinarSiSubeOBaja < setpoint)
            {
                // Vamos a enfriar
                picUpDown1.Image.Dispose();
                picUpDown1.Image = Resources.arrowDownBlue2;
            }
            else
            {
                picUpDown1.Image.Dispose();
                picUpDown1.Image = Resources.neutroWhite;
            }

            setpointGoal = determinarSiSubeOBaja;
            timerSimulationDownUp.Start();
        }

        double setpointGoal = 25;
        private void timerSimulationDownUp_Tick(object sender, EventArgs e)
        {
            if (setpoint < setpointGoal)
            {
                setpoint++;
            }
            else if (setpoint > setpointGoal)
            {
                setpoint--;
            }
            else if (setpoint == setpointGoal)
            {
                timerSimulationDownUp.Stop();
            }
        }
        private void SendSetTempHeaterAndTurnItOn()
        {
            switch (txtPutSetpoint2.Text)
            {
                case "1":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes1 = { 4, 6, 33, 3, 0, 10, 243, 164 };
                    serialPort1.Write(bytes1, 0, bytes1.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    //Check ☻

                    break;
                case "2":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes2 = { 4, 6, 33, 3, 0, 20, 115, 172 };
                    serialPort1.Write(bytes2, 0, bytes2.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();

                    break;
                case "3":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes3 = { 4, 6, 33, 3, 0, 30, 243, 171 };
                    serialPort1.Write(bytes3, 0, bytes3.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "4":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes4 = { 4, 6, 33, 3, 0, 200, 114, 53 };
                    serialPort1.Write(bytes4, 0, bytes4.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "5":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes5 = { 4, 6, 33, 3, 0, 50, 242, 118 };
                    serialPort1.Write(bytes5, 0, bytes5.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "6":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes6 = { 4, 6, 33, 3, 0, 60, 115, 178 };
                    serialPort1.Write(bytes6, 0, bytes6.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "7":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes7 = { 4, 6, 33, 3, 0, 70, 242, 81 };
                    serialPort1.Write(bytes7, 0, bytes7.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "8":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes8 = { 4, 6, 33, 3, 0, 80, 115, 159 };
                    serialPort1.Write(bytes8, 0, bytes8.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "9":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes9 = { 4, 6, 33, 3, 0, 90, 243, 152 };
                    serialPort1.Write(bytes9, 0, bytes9.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "10":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes10 = { 4, 6, 33, 3, 0, 100, 114, 72 };
                    serialPort1.Write(bytes10, 0, bytes10.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "11":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes11 = { 4, 6, 33, 3, 0, 110, 242, 79 };
                    serialPort1.Write(bytes11, 0, bytes11.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "12":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes12 = { 4, 6, 33, 3, 0, 120, 115, 129 };
                    serialPort1.Write(bytes12, 0, bytes12.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "13":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes13 = { 4, 6, 33, 3, 0, 130, 243, 194 };
                    serialPort1.Write(bytes13, 0, bytes13.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "14":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes14 = { 4, 6, 33, 3, 0, 140, 114, 6 };
                    serialPort1.Write(bytes14, 0, bytes14.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "15":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes15 = { 4, 6, 33, 3, 0, 150, 243, 205 };
                    serialPort1.Write(bytes15, 0, bytes15.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "16":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes16 = { 4, 6, 33, 3, 0, 160, 115, 219 };
                    serialPort1.Write(bytes16, 0, bytes16.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "17":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes17 = { 4, 6, 33, 3, 0, 170, 243, 220 };
                    serialPort1.Write(bytes17, 0, bytes17.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "18":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes18 = { 4, 6, 33, 3, 0, 180, 115, 212 };
                    serialPort1.Write(bytes18, 0, bytes18.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "19":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes19 = { 4, 6, 33, 3, 0, 190, 243, 211 };
                    serialPort1.Write(bytes19, 0, bytes19.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "20":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes20 = { 4, 6, 33, 3, 0, 200, 114, 53 };
                    serialPort1.Write(bytes20, 0, bytes20.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "21":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes21 = { 4, 6, 33, 3, 0, 210, 243, 254 };
                    serialPort1.Write(bytes21, 0, bytes21.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "22":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes22 = { 4, 6, 33, 3, 0, 220, 114, 58 };
                    serialPort1.Write(bytes22, 0, bytes22.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "23":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes23 = { 4, 6, 33, 3, 0, 230, 242, 41 };
                    serialPort1.Write(bytes23, 0, bytes23.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "24":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes24 = { 4, 6, 33, 3, 0, 240, 115, 231 };
                    serialPort1.Write(bytes24, 0, bytes24.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "25":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes25 = { 4, 6, 33, 3, 0, 250, 243, 224 };
                    serialPort1.Write(bytes25, 0, bytes25.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "26":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes26 = { 4, 6, 33, 3, 1, 4, 115, 240 };
                    serialPort1.Write(bytes26, 0, bytes26.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "27":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes27 = { 4, 6, 33, 3, 1, 14, 243, 247 };
                    serialPort1.Write(bytes27, 0, bytes27.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "28":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes28 = { 4, 6, 33, 3, 1, 24, 114, 57 };
                    serialPort1.Write(bytes28, 0, bytes28.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "29":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes29 = { 4, 6, 33, 3, 1, 34, 242, 42 };
                    serialPort1.Write(bytes29, 0, bytes29.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "30":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes30 = { 4, 6, 33, 3, 1, 44, 115, 238 };
                    serialPort1.Write(bytes30, 0, bytes30.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "31":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes31 = { 4, 6, 33, 3, 1, 54, 242, 37 };
                    serialPort1.Write(bytes31, 0, bytes31.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "32":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes32 = { 4, 6, 33, 3, 1, 64, 115, 195 };
                    serialPort1.Write(bytes32, 0, bytes32.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "33":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes33 = { 4, 6, 33, 3, 1, 74, 243, 196 };
                    serialPort1.Write(bytes33, 0, bytes33.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "34":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes34 = { 4, 6, 33, 3, 1, 84, 115, 204 };
                    serialPort1.Write(bytes34, 0, bytes34.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "35":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes35 = { 4, 6, 33, 3, 1, 94, 243, 203 };
                    serialPort1.Write(bytes35, 0, bytes35.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "36":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes36 = { 4, 6, 33, 3, 1, 104, 115, 221 };
                    serialPort1.Write(bytes36, 0, bytes36.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "37":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes37 = { 4, 6, 33, 3, 1, 114, 242, 22 };
                    serialPort1.Write(bytes37, 0, bytes37.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "38":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes38 = { 4, 6, 33, 3, 1, 124, 115, 210 };
                    serialPort1.Write(bytes38, 0, bytes38.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "39":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes39 = { 4, 6, 33, 3, 1, 134, 243, 145 };
                    serialPort1.Write(bytes39, 0, bytes39.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "40":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes40 = { 4, 6, 33, 3, 1, 144, 114, 95 };
                    serialPort1.Write(bytes40, 0, bytes40.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "41":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes41 = { 4, 6, 33, 3, 1, 154, 242, 88 };
                    serialPort1.Write(bytes41, 0, bytes41.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "42":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes42 = { 4, 6, 33, 3, 1, 164, 115, 136 };
                    serialPort1.Write(bytes42, 0, bytes42.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "43":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes43 = { 4, 6, 33, 3, 1, 174, 243, 143 };
                    serialPort1.Write(bytes43, 0, bytes43.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "44":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes44 = { 4, 6, 33, 3, 1, 184, 114, 65 };
                    serialPort1.Write(bytes44, 0, bytes44.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "45":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes45 = { 4, 6, 33, 3, 1, 194, 243, 162 };
                    serialPort1.Write(bytes45, 0, bytes45.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "46":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes46 = { 4, 6, 33, 3, 1, 204, 114, 102 };
                    serialPort1.Write(bytes46, 0, bytes46.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "47":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes47 = { 4, 6, 33, 3, 1, 214, 243, 173 };
                    serialPort1.Write(bytes47, 0, bytes47.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "48":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes48 = { 4, 6, 33, 3, 1, 224, 115, 187 };
                    serialPort1.Write(bytes48, 0, bytes48.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "49":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes49 = { 4, 6, 33, 3, 1, 234, 243, 188 };
                    serialPort1.Write(bytes49, 0, bytes49.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "50":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes50 = { 4, 6, 33, 3, 1, 244, 115, 180 };
                    serialPort1.Write(bytes50, 0, bytes50.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "51":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes51 = { 4, 6, 33, 3, 1, 254, 243, 179 };
                    serialPort1.Write(bytes51, 0, bytes51.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "52":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes52 = { 4, 6, 33, 3, 2, 8, 115, 5 };
                    serialPort1.Write(bytes52, 0, bytes52.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "53":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes53 = { 4, 6, 33, 3, 2, 18, 242, 206 };
                    serialPort1.Write(bytes53, 0, bytes53.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "54":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes54 = { 4, 6, 33, 3, 2, 28, 115, 10 };
                    serialPort1.Write(bytes54, 0, bytes54.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "55":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes55 = { 4, 6, 33, 3, 2, 38, 243, 25 };
                    serialPort1.Write(bytes55, 0, bytes55.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "56":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes56 = { 4, 6, 33, 3, 2, 48, 114, 215 };
                    serialPort1.Write(bytes56, 0, bytes56.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "57":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes57 = { 4, 6, 33, 3, 2, 58, 242, 208 };
                    serialPort1.Write(bytes57, 0, bytes57.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "58":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes58 = { 4, 6, 33, 3, 2, 68, 114, 240 };
                    serialPort1.Write(bytes58, 0, bytes58.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "59":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes59 = { 4, 6, 33, 3, 2, 78, 242, 247 };
                    serialPort1.Write(bytes59, 0, bytes59.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "60":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes60 = { 4, 6, 33, 3, 2, 88, 115, 57 };
                    serialPort1.Write(bytes60, 0, bytes60.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "61":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes61 = { 4, 6, 33, 3, 2, 98, 243, 42 };
                    serialPort1.Write(bytes61, 0, bytes61.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "62":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes62 = { 4, 6, 33, 3, 2, 108, 114, 238 };
                    serialPort1.Write(bytes62, 0, bytes62.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "63":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes63 = { 4, 6, 33, 3, 2, 118, 243, 37 };
                    serialPort1.Write(bytes63, 0, bytes63.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "64":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes64 = { 4, 6, 33, 3, 2, 128, 115, 99 };
                    serialPort1.Write(bytes64, 0, bytes64.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "65":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes65 = { 4, 6, 33, 3, 2, 138, 243, 100 };
                    serialPort1.Write(bytes65, 0, bytes65.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "66":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes66 = { 4, 6, 33, 3, 2, 148, 115, 108 };
                    serialPort1.Write(bytes66, 0, bytes66.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "67":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes67 = { 4, 6, 33, 3, 2, 158, 243, 107 };
                    serialPort1.Write(bytes67, 0, bytes67.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "68":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes68 = { 4, 6, 33, 3, 2, 168, 115, 125 };
                    serialPort1.Write(bytes68, 0, bytes68.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "69":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes69 = { 4, 6, 33, 3, 2, 178, 242, 182 };
                    serialPort1.Write(bytes69, 0, bytes69.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "70":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes70 = { 4, 6, 33, 3, 2, 188, 115, 114 };
                    serialPort1.Write(bytes70, 0, bytes70.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "71":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes71 = { 4, 6, 33, 3, 2, 198, 242, 145 };
                    serialPort1.Write(bytes71, 0, bytes71.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "72":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes72 = { 4, 6, 33, 3, 2, 208, 115, 95 };
                    serialPort1.Write(bytes72, 0, bytes72.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "73":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes73 = { 4, 6, 33, 3, 2, 218, 243, 88 };
                    serialPort1.Write(bytes73, 0, bytes73.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "74":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes74 = { 4, 6, 33, 3, 2, 228, 114, 136 };
                    serialPort1.Write(bytes74, 0, bytes74.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "75":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes75 = { 4, 6, 33, 3, 2, 238, 242, 143 };
                    serialPort1.Write(bytes75, 0, bytes75.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "76":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes76 = { 4, 6, 33, 3, 2, 248, 115, 65 };
                    serialPort1.Write(bytes76, 0, bytes76.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "77":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes77 = { 4, 6, 33, 3, 3, 2, 242, 146 };
                    serialPort1.Write(bytes77, 0, bytes77.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "78":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes78 = { 4, 6, 33, 3, 3, 12, 115, 86 };
                    serialPort1.Write(bytes78, 0, bytes78.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "79":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes79 = { 4, 6, 33, 3, 3, 22, 242, 157 };
                    serialPort1.Write(bytes79, 0, bytes79.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "80":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes80 = { 4, 6, 33, 3, 3, 32, 114, 139 };
                    serialPort1.Write(bytes80, 0, bytes80.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "81":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes81 = { 4, 6, 33, 3, 3, 42, 242, 140 };
                    serialPort1.Write(bytes81, 0, bytes81.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "82":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes82 = { 4, 6, 33, 3, 3, 52, 114, 132 };
                    serialPort1.Write(bytes82, 0, bytes82.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "83":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes83 = { 4, 6, 33, 3, 3, 62, 242, 131 };
                    serialPort1.Write(bytes83, 0, bytes83.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "84":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes84 = { 4, 6, 33, 3, 3, 72, 115, 101 };
                    serialPort1.Write(bytes84, 0, bytes84.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "85":
                    SetConfigSerialPortForHeater();
                    Thread.Sleep(1000);
                    serialPort1.DiscardOutBuffer();
                    //TODO Cambiar las cadenas
                    byte[] bytes85 = { 4, 6, 33, 3, 3, 82, 242, 174 };
                    serialPort1.Write(bytes85, 0, bytes85.Length);
                    BanderaRespuestaParaTCS = false;
                    Thread.Sleep(1000);
                    SetConfigSerialPortForTCS();
                    // Check ☻

                    break;
                case "86":

                    break;
                case "87":

                    break;
                case "88":

                    break;
                case "89":

                    break;
                case "90":

                    break;
                case "91":

                    break;
                case "92":

                    break;
                case "93":

                    break;
                case "94":

                    break;
                case "95":

                    break;
                case "96":

                    break;
                case "97":

                    break;
                case "98":

                    break;
                case "99":

                    break;
                case "100":

                    break;

            }
        }

        bool BanderaRespuestaParaTCS = false;
        private void SetConfigSerialPortForTCS()
        {
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;

        }
        private void SetConfigSerialPortForHeater()
        {
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.Even;
        }

        private void btnApplySetpoint2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) 
            {
                if (!string.IsNullOrEmpty(txtPutSetpoint2.Text.Trim())) 
                {
                    if (Convert.ToInt32(txtPutSetpoint2.Text) >= 1 && Convert.ToInt32(txtPutSetpoint2.Text) <= 10)
                    {
                        SendSetTempHeaterAndTurnItOn();
                        double setpoint2 = Convert.ToDouble(txtPutSetpoint2.Text.ToString());
                        lbCurrentSetpoint2.Text = setpoint2.ToString("0.0") + " °C";
                    }
                    else
                    {
                       MessageBox.Show("Out of range\nRange from 1°C to 10°C", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
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

        private void TextBox_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderLabel(sender, e);
        }

        double rt = 0;                              // Time X from chart
        double temp = 0;                            // Time in ms
        double setpoint = 25;

        private void timerSimulationCharts_Tick(object sender, EventArgs e)
        {
            rt = rt + 100;
            temp = rt / 1000;

            int margen = 2;
            Random random = new Random();

            double numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-1"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC1.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-2"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC2.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-3"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC3.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-4"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC4.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-5"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC5.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-6"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC6.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-7"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC7.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-8"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC8.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-9"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC9.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-10"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC10.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-11"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC11.Text = numeroAleatorio.ToString() + " °C";

            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            chartZone1.Series["T-12"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
            txtTC12.Text = numeroAleatorio.ToString() + " °C";

            List<double> temperaturas = new List<double>();

            for (int i = 1; i <= 12; i++)
            {
                string nombreLabel = "txtTC" + i;
                Label label = this.Controls.Find(nombreLabel, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    // Obtiene el texto del label
                    string textoLabel = label.Text;

                    // Elimina " °C" del texto y convierte a double
                    if (textoLabel.Contains(" °C"))
                    {
                        textoLabel = textoLabel.Replace(" °C", "");
                        if (double.TryParse(textoLabel, out double valor))
                        {
                            temperaturas.Add(valor);
                        }
                    }
                }
            }

            if (temperaturas.Count > 0)
            {
                double promedio = temperaturas.Average();

                // Ahora, "promedio" contiene el promedio de las temperaturas
                // Puedes usar este valor como desees.
               lbAVGTemp1.Text = promedio.ToString("0.0") + " °C";
               lbCurrentSetpoint1.Text = setpointGoal.ToString("0.0")+ " °C";
            }

            chartZone1.ChartAreas[0].AxisX.Interval = 10;
            chartZone1.ChartAreas[0].AxisY2.Maximum = Double.NaN;
            chartZone1.ChartAreas[0].AxisY2.Minimum = Double.NaN;
            chartZone1.ChartAreas[0].RecalculateAxesScale();

            if (chartZone1.Series["T-1"].Points.Count == 111)
            {
                chartZone1.Series["T-1"].Points.RemoveAt(0);
                chartZone1.Series["T-2"].Points.RemoveAt(0);
                chartZone1.Series["T-3"].Points.RemoveAt(0);
                chartZone1.Series["T-4"].Points.RemoveAt(0);
                chartZone1.Series["T-5"].Points.RemoveAt(0);
                chartZone1.Series["T-6"].Points.RemoveAt(0);
                chartZone1.Series["T-7"].Points.RemoveAt(0);
                chartZone1.Series["T-8"].Points.RemoveAt(0);
                chartZone1.Series["T-9"].Points.RemoveAt(0);
                chartZone1.Series["T-10"].Points.RemoveAt(0);
                chartZone1.Series["T-11"].Points.RemoveAt(0);
                chartZone1.Series["T-12"].Points.RemoveAt(0);
            }


        }

        private void checkT1_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-1"].Enabled = checkT1.Checked ? true : false;
        }

        private void checkT2_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-2"].Enabled = checkT2.Checked ? true : false;
        }

        private void checkT3_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-3"].Enabled = checkT3.Checked ? true : false;
        }

        private void checkT4_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-4"].Enabled = checkT4.Checked ? true : false;
        }

        private void checkT5_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-5"].Enabled = checkT5.Checked ? true : false;
        }

        private void checkT6_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-6"].Enabled = checkT6.Checked ? true : false;
        }

        private void checkT7_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-7"].Enabled = checkT7.Checked ? true : false;
        }

        private void checkT8_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-8"].Enabled = checkT8.Checked ? true : false;
        }

        private void checkT9_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-9"].Enabled = checkT9.Checked ? true : false;
        }

        private void checkT10_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-10"].Enabled = checkT10.Checked ? true : false;
        }

        private void checkT11_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-11"].Enabled = checkT11.Checked ? true : false;
        }

        private void checkT12_CheckedChanged(object sender, EventArgs e)
        {
            chartZone1.Series["T-12"].Enabled = checkT12.Checked ? true : false;
        }

        private void panelControlZone2_MouseEnter(object sender, EventArgs e)
        {
            picDrawMachine.Image = Resources.draw21;
            lbTitleZone2.BackColor = Color.Yellow;
            panelTitleZone2.BackColor = Color.Yellow;
        }

        private void panelControlZone2_MouseLeave(object sender, EventArgs e)
        {
            picDrawMachine.Image = Resources.drawOff1;
            lbTitleZone2.BackColor = Color.White;
            panelTitleZone2.BackColor = Color.White;
        }

        private void panelControlZone1_MouseEnter(object sender, EventArgs e)
        {
            picDrawMachine.Image = Resources.draw11;
            lbTitleZone1.BackColor = Color.Yellow;
            panelTitleZone1.BackColor = Color.Yellow;
        }

        private void panelControlZone1_MouseLeave(object sender, EventArgs e)
        {
            picDrawMachine.Image = Resources.drawOff1;
            lbTitleZone1.BackColor = Color.White;
            panelTitleZone1.BackColor = Color.White;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarReporte("Example");
        }

        private void GenerarReporte(string NombreReport)
        {
            // Llamar el aumentador del contador
            //AumentarContadorReportesGenerados();

            Bitmap screenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(screenCapture);
            g.CopyFromScreen(0, 0, 0, 0, screenCapture.Size);
            string tempPath = Path.Combine(Path.GetTempPath(), "screenshot.jpg");
            screenCapture.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            ReportDocument MiReporte = new ReportDocument();
            FrmVisualizadorCrystalReport Visualizador = new FrmVisualizadorCrystalReport();

            MiReporte.Load("../../Reports/RptCyclesComplete.rpt");
            MiReporte.SetParameterValue("CompleteCycles", /*lbCountCycles.Text*/"XXXX");
            MiReporte.SetParameterValue("GoalCycles", /*lbGoalCycles.Text*/"XXXX");
            MiReporte.SetParameterValue("NameReport", NombreReport);
            MiReporte.SetParameterValue("ImagePath", tempPath);

           // string k = DateStartedTest.Text;
            //string j = k.Replace("\n", " - ");

            MiReporte.SetParameterValue("DateTimeStartedTest", /*j*/"XXXX");

           // k = DateEndedTest.Text;
           // j = k.Replace("\n", " - ");

            MiReporte.SetParameterValue("DateTimeFinishTest", /*j*/"XXXX");

            // if (TestToRun == 1)
            //{
            //    MiReporte.SetParameterValue("PhaseName", "[1] Pretest System Calibration");
            //}
            // else if (TestToRun == 2)
            //{
            //    MiReporte.SetParameterValue("PhaseName", "[2] Stability Test");
            //}
            //else if (TestToRun == 3)
            //{
            //    MiReporte.SetParameterValue("PhaseName", "[3] Valve Leak Test");
            //}
            //else
            //{
                MiReporte.SetParameterValue("PhaseName", "Phase not selected yet");
            //}

            Visualizador.crystalReportViewer1.ReportSource = MiReporte;
            Visualizador.crystalReportViewer1.Zoom(85);
            Visualizador.Show();
        }

        private void btnConnectCOM2_Click(object sender, EventArgs e)
        {
            if (reconocerCOM(cbCOMSelect2.SelectedItem.ToString()))
            {
                btnConnectCOM2.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            }
        }

        private bool reconocerCOM(string COM)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    return false;
                }
                // Remember Baud Rate
                serialPort1.PortName = COM;
                serialPort1.Open();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}