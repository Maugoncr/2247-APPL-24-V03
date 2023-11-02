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
using System.Text;
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
            Control.CheckForIllegalCrossThreadCalls = false;
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

        //ZONE TO VARIABLES
        private StreamWriter streamWriterZone1;
        private string tempFileName1; 

        private StreamWriter streamWriterZone2;
        private string tempFileName2;

        private bool RecordZone1 = false;
        private bool RecordZone2 = false;

        private bool firstEntranceZone1 = true;
        private bool firstEntranceZone2 = true;

        private string inicioRecordZone1;
        private string inicioRecordZone2;

        string viewChart = "Both";

        double rt1 = 0;                              
        double temp1 = 0;
        double rt2 = 0;                              
        double temp2 = 0;
        double rtView = 0;                            
        double tempView = 0;

        double AVGZona1, AVGZona2;


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
            viewChart = "Both";
            ChangeViewChartZone();
            rt1 = 0;temp1 = 0;
            rt2 = 0;temp2 = 0;
            rtView = 0; tempView = 0;
        }

        private void tempZone1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewChart = "Zone1";
            ChangeViewChartZone(1);
            rt1 = 0; temp1 = 0;
            rt2 = 0; temp2 = 0;
            rtView = 0; tempView = 0;
        }

        private void tempZone2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewChart = "Zone2";
            ChangeViewChartZone(2);
            rt1 = 0; temp1 = 0;
            rt2 = 0; temp2 = 0;
            rtView = 0; tempView = 0;
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

                nt.ShowDialog();
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

            if (RecordZone1 == true)
            {
                if (firstEntranceZone1)
                {
                    tempFileName1 = Path.Combine(Path.GetTempPath(), "ELEN II_" + Guid.NewGuid().ToString() + ".txt");
                    streamWriterZone1 = new StreamWriter(tempFileName1, true);
                    streamWriterZone1.WriteLine("DateTime,RunningTime,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12");
                    inicioRecordZone1 = DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");
                    firstEntranceZone1 = false;
                }
                
                streamWriterZone1.WriteLine(DateTime.Now.ToString("MM/dd/yyyy") + "," + DateTime.Now.ToString("HH:mm:ss")+ "," + TF1 + ","
                    + TF2 + "," + TF3 + "," + TF4 + "," + TF5 + "," + TF6 + "," + TF7 + "," + TF8 + "," + TF9 + "," + TF10 + "," + TF11 + "," + TF12);
            }

            if (RecordZone2 == true)
            {
                if (firstEntranceZone2)
                {
                    tempFileName2 = Path.Combine(Path.GetTempPath(), "ELEN II_" + Guid.NewGuid().ToString() + ".txt");
                    streamWriterZone2 = new StreamWriter(tempFileName2, true);
                    streamWriterZone2.WriteLine("DateTime,RunningTime,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24");
                    inicioRecordZone2 = DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");
                    firstEntranceZone2 = false;
                }
                streamWriterZone2.WriteLine(DateTime.Now.ToString("MM/dd/yyyy") + "," + DateTime.Now.ToString("HH:mm:ss") + "," + TF13 + ","
                    + TF14 + "," + TF15 + "," + TF16 + "," + TF17 + "," + TF18 + "," + TF19 + "," + TF20 + "," + TF21 + "," + TF22 + "," + TF23 + "," + TF24);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timerDateTimeAndRecord.Start();
            FillChartZones(1);
            FillChartZones(2);
            FrmCargarDefault();
        }

        private void FrmCargarDefault()
        {
            //Record

            btnRecordZone1.Text = "Record"; btnRecordZone1.ForeColor = Color.Black; btnRecordZone1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            btnRecordZone1.Size = new Size(109,33); btnRecordZone1.Location = new Point(409,234);
            btnRecordZone2.Text = "Record"; btnRecordZone2.ForeColor = Color.Black; btnRecordZone2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            btnRecordZone2.Size = new Size(109, 33); btnRecordZone2.Location = new Point(409, 234);

            // Chart Settings

            chartZone1.ChartAreas[0].AxisY.Interval = 10;
            chartZone1.ChartAreas[0].AxisY.Maximum = 100;
            chartZone1.ChartAreas[0].AxisY.Minimum = 0;
            chartZone1.ChartAreas[0].AxisX.Minimum = 0;
            chartZone1.ChartAreas[0].BackColor = Color.FromArgb(30, Color.LightGreen);


            chartZone2.ChartAreas[0].AxisY.Interval = 10;
            chartZone2.ChartAreas[0].AxisY.Maximum = 100;
            chartZone2.ChartAreas[0].AxisY.Minimum = 0;
            chartZone2.ChartAreas[0].AxisX.Minimum = 0;
            chartZone2.ChartAreas[0].BackColor = Color.FromArgb(30, Color.LightGreen);

            chartView.ChartAreas[0].AxisY.Interval = 10;
            chartView.ChartAreas[0].AxisY.Maximum = 100;
            chartView.ChartAreas[0].AxisY.Minimum = 0;
            chartView.ChartAreas[0].AxisX.Minimum = 0;
            chartView.ChartAreas[0].BackColor = Color.FromArgb(30, Color.LightGreen);


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
            comboBoxes = new List<ComboBox> { cbCOMSelect1, cbCOMSelect2 };

            // Suscribe al evento SelectedIndexChanged para todos los ComboBox
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

       

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }


        private void timerSimulationDownUp_Tick(object sender, EventArgs e)
        {
            int margen = 2;
            Random random = new Random();

            double numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF1 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF2 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF3 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF4 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF5 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF6 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF7 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF8 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF9 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF10 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF11 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF12 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF13 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF14 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF15 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF16 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF17 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF18 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF19 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF20 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF21 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF22 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF23 = numeroAleatorio.ToString("00.00");
            numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
            TF24 = numeroAleatorio.ToString("00.00");


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

            if (viewChart == "Both")
            {
                double numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
                chartZone2.Series["T-13"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());
                txtTC13.Text = numeroAleatorio.ToString() + " °C";

                numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
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
                    //  lbCurrentSetpoint1.Text = setpointGoal.ToString("0.0") + " °C";
                }

                //chartZone1.ChartAreas[0].AxisY.Interval = 10;

                //chartZone1.ChartAreas[0].AxisY.Maximum = double.NaN;
                //chartZone1.ChartAreas[0].AxisY.Minimum = 0;
                //chartZone1.ChartAreas[0].AxisX.Minimum = 0;

                chartZone1.ChartAreas[0].RecalculateAxesScale();



                if (chartZone1.Series["T-1"].Points.Count == 101)
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
            else if (viewChart == "Zone1")
            {
                double numeroAleatorio = random.NextDouble() * (2 * margen) + (setpoint - margen);
                chartView.Series["T-1"].Points.AddXY(temp.ToString(), numeroAleatorio.ToString());

                txtView1.Text = numeroAleatorio.ToString() + " °C";

                chartView.ChartAreas[0].RecalculateAxesScale();

                if (chartView.Series["T-1"].Points.Count == 101)
                {
                    chartView.Series["T-1"].Points.RemoveAt(0);
                    //chartView.Series["T-2"].Points.RemoveAt(0);
                    //chartView.Series["T-3"].Points.RemoveAt(0);
                    //chartView.Series["T-4"].Points.RemoveAt(0);
                    //chartView.Series["T-5"].Points.RemoveAt(0);
                    //chartView.Series["T-6"].Points.RemoveAt(0);
                    //chartView.Series["T-7"].Points.RemoveAt(0);
                    //chartView.Series["T-8"].Points.RemoveAt(0);
                    //chartView.Series["T-9"].Points.RemoveAt(0);
                    //chartView.Series["T-10"].Points.RemoveAt(0);
                    //chartView.Series["T-11"].Points.RemoveAt(0);
                    //chartView.Series["T-12"].Points.RemoveAt(0);
                }

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

            MiReporte.SetParameterValue("AVGTempZone1", lbAVGTemp1.Text);
            MiReporte.SetParameterValue("AVGTempZone2", lbAVGTemp2.Text);
            MiReporte.SetParameterValue("ExecutionTimeZone1", lbStartDate1.Text);
            MiReporte.SetParameterValue("ExecutionTimeZone2", lbStartDate2.Text);
            MiReporte.SetParameterValue("HeatingCounterZone1", Settings.Default.CountHeat1.ToString());
            MiReporte.SetParameterValue("HeatingCounterZone2", Settings.Default.CountHeat2.ToString());
            MiReporte.SetParameterValue("CoolingCounterZone1", Settings.Default.CountCool1.ToString());
            MiReporte.SetParameterValue("CoolingCounterZone2", Settings.Default.CountCool2.ToString());
            MiReporte.SetParameterValue("ImagePath", tempPath);

            // string k = DateStartedTest.Text;
            //string j = k.Replace("\n", " - ");

            //MiReporte.SetParameterValue("DateTimeStartedTest", /*j*/"XXXX");

            // k = DateEndedTest.Text;
            // j = k.Replace("\n", " - ");

            //MiReporte.SetParameterValue("DateTimeFinishTest", /*j*/"XXXX");

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
            //MiReporte.SetParameterValue("PhaseName", "Phase not selected yet");
            //}

            Visualizador.crystalReportViewer1.ReportSource = MiReporte;
            Visualizador.crystalReportViewer1.Zoom(125);
            Visualizador.Show();
        }

        private void btnConnectCOM2_Click(object sender, EventArgs e)
        {
            if (btnConnectCOM2.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                try
                {
                    serialPort2.PortName = cbCOMSelect2.Text;
                    serialPort2.Open();
                    serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived_1);

                    btnConnectCOM2.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                    btnRefreshCOM2.Enabled = false;

                    timerRequestTemps.Start();
                    timerGraficarCharts.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (serialPort2.IsOpen)
                {
                    serialPort2.Close();

                    timerRequestTemps.Stop();
                    timerGraficarCharts.Stop();

                    btnConnectCOM2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                    btnRefreshCOM2.Enabled = true;
                }
            }
        }

        private void btnConnectCOM1_Click(object sender, EventArgs e)
        {
            if (btnConnectCOM1.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                if (reconocerCOMForComponents(cbCOMSelect1.SelectedItem.ToString()))
                {
                    btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                    btnRefreshCOM1.Enabled = false;

                    EncenderRojo();
                    //SIMULATION
                   // timerSimulationCharts.Start();
                   //timerSimulationDownUp.Start();
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    ApagarAllLeds();

                    serialPort1.Close();
                    btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                    btnRefreshCOM1.Enabled = true;
                }
            }
        }

        private bool reconocerCOMForComponents(string COM)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void panelBoth_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }

        private void panelControlZone1_Paint_1(object sender, PaintEventArgs e)
        {
            CreateBorderPanel(sender, e);
        }

        private void btnApplySetpoint1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtPutSetpoint1.Text;

                if (int.TryParse(input, out int number))
                {
                    // Comprueba si el número está en el rango de 5 a 85
                    if (number >= 5 && number <= 85)
                    {
                        int setpoint = Convert.ToInt32(txtPutSetpoint1.Text);

                        if (setpoint >= 27 && setpoint <= 85)
                        {
                            try
                            {
                                SendSetTempHeaterAndTurnItOn(1);
                                CountOmronUse(1);

                                picProcess1.Image.Dispose();
                                picProcess1.Image = Resources.LedRedHeating2;
                                picUpDown1.Image.Dispose();
                                picUpDown1.Image = Resources.arrowUpRed21;

                                FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();
                                if (customForm.ShowDialog() == DialogResult.OK)
                                {
                                    ApagarChillerZone(1);

                                    Thread.Sleep(50);

                                    EncenderVerde();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (setpoint >= 21 && setpoint <= 26)
                        {
                            try
                            {
                                SendSetTempHeaterAndTurnItOn(1);
                                CountOmronUse(1);

                                FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();
                                if (customForm.ShowDialog() == DialogResult.OK)
                                {
                                    EncenderChillerZone(1);
                                    CountChillerUse(1);

                                    Thread.Sleep(100);
                                    SendCommandSetpointChiller(txtPutSetpoint1.Text, 8);

                                    // Tenemos que dejar a temperatura ambiente
                                    picUpDown1.Image.Dispose();
                                    picUpDown1.Image = Resources.neutroWhite;
                                    picProcess1.Image.Dispose();
                                    picProcess1.Image = Resources.LedWhite1;

                                    EncenderVerde();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                        else if (setpoint >= 5 && setpoint <= 20)
                        {
                            try
                            {
                                SendSetTempHeaterAndTurnItOn(1);
                                CountOmronUse(1);

                                FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();
                                if (customForm.ShowDialog() == DialogResult.OK)
                                {
                                    EncenderChillerZone(1);
                                    CountChillerUse(1);

                                    Thread.Sleep(100);
                                    SendCommandSetpointChiller(txtPutSetpoint1.Text, 8);

                                    picUpDown1.Image.Dispose();
                                    picUpDown1.Image = Resources.arrowDownBlue2;
                                    picProcess1.Image.Dispose();
                                    picProcess1.Image = Resources.LedBlueCooling2;

                                    EncenderVerde();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 5 and 85", "Number out of range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SetConfigSerialPortForChiller()
        {
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.WriteTimeout = -1;
        }

        //ENCENDER LUCES
        private void setConfigSerialPortLeds()
        {
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
        }

        private void EncenderRojo()
        { 
            setConfigSerialPortLeds();
            picGreen.Image.Dispose();
            picGreen.Image = Resources.tc8off;
            picYellow.Image.Dispose();
            picYellow.Image = Resources.tc3off;
            picRed.Image.Dispose();
            picRed.Image = Resources.tc1on;
            serialPort1.Write("#070004" + "\r");
        }
        private void EncenderVerde()
        {
            setConfigSerialPortLeds();
            picGreen.Image.Dispose();
            picGreen.Image = Resources.tc8on;
            picYellow.Image.Dispose();
            picYellow.Image = Resources.tc3off;
            picRed.Image.Dispose();
            picRed.Image = Resources.tc1off;
            serialPort1.Write("#070001" + "\r");
        }

        private void EncenderAmarillo()
        {
            setConfigSerialPortLeds();
            picGreen.Image.Dispose();
            picGreen.Image = Resources.tc8off;
            picYellow.Image.Dispose();
            picYellow.Image = Resources.tc3on;
            picRed.Image.Dispose();
            picRed.Image = Resources.tc1off;
            serialPort1.Write("#070002" + "\r");
        }

        private void EncenderAllLeds()
        {
            setConfigSerialPortLeds();
            picGreen.Image.Dispose();
            picGreen.Image = Resources.tc8on;
            picYellow.Image.Dispose();
            picYellow.Image = Resources.tc3on;
            picRed.Image.Dispose();
            picRed.Image = Resources.tc1on;
            serialPort1.Write("#070007" + "\r");
        }

        private void ApagarAllLeds()
        {
            setConfigSerialPortLeds();
            picGreen.Image.Dispose();
            picGreen.Image = Resources.tc8off;
            picYellow.Image.Dispose();
            picYellow.Image = Resources.tc3off;
            picRed.Image.Dispose();
            picRed.Image = Resources.tc1off;
            serialPort1.Write("#070000" + "\r");
        }

        private void SendCommandSetpointChiller(string temperature, int adress)
        {
            string commandResult = "";

            //Chiller Zona 1 Address 8
            if (adress == 8)
            {
                // Constante que debemos cambiar si cambia el ADRESS
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                string hexConstante = "CC 00 08 F0 02";
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                // 2- Obtener el valor deseado en temperatura y hacerle el x10
                if (double.TryParse(temperature, out double inputValue))
                {
                    //lbCurrentSetpoint2.Text = inputValue.ToString();
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
                    string hexConstanteSumada = "FA";
                    //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                    int intValue1 = Convert.ToInt32(hexConstanteSumada, 16);
                    int intValue2;
                    int intValue3;
                    int sum;
                    // Se verifica si la cadena con el valor hex es de dos digitos o de tres ejemplo: 00FA "•2" || 01FA "•1"
                    if (hexTemp.Substring(1, 1) != "0")
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

                    // 12- Enviar Comando
                    string[] hexBytes;
                    byte[] binaryData;
                    SetConfigSerialPortForChiller();
                    hexBytes = commandResult.Split(' ');
                    binaryData = new byte[hexBytes.Length];
                    for (int i = 0; i < hexBytes.Length; i++)
                    {
                        binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                    }
                    serialPort1.Write(binaryData, 0, binaryData.Length);
                    
                }

            }
            // Chiller Zona 2 Address 9
            else if (adress == 9)
            {
                // Constante que debemos cambiar si cambia el ADRESS
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                string hexConstante = "CC 00 09 F0 02";
                //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                // 2- Obtener el valor deseado en temperatura y hacerle el x10
                if (double.TryParse(temperature, out double inputValue))
                {
                    //  lbCurrentSetpoint2.Text = inputValue.ToString();
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
                    string hexConstanteSumada = "FB";
                    //•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
                    int intValue1 = Convert.ToInt32(hexConstanteSumada, 16);
                    int intValue2;
                    int intValue3;
                    int sum;
                    // Se verifica si la cadena con el valor hex es de dos digitos o de tres ejemplo: 00FA "•2" || 01FA "•1"
                    if (hexTemp.Substring(1, 1) != "0")
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

                    // 12- Enviar Comando
                    string[] hexBytes;
                    byte[] binaryData;
                    SetConfigSerialPortForChiller();
                    hexBytes = commandResult.Split(' ');
                    binaryData = new byte[hexBytes.Length];
                    for (int i = 0; i < hexBytes.Length; i++)
                    {
                        binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                    }
                    serialPort1.Write(binaryData, 0, binaryData.Length);
                }
            }
        }

        private void btnApplySetpoint2_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtPutSetpoint2.Text;
                if (int.TryParse(input, out int number))
                {
                    // Comprueba si el número está en el rango de 5 a 85
                    if (number >= 5 && number <= 85)
                    {
                        int setpoint = Convert.ToInt32(txtPutSetpoint2.Text);
                        // HEATING
                        if (setpoint >= 27 && setpoint <= 85)
                        {
                            try
                            {
                                SendSetTempHeaterAndTurnItOn(2);
                                CountOmronUse(2);

                                picProcess2.Image.Dispose();
                                picProcess2.Image = Resources.LedRedHeating2;
                                picUpDown2.Image.Dispose();
                                picUpDown2.Image = Resources.arrowUpRed21;

                                FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();

                                if (customForm.ShowDialog() == DialogResult.OK)
                                {
                                    ApagarChillerZone(2);

                                    Thread.Sleep(50);

                                    EncenderVerde();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        // NEUTRAL
                        else if (setpoint >= 21 && setpoint <= 26)
                        {
                            try
                            {
                                SendSetTempHeaterAndTurnItOn(2);
                                CountOmronUse(2);

                                FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();

                                if (customForm.ShowDialog() == DialogResult.OK)
                                {
                                    EncenderChillerZone(2);
                                    CountChillerUse(2);

                                    Thread.Sleep(100);

                                    SendCommandSetpointChiller(txtPutSetpoint2.Text, 9);

                                    picUpDown2.Image.Dispose();
                                    picUpDown2.Image = Resources.neutroWhite;
                                    picProcess2.Image.Dispose();
                                    picProcess2.Image = Resources.LedWhite1;

                                    EncenderVerde();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        // COOLING
                        else if (setpoint >= 5 && setpoint <= 20)
                        {
                            try
                            {
                                SendSetTempHeaterAndTurnItOn(2);
                                CountOmronUse(2);

                                FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();

                                if (customForm.ShowDialog() == DialogResult.OK)
                                {
                                    EncenderChillerZone(2);
                                    CountChillerUse(2);

                                    Thread.Sleep(100);

                                    SendCommandSetpointChiller(txtPutSetpoint2.Text, 9);

                                    picUpDown2.Image.Dispose();
                                    picUpDown2.Image = Resources.arrowDownBlue2;
                                    picProcess2.Image.Dispose();
                                    picProcess2.Image = Resources.LedBlueCooling2;

                                    EncenderVerde();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 5 and 85", "Number out of range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SetConfigSerialPortForHeater()
        {
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.WriteTimeout = 100;
        }


        private void SendSetTempHeaterAndTurnItOn(int which)
        {
            SetConfigSerialPortForHeater();
            string hexCommand;
            string[] hexBytes;
            byte[] binaryData;

            if (which == 1)
            {
                switch (txtPutSetpoint1.Text)
                {
                    case "0":
                        hexCommand = "01 06 21 03 00 00 73 F6";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "1":
                        hexCommand = "01 06 21 03 00 01 B2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "2":
                        hexCommand = "01 06 21 03 00 02 F2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "3":
                        hexCommand = "01 06 21 03 00 03 33 F7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "4":
                        hexCommand = "01 06 21 03 00 04 72 35";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "5":
                        hexCommand = "01 06 21 03 00 05 B3 F5";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "6":
                        hexCommand = "01 06 21 03 00 06 F3 F4";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "7":
                        hexCommand = "01 06 21 03 00 07 32 34";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "8":
                        hexCommand = "01 06 21 03 00 08 72 30";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "9":
                        hexCommand = "01 06 21 03 00 09 B3 F0";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "10":
                        hexCommand = "01 06 21 03 00 0A F3 F1";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "11":
                        hexCommand = "01 06 21 03 00 0B 32 31";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "12":
                        hexCommand = "01 06 21 03 00 0C 73 F3";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "13":
                        hexCommand = "01 06 21 03 00 0D B2 33";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "14":
                        hexCommand = "01 06 21 03 00 0E F2 32";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "15":
                        hexCommand = "01 06 21 03 00 0F 33 F2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "16":
                        hexCommand = "01 06 21 03 00 10 72 3A";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "17":
                        hexCommand = "01 06 21 03 00 11 B3 FA";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "18":
                        hexCommand = "01 06 21 03 00 12 F3 FB";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "19":
                        hexCommand = "01 06 21 03 00 13 32 3B";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "20":
                        hexCommand = "01 06 21 03 00 14 73 F9";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "21":
                        hexCommand = "01 06 21 03 00 15 B2 39";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "22":
                        hexCommand = "01 06 21 03 00 16 F2 38";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "23":
                        hexCommand = "01 06 21 03 00 17 33 F8";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "24":
                        hexCommand = "01 06 21 03 00 18 73 FC";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;

                    case "25":
                        hexCommand = "01 06 21 03 00 19 B2 3C";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "26":
                        hexCommand = "01 06 21 03 00 1A F2 3D";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "27":
                        hexCommand = "01 06 21 03 00 1B 33 FD";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "28":
                        hexCommand = "01 06 21 03 00 1C 72 3F";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "29":
                        hexCommand = "01 06 21 03 00 1D B3 FF";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "30":
                        hexCommand = "01 06 21 03 00 1E F3 FE";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "31":
                        hexCommand = "01 06 21 03 00 1F 32 3E";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "32":
                        hexCommand = "01 06 21 03 00 20 72 2E";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "33":
                        hexCommand = "01 06 21 03 00 21 B3 EE";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "34":
                        hexCommand = "01 06 21 03 00 22 F3 EF";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "35":
                        hexCommand = "01 06 21 03 00 23 32 2F";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "36":
                        hexCommand = "01 06 21 03 00 24 73 ED";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "37":
                        hexCommand = "01 06 21 03 00 25 B2 2D";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "38":
                        hexCommand = "01 06 21 03 00 26 F2 2C";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "39":
                        hexCommand = "01 06 21 03 00 27 33 EC";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "40":
                        hexCommand = "01 06 21 03 00 28 73 E8";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "41":
                        hexCommand = "01 06 21 03 00 29 B2 28";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "42":
                        hexCommand = "01 06 21 03 00 2A F2 29";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "43":
                        hexCommand = "01 06 21 03 00 2B 33 E9";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);

                        break;
                    case "44":
                        hexCommand = "01 06 21 03 00 2C 72 2B";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "45":
                        hexCommand = "01 06 21 03 00 2D B3 EB";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "46":
                        hexCommand = "01 06 21 03 00 2E F3 EA";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "47":
                        hexCommand = "01 06 21 03 00 2F 32 2A";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "48":
                        hexCommand = "01 06 21 03 00 30 73 E2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "49":
                        hexCommand = "01 06 21 03 00 31 B2 22";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "50":
                        hexCommand = "01 06 21 03 00 32 F2 23";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "51":
                        hexCommand = "01 06 21 03 00 33 33 E3";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "52":
                        hexCommand = "01 06 21 03 00 34 72 21";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "53":
                        hexCommand = "01 06 21 03 00 35 B3 E1";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "54":
                        hexCommand = "01 06 21 03 00 36 F3 E0";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "55":
                        hexCommand = "01 06 21 03 00 37 32 20";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "56":
                        hexCommand = "01 06 21 03 00 38 72 24";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "57":
                        hexCommand = "01 06 21 03 00 39 B3 E4";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "58":
                        hexCommand = "01 06 21 03 00 3A F3 E5";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "59":
                        hexCommand = "01 06 21 03 00 3B 32 25";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "60":
                        hexCommand = "01 06 21 03 00 3C 73 E7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "61":
                        hexCommand = "01 06 21 03 00 3D B2 27";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "62":
                        hexCommand = "01 06 21 03 00 3E F2 26";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "63":
                        hexCommand = "01 06 21 03 00 3F 33 E6";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "64":
                        hexCommand = "01 06 21 03 00 40 72 06";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "65":
                        hexCommand = "01 06 21 03 00 41 B3 C6";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "66":
                        hexCommand = "01 06 21 03 00 42 F3 C7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "67":
                        hexCommand = "01 06 21 03 00 43 32 07";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "68":
                        hexCommand = "01 06 21 03 00 44 73 C5";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "69":
                        hexCommand = "01 06 21 03 00 45 B2 05";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "70":
                        hexCommand = "01 06 21 03 00 46 F2 04";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "71":
                        hexCommand = "01 06 21 03 00 47 33 C4";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "72":
                        hexCommand = "01 06 21 03 00 48 73 C0";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "73":
                        hexCommand = "01 06 21 03 00 49 B2 00";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "74":
                        hexCommand = "01 06 21 03 00 4A F2 01";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "75":
                        hexCommand = "01 06 21 03 00 4B 33 C1";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "76":
                        hexCommand = "01 06 21 03 00 4C 72 03";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "77":
                        hexCommand = "01 06 21 03 00 4D B3 C3";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "78":
                        hexCommand = "01 06 21 03 00 4E F3 C2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "79":
                        hexCommand = "01 06 21 03 00 4F 32 02";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "80":
                        hexCommand = "01 06 21 03 00 50 73 CA";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "81":
                        hexCommand = "01 06 21 03 00 51 B2 0A";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "82":
                        hexCommand = "01 06 21 03 00 52 F2 0B";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "83":
                        hexCommand = "01 06 21 03 00 53 33 CB";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "84":
                        hexCommand = "01 06 21 03 00 54 72 09";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "85":
                        hexCommand = "01 06 21 03 00 55 B3 C9";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
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
            else if (which == 2)
            {
                switch (txtPutSetpoint2.Text)
                {
                    case "0":
                        hexCommand = "02 06 21 03 00 00 73 C5";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "1":
                        hexCommand = "01 06 21 03 00 01 B2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "2":
                        hexCommand = "01 06 21 03 00 02 F2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "3":
                        hexCommand = "01 06 21 03 00 03 33 F7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "4":
                        hexCommand = "01 06 21 03 00 04 72 35";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "5":
                        hexCommand = "02 06 21 03 00 05 B3 C6";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "6":
                        hexCommand = "02 06 21 03 00 06 F3 C7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "7":
                        hexCommand = "02 06 21 03 00 07 32 07";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "8":
                        hexCommand = "02 06 21 03 00 08 72 03";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "9":
                        hexCommand = "02 06 21 03 00 09 B3 C3";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "10":
                        hexCommand = "02 06 21 03 00 0A F3 C2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "11":
                        hexCommand = "02 06 21 03 00 0B 32 02";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "12":
                        hexCommand = "02 06 21 03 00 0C 73 C0";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "13":
                        hexCommand = "02 06 21 03 00 0D B2 00";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "14":
                        hexCommand = "02 06 21 03 00 0E F2 01";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "15":
                        hexCommand = "02 06 21 03 00 0F 33 C1";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "16":
                        hexCommand = "02 06 21 03 00 10 72 09";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "17":
                        hexCommand = "02 06 21 03 00 11 B3 C9";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "18":
                        hexCommand = "02 06 21 03 00 12 F3 C8";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "19":
                        hexCommand = "02 06 21 03 00 13 32 08";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "20":
                        hexCommand = "02 06 21 03 00 14 73 CA";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "21":
                        hexCommand = "02 06 21 03 00 15 B2 0A";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "22":
                        hexCommand = "02 06 21 03 00 16 F2 0B";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "23":
                        hexCommand = "02 06 21 03 00 17 33 CB";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "24":
                        hexCommand = "02 06 21 03 00 18 73 CF";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "25":
                        hexCommand = "02 06 21 03 00 19 B2 0F";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "26":
                        hexCommand = "02 06 21 03 00 1A F2 0E";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "27":
                        hexCommand = "02 06 21 03 00 1B 33 CE";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "28":
                        hexCommand = "02 06 21 03 00 1C 72 0C";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "29":
                        hexCommand = "02 06 21 03 00 1D B3 CC";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "30":
                        hexCommand = "02 06 21 03 00 1E F3 CD";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "31":
                        hexCommand = "02 06 21 03 00 1F 32 0D";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "32":
                        hexCommand = "02 06 21 03 00 20 72 1D";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "33":
                        hexCommand = "02 06 21 03 00 21 B3 DD";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "34":
                        hexCommand = "02 06 21 03 00 22 F3 DC";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "35":
                        hexCommand = "02 06 21 03 00 23 32 1C";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "36":
                        hexCommand = "02 06 21 03 00 24 73 DE";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "37":
                        hexCommand = "02 06 21 03 00 25 B2 1E";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "38":
                        hexCommand = "02 06 21 03 00 26 F2 1F";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "39":
                        hexCommand = "02 06 21 03 00 27 33 DF";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "40":
                        hexCommand = "02 06 21 03 00 28 73 DB";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "41":
                        hexCommand = "02 06 21 03 00 29 B2 1B";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "42":
                        hexCommand = "02 06 21 03 00 2A F2 1A";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "43":
                        hexCommand = "02 06 21 03 00 2B 33 DA";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);

                        break;
                    case "44":
                        hexCommand = "02 06 21 03 00 2C 72 18";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "45":
                        hexCommand = "02 06 21 03 00 2D B3 D8";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "46":
                        hexCommand = "02 06 21 03 00 2E F3 D9";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "47":
                        hexCommand = "02 06 21 03 00 2F 32 19";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "48":
                        hexCommand = "02 06 21 03 00 30 73 D1";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "49":
                        hexCommand = "02 06 21 03 00 31 B2 11";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "50":
                        hexCommand = "02 06 21 03 00 32 F2 10";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "51":
                        hexCommand = "02 06 21 03 00 33 33 D0";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "52":
                        hexCommand = "02 06 21 03 00 34 72 12";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "53":
                        hexCommand = "02 06 21 03 00 35 B3 D2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "54":
                        hexCommand = "02 06 21 03 00 36 F3 D3";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "55":
                        hexCommand = "02 06 21 03 00 37 32 13";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "56":
                        hexCommand = "02 06 21 03 00 38 72 17";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "57":
                        hexCommand = "02 06 21 03 00 39 B3 D7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "58":
                        hexCommand = "02 06 21 03 00 3A F3 D6";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "59":
                        hexCommand = "02 06 21 03 00 3B 32 16";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "60":
                        hexCommand = "02 06 21 03 00 3C 73 D4";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "61":
                        hexCommand = "02 06 21 03 00 3D B2 14";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "62":
                        hexCommand = "02 06 21 03 00 3E F2 15";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "63":
                        hexCommand = "02 06 21 03 00 3F 33 D5";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "64":
                        hexCommand = "02 06 21 03 00 40 72 35";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "65":
                        hexCommand = "02 06 21 03 00 41 B3 F5";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "66":
                        hexCommand = "02 06 21 03 00 42 F3 F4";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "67":
                        hexCommand = "02 06 21 03 00 43 32 34";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "68":
                        hexCommand = "02 06 21 03 00 44 73 F6";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "69":
                        hexCommand = "02 06 21 03 00 45 B2 36";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "70":
                        hexCommand = "02 06 21 03 00 46 F2 37";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "71":
                        hexCommand = "02 06 21 03 00 47 33 F7";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "72":
                        hexCommand = "02 06 21 03 00 48 73 F3";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "73":
                        hexCommand = "02 06 21 03 00 49 B2 33";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "74":
                        hexCommand = "02 06 21 03 00 4A F2 32";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "75":
                        hexCommand = "02 06 21 03 00 4B 33 F2";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "76":
                        hexCommand = "02 06 21 03 00 4C 72 30";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "77":
                        hexCommand = "02 06 21 03 00 4D B3 F0";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "78":
                        hexCommand = "02 06 21 03 00 4E F3 F1";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "79":
                        hexCommand = "02 06 21 03 00 4F 32 31";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "80":
                        hexCommand = "02 06 21 03 00 50 73 F9";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "81":
                        hexCommand = "02 06 21 03 00 51 B2 39";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "82":
                        hexCommand = "02 06 21 03 00 52 F2 38";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "83":
                        hexCommand = "02 06 21 03 00 53 33 F8";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "84":
                        hexCommand = "02 06 21 03 00 54 72 3A";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                    case "85":
                        hexCommand = "02 06 21 03 00 55 B3 FA";
                        hexBytes = hexCommand.Split(' ');
                        binaryData = new byte[hexBytes.Length];
                        for (int i = 0; i < hexBytes.Length; i++)
                        {
                            binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                        }
                        serialPort1.Write(binaryData, 0, binaryData.Length);
                        break;
                }
            }
           
        }

        private void txtPutSetpoint1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed to be entered", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; 
            }
        }

        private void txtPutSetpoint2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed to be entered", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; 
            }
        }

        private void btnUpSet2_Click(object sender, EventArgs e)
        {
            string input = txtPutSetpoint2.Text;
            if (int.TryParse(input, out int number))
            { 
                    number++;
                    txtPutSetpoint2.Text = number.ToString();
            }
        }

        private void btnDownSet2_Click(object sender, EventArgs e)
        {
            string input = txtPutSetpoint2.Text;
            if (int.TryParse(input, out int number))
            {
                number--;
                txtPutSetpoint2.Text = number.ToString();
            }
        }

        private void btnUpSet1_Click(object sender, EventArgs e)
        {
            string input = txtPutSetpoint1.Text;
            if (int.TryParse(input, out int number))
            {
                number++;
                txtPutSetpoint1.Text = number.ToString();
            }
        }

        private void btnDownSet1_Click(object sender, EventArgs e)
        {
            string input = txtPutSetpoint1.Text;
            if (int.TryParse(input, out int number))
            {
                number--;
                txtPutSetpoint1.Text = number.ToString();
            }
        }

        private void OffOmron(int which)
        {
            if (which == 1)
            {
                try
                {
                    string hexCommand;
                    string[] hexBytes;
                    byte[] binaryData;
                    SetConfigSerialPortForHeater();
                    hexCommand = "01 06 21 03 00 00 73 F6";
                    hexBytes = hexCommand.Split(' ');
                    binaryData = new byte[hexBytes.Length];
                    for (int i = 0; i < hexBytes.Length; i++)
                    {
                        binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                    }
                    serialPort1.Write(binaryData, 0, binaryData.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (which == 2)
            {
                try
                {
                    string hexCommand;
                    string[] hexBytes;
                    byte[] binaryData;
                    SetConfigSerialPortForHeater();
                    hexCommand = "02 06 21 03 00 00 73 C5";
                    hexBytes = hexCommand.Split(' ');
                    binaryData = new byte[hexBytes.Length];
                    for (int i = 0; i < hexBytes.Length; i++)
                    {
                        binaryData[i] = Convert.ToByte(hexBytes[i], 16);
                    }
                    serialPort1.Write(binaryData, 0, binaryData.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
        private void btnStop2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to stop operation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    OffOmron(2);

                    Thread.Sleep(50);

                    picUpDown2.Image.Dispose();
                    picUpDown2.Image = Resources.neutroWhite;
                    picProcess2.Image.Dispose();
                    picProcess2.Image = Resources.LedWhite1;

                    FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();
                    if (customForm.ShowDialog() == DialogResult.OK)
                    {
                        ApagarChillerZone(2);

                        txtPutSetpoint2.Text = "--";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Aquí puedes poner alguna acción si el usuario selecciona "No"
                MessageBox.Show("Operation cancelled by the user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to stop operation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    OffOmron(1);

                    Thread.Sleep(50);

                    picUpDown1.Image.Dispose();
                    picUpDown1.Image = Resources.neutroWhite;
                    picProcess1.Image.Dispose();
                    picProcess1.Image = Resources.LedWhite1;

                    FrmMessageAlertChiller customForm = new FrmMessageAlertChiller();
                    if (customForm.ShowDialog() == DialogResult.OK)
                    {
                        ApagarChillerZone(1);

                        txtPutSetpoint1.Text = "--";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Aquí puedes poner alguna acción si el usuario selecciona "No"
                MessageBox.Show("Operation cancelled by the user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void EncenderChillerZone(int whichzone)
        {
            try
            {
                SetConfigSerialPortForChiller();

                string commandOnChiller = "";

                // string commandOnChiller = "CC 00 01 81 08 01 02 02 02 02 02 02 02 66";

                if (whichzone == 1)
                {
                    commandOnChiller = "CC 00 08 81 08 01 02 02 02 02 02 02 02 5F";
                }
                else if (whichzone == 2)
                {
                    commandOnChiller = "CC 00 09 81 08 01 02 02 02 02 02 02 02 5E";
                }

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
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApagarChillerZone(int whichzone)
        {
            try
            {
                SetConfigSerialPortForChiller();

                string commandOffChiller = "";

                //string commandOffChiller = "CC 00 01 81 08 00 02 02 02 02 02 02 02 67";

                if (whichzone == 1)
                {
                    commandOffChiller = "CC 00 08 81 08 00 02 02 02 02 02 02 02 60";
                }
                else if (whichzone == 2)
                {
                    commandOffChiller = "CC 00 09 81 08 00 02 02 02 02 02 02 02 5F";
                }

                string[] hexBytesOn = commandOffChiller.Split(' ');

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
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Banderas

        bool sendAgainRequest = true;
        int whichRequestToSend = 1;

        private void timerRequestTemps_Tick(object sender, EventArgs e)
        {
            try
            {
                if (sendAgainRequest)
                {
                    serialPort2.BaudRate = 9600;
                    serialPort2.DataBits = 8;
                    serialPort2.StopBits = StopBits.One;
                    serialPort2.Parity = Parity.None;
                    serialPort2.ReceivedBytesThreshold = 44;
                    serialPort2.Encoding = Encoding.UTF8;

                    switch (whichRequestToSend)
                    {
                        case 1:
                            serialPort2.Write("#03" + "\r");
                            sendAgainRequest = false;
                            break;
                        case 2:
                            serialPort2.Write("#04" + "\r");
                            sendAgainRequest = false;
                            break;
                        case 3:
                            serialPort2.Write("#05" + "\r");
                            sendAgainRequest = false;
                            break;
                        case 4:
                            serialPort2.Write("#06" + "\r");
                            sendAgainRequest = false;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // WRITELINE X
            // WRITE \R •
            // WRITE \N X
            // WRITE ENVIO.NEWLINE X

            /* Medio funciono! pero sin respuesta!!!*/
            try
            {
                serialPort2.BaudRate = 9600;
                serialPort2.DataBits = 8;
                serialPort2.StopBits = StopBits.One;
                serialPort2.Parity = Parity.None;
                serialPort2.ReceivedBytesThreshold = 44;

                // ASCII Igual, Default Igual, UFT8 Igual

                serialPort2.Encoding = Encoding.UTF8;

                serialPort2.Write("#03" + "\r");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void serialPort2_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = serialPort2.BytesToRead;
            byte[] buffer = new byte[bytesToRead];
            serialPort2.Read(buffer, 0, bytesToRead);
            // Verifica si los datos recibidos no están vacíos
            if (bytesToRead > 0)
            {
                // Convierte los datos a una cadena hexadecimal
                string hexData = BitConverter.ToString(buffer).Replace("-", "");
                // Guarda la cadena hexadecimal en la variable "temp"
                responseModule03Address = hexData;
                ProcesarCadena(responseModule03Address);
            }
        }
        // Variable que toma la respuesta sin procesar al comando que solicita la cadena de las 6 temps segun a que modulo pregunta
        string responseModule03Address;
        // Variables cambiantes según la recepcion de los RTD's T1 Funciona como T1, T7, T13, T18 segun el ciclo por el que vaya
        private string T1, T2, T3, T4, T5, T6;

        // Variables de cada temperatura ya en formato string sin signo °C
        private string TF1, TF2, TF3, TF4, TF5, TF6, TF7, TF8, TF9, TF10, TF11, TF12, TF13, TF14, TF15, TF16, TF17, TF18, TF19, TF20, TF21, TF22, TF23, TF24;

        bool toggleScaleZoneSingle = true;
        private void btnScaleToggleZoneViewSingle_Click(object sender, EventArgs e)
        {
            if (toggleScaleZoneSingle)
            {
                chartView.ChartAreas[0].AxisY.Maximum = double.NaN;
                chartView.ChartAreas[0].AxisY.Minimum = 0;
                toggleScaleZoneSingle = false;
            }
            else
            {
                chartView.ChartAreas[0].AxisY.Maximum = 100;
                chartView.ChartAreas[0].AxisY.Minimum = 0;
                toggleScaleZoneSingle = true;
            }
        }

        private void btnScaleToggleZoneViewSingle_MouseEnter(object sender, EventArgs e)
        {
            btnScaleToggleZone1.BackColor = Color.SteelBlue;
        }

        private void btnScaleToggleZoneViewSingle_MouseLeave(object sender, EventArgs e)
        {
            btnScaleToggleZone1.BackColor = Color.DarkGray;
        }

        private void btnRefreshCOM1_Click(object sender, EventArgs e)
        {
            if (btnConnectCOM1.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                btnConnectCOM1.Enabled = false;

                cbCOMSelect1.Enabled = true;
                string[] ports = SerialPort.GetPortNames();
                cbCOMSelect1.Items.Clear();
                cbCOMSelect1.Items.AddRange(ports);
            }
        }

        private void btnRefreshCOM2_Click(object sender, EventArgs e)
        {
            if (btnConnectCOM2.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                btnConnectCOM2.Enabled = false;

                cbCOMSelect2.Enabled = true;
                string[] ports = SerialPort.GetPortNames();
                cbCOMSelect2.Items.Clear();
                cbCOMSelect2.Items.AddRange(ports);
            }
        }

       

        private void btnRecordZone1_Click(object sender, EventArgs e)
        {
            if (btnRecordZone1.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                btnRecordZone1.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                RecordZone1 = true;
                btnRecordZone1.Text = "Recording...";btnRecordZone1.ForeColor = Color.Red;
                btnRecordZone1.Size = new Size(145, 33); btnRecordZone1.Location = new Point(373, 234);
            }
            else
            {
                btnRecordZone1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                RecordZone1 = false;
                btnRecordZone1.Text = "Record"; btnRecordZone1.ForeColor = Color.Black; 
                btnRecordZone1.Size = new Size(109, 33); btnRecordZone1.Location = new Point(409, 234);
               
                streamWriterZone1.Close();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de texto|*.txt";
                    saveFileDialog.FileName = "ELEN II SOFTWARE RECORD ZONE 1 STARTED " + inicioRecordZone1 + " ENDED " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");

                    // Establece la ruta por defecto en la carpeta "ELEN II SOFTWARE" dentro de "Documentos"
                    string defaultSavePath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        "ELEN II SOFTWARE");

                    Directory.CreateDirectory(defaultSavePath); // Crea la carpeta si no existe

                    saveFileDialog.InitialDirectory = defaultSavePath;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Elimina el archivo existente si hay uno con el mismo nombre
                        if (File.Exists(saveFileDialog.FileName))
                        {
                            File.Delete(saveFileDialog.FileName);
                        }

                        // Mueve el archivo temporal a la ubicación seleccionada
                        File.Move(tempFileName1, saveFileDialog.FileName);
                        MessageBox.Show("File saved successfully.", "Successful Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si se cancela, elimina el archivo temporal
                        File.Delete(tempFileName1);
                    }
                }
                firstEntranceZone1 = true;
            }
        }

        private void btnRecordZone2_Click(object sender, EventArgs e)
        {
            if (btnRecordZone2.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                btnRecordZone2.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                RecordZone2 = true;
                btnRecordZone2.Text = "Recording..."; btnRecordZone2.ForeColor = Color.Red;
                btnRecordZone2.Size = new Size(145, 33); btnRecordZone2.Location = new Point(373, 234);
            }
            else
            {
                btnRecordZone2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                RecordZone2 = false;
                btnRecordZone2.Text = "Record"; btnRecordZone2.ForeColor = Color.Black;
                btnRecordZone2.Size = new Size(109, 33); btnRecordZone2.Location = new Point(409, 234);

                streamWriterZone2.Close();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de texto|*.txt";
                    saveFileDialog.FileName = "ELEN II SOFTWARE RECORD ZONE 2 STARTED " + inicioRecordZone2 + " ENDED " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");

                    // Establece la ruta por defecto en la carpeta "ELEN II SOFTWARE" dentro de "Documentos"
                    string defaultSavePath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        "ELEN II SOFTWARE");

                    Directory.CreateDirectory(defaultSavePath); // Crea la carpeta si no existe

                    saveFileDialog.InitialDirectory = defaultSavePath;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Elimina el archivo existente si hay uno con el mismo nombre
                        if (File.Exists(saveFileDialog.FileName))
                        {
                            File.Delete(saveFileDialog.FileName);
                        }

                        // Mueve el archivo temporal a la ubicación seleccionada
                        File.Move(tempFileName2, saveFileDialog.FileName);
                        MessageBox.Show("File saved successfully.", "Successful Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si se cancela, elimina el archivo temporal
                        File.Delete(tempFileName2);
                    }
                }
                firstEntranceZone2 = true;
            }
        }

        private bool ChartSeriesExists(Chart chart, string seriesName)
        {
            foreach (Series series in chart.Series)
            {
                if (series.Name == seriesName)
                {
                    return true;
                }
            }
            return false;
        }

        private void checkView1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView1.Checked)
            {
                if (ChartSeriesExists(chartView, "T-1"))
                {
                    chartView.Series["T-1"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-13"))
                {
                    chartView.Series["T-13"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-1"))
                {
                    chartView.Series["T-1"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-13"))
                {
                    chartView.Series["T-13"].Enabled = false;
                }
            }
           
        }

        private void checkView2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView2.Checked)
            {
                if (ChartSeriesExists(chartView, "T-2"))
                {
                    chartView.Series["T-2"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-14"))
                {
                    chartView.Series["T-14"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-2"))
                {
                    chartView.Series["T-2"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-14"))
                {
                    chartView.Series["T-14"].Enabled = false;
                }
            }
        }

        private void checkView3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView3.Checked)
            {
                if (ChartSeriesExists(chartView, "T-3"))
                {
                    chartView.Series["T-3"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-15"))
                {
                    chartView.Series["T-15"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-3"))
                {
                    chartView.Series["T-3"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-15"))
                {
                    chartView.Series["T-15"].Enabled = false;
                }
            }
        }

        private void checkView4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView4.Checked)
            {
                if (ChartSeriesExists(chartView, "T-4"))
                {
                    chartView.Series["T-4"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-16"))
                {
                    chartView.Series["T-16"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-4"))
                {
                    chartView.Series["T-4"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-16"))
                {
                    chartView.Series["T-16"].Enabled = false;
                }
            }
        }

        private void checkView5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView5.Checked)
            {
                if (ChartSeriesExists(chartView, "T-5"))
                {
                    chartView.Series["T-5"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-17"))
                {
                    chartView.Series["T-17"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-5"))
                {
                    chartView.Series["T-5"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-17"))
                {
                    chartView.Series["T-17"].Enabled = false;
                }
            }
        }

        private void checkView6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView6.Checked)
            {
                if (ChartSeriesExists(chartView, "T-6"))
                {
                    chartView.Series["T-6"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-18"))
                {
                    chartView.Series["T-18"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-6"))
                {
                    chartView.Series["T-6"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-18"))
                {
                    chartView.Series["T-18"].Enabled = false;
                }
            }
        }

        private void checkView7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView7.Checked)
            {
                if (ChartSeriesExists(chartView, "T-7"))
                {
                    chartView.Series["T-7"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-19"))
                {
                    chartView.Series["T-19"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-7"))
                {
                    chartView.Series["T-7"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-19"))
                {
                    chartView.Series["T-19"].Enabled = false;
                }
            }
        }

        private void checkView8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView8.Checked)
            {
                if (ChartSeriesExists(chartView, "T-8"))
                {
                    chartView.Series["T-8"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-20"))
                {
                    chartView.Series["T-20"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-8"))
                {
                    chartView.Series["T-8"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-20"))
                {
                    chartView.Series["T-20"].Enabled = false;
                }
            }
        }

        private void checkView9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView9.Checked)
            {
                if (ChartSeriesExists(chartView, "T-9"))
                {
                    chartView.Series["T-9"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-21"))
                {
                    chartView.Series["T-21"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-9"))
                {
                    chartView.Series["T-9"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-21"))
                {
                    chartView.Series["T-21"].Enabled = false;
                }
            }
        }

        private void checkView10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView10.Checked)
            {
                if (ChartSeriesExists(chartView, "T-10"))
                {
                    chartView.Series["T-10"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-22"))
                {
                    chartView.Series["T-22"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-10"))
                {
                    chartView.Series["T-10"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-22"))
                {
                    chartView.Series["T-22"].Enabled = false;
                }
            }
        }

        private void checkView11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView11.Checked)
            {
                if (ChartSeriesExists(chartView, "T-11"))
                {
                    chartView.Series["T-11"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-23"))
                {
                    chartView.Series["T-23"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-11"))
                {
                    chartView.Series["T-11"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-23"))
                {
                    chartView.Series["T-23"].Enabled = false;
                }
            }
        }

        private void checkView12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView12.Checked)
            {
                if (ChartSeriesExists(chartView, "T-12"))
                {
                    chartView.Series["T-12"].Enabled = true;
                }
                else if (ChartSeriesExists(chartView, "T-24"))
                {
                    chartView.Series["T-24"].Enabled = true;
                }
            }
            else
            {
                if (ChartSeriesExists(chartView, "T-12"))
                {
                    chartView.Series["T-12"].Enabled = false;
                }
                else if (ChartSeriesExists(chartView, "T-24"))
                {
                    chartView.Series["T-24"].Enabled = false;
                }
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            EncenderVerde();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            EncenderAmarillo();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            EncenderRojo();
        }

        private void timerGraficarCharts_Tick(object sender, EventArgs e)
        {
            //Si todas las TF con formula ya se encuentran con su respectivo valor 4 segundos despues de conectar!
            if (TF1 != null && TF7 != null && TF13 != null && TF19 != null && TF24 != null)
            {
                if (viewChart == "Both")
                {
                    // ZONA 1 
                    rt1 = rt1 + 100;
                    temp1 = rt1 / 1000;

                    chartZone1.Series["T-1"].Points.AddXY(temp1.ToString(), TF1.ToString());
                    txtTC1.Text = TF1;
                    chartZone1.Series["T-2"].Points.AddXY(temp1.ToString(), TF2.ToString());
                    txtTC2.Text = TF2;
                    chartZone1.Series["T-3"].Points.AddXY(temp1.ToString(), TF3.ToString());
                    txtTC3.Text = TF3;
                    chartZone1.Series["T-4"].Points.AddXY(temp1.ToString(), TF4.ToString());
                    txtTC4.Text = TF4;
                    chartZone1.Series["T-5"].Points.AddXY(temp1.ToString(), TF5.ToString());
                    txtTC5.Text = TF5;
                    chartZone1.Series["T-6"].Points.AddXY(temp1.ToString(), TF6.ToString());
                    txtTC6.Text = TF6;
                    chartZone1.Series["T-7"].Points.AddXY(temp1.ToString(), TF7.ToString());
                    txtTC7.Text = TF7;
                    chartZone1.Series["T-8"].Points.AddXY(temp1.ToString(), TF8.ToString());
                    txtTC8.Text = TF8;
                    chartZone1.Series["T-9"].Points.AddXY(temp1.ToString(), TF9.ToString());
                    txtTC9.Text = TF9;
                    chartZone1.Series["T-10"].Points.AddXY(temp1.ToString(), TF10.ToString());
                    txtTC10.Text = TF10;
                    chartZone1.Series["T-11"].Points.AddXY(temp1.ToString(), TF11.ToString());
                    txtTC11.Text = TF11;
                    chartZone1.Series["T-12"].Points.AddXY(temp1.ToString(), TF12.ToString());
                    txtTC12.Text = TF12;

                    List<double> temperaturas1 = new List<double>
                    {
                        Convert.ToDouble(TF1),
                        Convert.ToDouble(TF2),
                        Convert.ToDouble(TF3),
                        Convert.ToDouble(TF4),
                        Convert.ToDouble(TF5),
                        Convert.ToDouble(TF6),
                        Convert.ToDouble(TF7),
                        Convert.ToDouble(TF8),
                        Convert.ToDouble(TF9),
                        Convert.ToDouble(TF10),
                        Convert.ToDouble(TF11),
                        Convert.ToDouble(TF12)
                    };

                    AVGZona1 = temperaturas1.Average();
                    lbAVGTemp1.Text = AVGZona1.ToString("00.00") + " °C";

                    chartZone1.ChartAreas[0].RecalculateAxesScale();

                    if (chartZone1.Series["T-1"].Points.Count == 101)
                    {
                        chartZone1.Series["T-1"].Points.RemoveAt(0);chartZone1.Series["T-2"].Points.RemoveAt(0);
                        chartZone1.Series["T-3"].Points.RemoveAt(0);chartZone1.Series["T-4"].Points.RemoveAt(0);
                        chartZone1.Series["T-5"].Points.RemoveAt(0);chartZone1.Series["T-6"].Points.RemoveAt(0);
                        chartZone1.Series["T-7"].Points.RemoveAt(0);chartZone1.Series["T-8"].Points.RemoveAt(0);
                        chartZone1.Series["T-9"].Points.RemoveAt(0);chartZone1.Series["T-10"].Points.RemoveAt(0);
                        chartZone1.Series["T-11"].Points.RemoveAt(0);chartZone1.Series["T-12"].Points.RemoveAt(0);
                    }

                    //ZONA 2
                    rt2 = rt2 + 100;
                    temp2 = rt2 / 1000;

                    chartZone2.Series["T-13"].Points.AddXY(temp2.ToString(), TF13.ToString());
                    txtTC13.Text = TF13;
                    chartZone2.Series["T-14"].Points.AddXY(temp2.ToString(), TF14.ToString());
                    txtTC14.Text = TF14;
                    chartZone2.Series["T-15"].Points.AddXY(temp2.ToString(), TF15.ToString());
                    txtTC15.Text = TF15;
                    chartZone2.Series["T-16"].Points.AddXY(temp2.ToString(), TF16.ToString());
                    txtTC16.Text = TF16;
                    chartZone2.Series["T-17"].Points.AddXY(temp2.ToString(), TF17.ToString());
                    txtTC17.Text = TF17;
                    chartZone2.Series["T-18"].Points.AddXY(temp2.ToString(), TF18.ToString());
                    txtTC18.Text = TF18;
                    chartZone2.Series["T-19"].Points.AddXY(temp2.ToString(), TF19.ToString());
                    txtTC19.Text = TF19;
                    chartZone2.Series["T-20"].Points.AddXY(temp2.ToString(), TF20.ToString());
                    txtTC20.Text = TF20;
                    chartZone2.Series["T-21"].Points.AddXY(temp2.ToString(), TF21.ToString());
                    txtTC21.Text = TF21;
                    chartZone2.Series["T-22"].Points.AddXY(temp2.ToString(), TF22.ToString());
                    txtTC22.Text = TF22;
                    chartZone2.Series["T-23"].Points.AddXY(temp2.ToString(), TF23.ToString());
                    txtTC23.Text = TF23;
                    chartZone2.Series["T-24"].Points.AddXY(temp2.ToString(), TF24.ToString());
                    txtTC24.Text = TF24;

                    List<double> temperaturas2 = new List<double>
                    {
                        Convert.ToDouble(TF13),
                        Convert.ToDouble(TF14),
                        Convert.ToDouble(TF15),
                        Convert.ToDouble(TF16),
                        Convert.ToDouble(TF17),
                        Convert.ToDouble(TF18),
                        Convert.ToDouble(TF19),
                        Convert.ToDouble(TF20),
                        Convert.ToDouble(TF21),
                        Convert.ToDouble(TF22),
                        Convert.ToDouble(TF23),
                        Convert.ToDouble(TF24)
                    };

                    AVGZona2 = temperaturas2.Average();
                    lbAVGTemp2.Text = AVGZona2.ToString("00.00") + " °C";

                    chartZone2.ChartAreas[0].RecalculateAxesScale();

                    if (chartZone2.Series["T-13"].Points.Count == 101)
                    {
                        chartZone2.Series["T-13"].Points.RemoveAt(0); chartZone2.Series["T-14"].Points.RemoveAt(0);
                        chartZone2.Series["T-15"].Points.RemoveAt(0); chartZone2.Series["T-16"].Points.RemoveAt(0);
                        chartZone2.Series["T-17"].Points.RemoveAt(0); chartZone2.Series["T-18"].Points.RemoveAt(0);
                        chartZone2.Series["T-19"].Points.RemoveAt(0); chartZone2.Series["T-20"].Points.RemoveAt(0);
                        chartZone2.Series["T-21"].Points.RemoveAt(0); chartZone2.Series["T-22"].Points.RemoveAt(0);
                        chartZone2.Series["T-23"].Points.RemoveAt(0); chartZone2.Series["T-24"].Points.RemoveAt(0);
                    }
                }
                else if (viewChart == "Zone1")
                {
                    rtView = rtView + 100;
                    tempView = rtView / 1000;

                    chartView.Series["T-1"].Points.AddXY(tempView.ToString(), TF1.ToString());
                    txtView1.Text = TF1;
                    chartView.Series["T-2"].Points.AddXY(tempView.ToString(), TF2.ToString());
                    txtView2.Text = TF2;
                    chartView.Series["T-3"].Points.AddXY(tempView.ToString(), TF3.ToString());
                    txtView3.Text = TF3;
                    chartView.Series["T-4"].Points.AddXY(tempView.ToString(), TF4.ToString());
                    txtView4.Text = TF4;
                    chartView.Series["T-5"].Points.AddXY(tempView.ToString(), TF5.ToString());
                    txtView5.Text = TF5;
                    chartView.Series["T-6"].Points.AddXY(tempView.ToString(), TF6.ToString());
                    txtView6.Text = TF6;
                    chartView.Series["T-7"].Points.AddXY(tempView.ToString(), TF7.ToString());
                    txtView7.Text = TF7;
                    chartView.Series["T-8"].Points.AddXY(tempView.ToString(), TF8.ToString());
                    txtView8.Text = TF8;
                    chartView.Series["T-9"].Points.AddXY(tempView.ToString(), TF9.ToString());
                    txtView9.Text = TF9;
                    chartView.Series["T-10"].Points.AddXY(tempView.ToString(), TF10.ToString());
                    txtView10.Text = TF10;
                    chartView.Series["T-11"].Points.AddXY(tempView.ToString(), TF11.ToString());
                    txtView11.Text = TF11;
                    chartView.Series["T-12"].Points.AddXY(tempView.ToString(), TF12.ToString());
                    txtView12.Text = TF12;

                    List<double> temperaturas1 = new List<double>
                    {
                        Convert.ToDouble(TF1),
                        Convert.ToDouble(TF2),
                        Convert.ToDouble(TF3),
                        Convert.ToDouble(TF4),
                        Convert.ToDouble(TF5),
                        Convert.ToDouble(TF6),
                        Convert.ToDouble(TF7),
                        Convert.ToDouble(TF8),
                        Convert.ToDouble(TF9),
                        Convert.ToDouble(TF10),
                        Convert.ToDouble(TF11),
                        Convert.ToDouble(TF12)
                    };
                    List<double> temperaturas2 = new List<double>
                    {
                        Convert.ToDouble(TF13),
                        Convert.ToDouble(TF14),
                        Convert.ToDouble(TF15),
                        Convert.ToDouble(TF16),
                        Convert.ToDouble(TF17),
                        Convert.ToDouble(TF18),
                        Convert.ToDouble(TF19),
                        Convert.ToDouble(TF20),
                        Convert.ToDouble(TF21),
                        Convert.ToDouble(TF22),
                        Convert.ToDouble(TF23),
                        Convert.ToDouble(TF24)
                    };

                    AVGZona1 = temperaturas1.Average();
                    lbAVGTemp1.Text = AVGZona1.ToString("00.00") + " °C";
                    AVGZona2 = temperaturas2.Average();
                    lbAVGTemp2.Text = AVGZona2.ToString("00.00") + " °C";

                    chartView.ChartAreas[0].RecalculateAxesScale();

                    if (chartView.Series["T-1"].Points.Count == 101)
                    {
                        chartView.Series["T-1"].Points.RemoveAt(0); chartView.Series["T-2"].Points.RemoveAt(0);
                        chartView.Series["T-3"].Points.RemoveAt(0); chartView.Series["T-4"].Points.RemoveAt(0);
                        chartView.Series["T-5"].Points.RemoveAt(0); chartView.Series["T-6"].Points.RemoveAt(0);
                        chartView.Series["T-7"].Points.RemoveAt(0); chartView.Series["T-8"].Points.RemoveAt(0);
                        chartView.Series["T-9"].Points.RemoveAt(0); chartView.Series["T-10"].Points.RemoveAt(0);
                        chartView.Series["T-11"].Points.RemoveAt(0); chartView.Series["T-12"].Points.RemoveAt(0);
                    }

                }
                else if (viewChart == "Zone2")
                {
                    rtView = rtView + 100;
                    tempView = rtView / 1000;

                    chartView.Series["T-13"].Points.AddXY(tempView.ToString(), TF13.ToString());
                    txtView1.Text = TF13;
                    chartView.Series["T-14"].Points.AddXY(tempView.ToString(), TF14.ToString());
                    txtView2.Text = TF14;
                    chartView.Series["T-15"].Points.AddXY(tempView.ToString(), TF15.ToString());
                    txtView3.Text = TF15;
                    chartView.Series["T-16"].Points.AddXY(tempView.ToString(), TF16.ToString());
                    txtView4.Text = TF16;
                    chartView.Series["T-17"].Points.AddXY(tempView.ToString(), TF17.ToString());
                    txtView5.Text = TF17;
                    chartView.Series["T-18"].Points.AddXY(tempView.ToString(), TF18.ToString());
                    txtView6.Text = TF18;
                    chartView.Series["T-19"].Points.AddXY(tempView.ToString(), TF19.ToString());
                    txtView7.Text = TF19;
                    chartView.Series["T-20"].Points.AddXY(tempView.ToString(), TF20.ToString());
                    txtView8.Text = TF20;
                    chartView.Series["T-21"].Points.AddXY(tempView.ToString(), TF21.ToString());
                    txtView9.Text = TF21;
                    chartView.Series["T-22"].Points.AddXY(tempView.ToString(), TF22.ToString());
                    txtView10.Text = TF22;
                    chartView.Series["T-23"].Points.AddXY(tempView.ToString(), TF23.ToString());
                    txtView11.Text = TF23;
                    chartView.Series["T-24"].Points.AddXY(tempView.ToString(), TF24.ToString());
                    txtView12.Text = TF24;

                    List<double> temperaturas1 = new List<double>
                    {
                        Convert.ToDouble(TF1),
                        Convert.ToDouble(TF2),
                        Convert.ToDouble(TF3),
                        Convert.ToDouble(TF4),
                        Convert.ToDouble(TF5),
                        Convert.ToDouble(TF6),
                        Convert.ToDouble(TF7),
                        Convert.ToDouble(TF8),
                        Convert.ToDouble(TF9),
                        Convert.ToDouble(TF10),
                        Convert.ToDouble(TF11),
                        Convert.ToDouble(TF12)
                    };
                    List<double> temperaturas2 = new List<double>
                    {
                        Convert.ToDouble(TF13),
                        Convert.ToDouble(TF14),
                        Convert.ToDouble(TF15),
                        Convert.ToDouble(TF16),
                        Convert.ToDouble(TF17),
                        Convert.ToDouble(TF18),
                        Convert.ToDouble(TF19),
                        Convert.ToDouble(TF20),
                        Convert.ToDouble(TF21),
                        Convert.ToDouble(TF22),
                        Convert.ToDouble(TF23),
                        Convert.ToDouble(TF24)
                    };

                    AVGZona1 = temperaturas1.Average();
                    lbAVGTemp1.Text = AVGZona1.ToString("00.00") + " °C";
                    AVGZona2 = temperaturas2.Average();
                    lbAVGTemp2.Text = AVGZona2.ToString("00.00") + " °C";

                    chartView.ChartAreas[0].RecalculateAxesScale();

                    if (chartView.Series["T-13"].Points.Count == 101)
                    {
                        chartView.Series["T-13"].Points.RemoveAt(0); chartView.Series["T-14"].Points.RemoveAt(0);
                        chartView.Series["T-15"].Points.RemoveAt(0); chartView.Series["T-16"].Points.RemoveAt(0);
                        chartView.Series["T-17"].Points.RemoveAt(0); chartView.Series["T-18"].Points.RemoveAt(0);
                        chartView.Series["T-19"].Points.RemoveAt(0); chartView.Series["T-20"].Points.RemoveAt(0);
                        chartView.Series["T-21"].Points.RemoveAt(0); chartView.Series["T-22"].Points.RemoveAt(0);
                        chartView.Series["T-23"].Points.RemoveAt(0); chartView.Series["T-24"].Points.RemoveAt(0);
                    }
                }
            }
        }

        private void checkT24_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-24"].Enabled = checkT24.Checked ? true : false;
        }

        private void checkT23_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-23"].Enabled = checkT23.Checked ? true : false;
        }

        private void checkT22_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-22"].Enabled = checkT22.Checked ? true : false;
        }

        private void checkT21_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-21"].Enabled = checkT21.Checked ? true : false;
        }

        private void checkT20_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-20"].Enabled = checkT20.Checked ? true : false;
        }

        private void checkT19_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-19"].Enabled = checkT19.Checked ? true : false;
        }

        private void checkT18_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-18"].Enabled = checkT18.Checked ? true : false;
        }

        private void checkT17_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-17"].Enabled = checkT17.Checked ? true : false;
        }

        private void checkT16_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-16"].Enabled = checkT16.Checked ? true : false;
        }

        private void checkT15_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-15"].Enabled = checkT15.Checked ? true : false;
        }

        private void checkT14_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-14"].Enabled = checkT14.Checked ? true : false;
        }

        private void checkT13_CheckedChanged(object sender, EventArgs e)
        {
            chartZone2.Series["T-13"].Enabled = checkT13.Checked ? true : false;
        }

        bool toggleScaleZone2 = true;
        private void btnScaleToggleZone2_Click(object sender, EventArgs e)
        {
            if (toggleScaleZone2)
            {
                chartZone2.ChartAreas[0].AxisY.Maximum = double.NaN;
                chartZone2.ChartAreas[0].AxisY.Minimum = 0;
                toggleScaleZone2 = false;
            }
            else
            {
                chartZone2.ChartAreas[0].AxisY.Maximum = 100;
                chartZone2.ChartAreas[0].AxisY.Minimum = 0;
                toggleScaleZone2 = true;
            }
        }

        private void btnScaleToggleZone1_MouseEnter(object sender, EventArgs e)
        {
            btnScaleToggleZone1.BackColor = Color.SteelBlue;
        }

        private void btnScaleToggleZone1_MouseLeave(object sender, EventArgs e)
        {
            btnScaleToggleZone1.BackColor = Color.DarkGray;
        }

      

        bool toggleScaleZone1 = true;
        private void btnScaleToggleZone1_Click(object sender, EventArgs e)
        {
            if (toggleScaleZone1)
            {
                chartZone1.ChartAreas[0].AxisY.Maximum = double.NaN;
                chartZone1.ChartAreas[0].AxisY.Minimum = 0;
                toggleScaleZone1 = false;           
            }
            else
            {
                chartZone1.ChartAreas[0].AxisY.Maximum = 100;
                chartZone1.ChartAreas[0].AxisY.Minimum = 0;
                toggleScaleZone1 = true;
            }
        }

        private void panelControlZone1_MouseLeave(object sender, EventArgs e)
        {
            picDrawMachine.Image.Dispose();
            picDrawMachine.Image = Resources.drawOff1;
            lbTitleZone1.BackColor = Color.White;
            panelTitleZone1.BackColor = Color.White;
        }

        private void panelControlZone1_MouseEnter(object sender, EventArgs e)
        {
            picDrawMachine.Image.Dispose();
            picDrawMachine.Image = Resources.draw11;
            lbTitleZone1.BackColor = Color.Yellow;
            panelTitleZone1.BackColor = Color.Yellow;
        }

        private void panelControlZone2_MouseEnter(object sender, EventArgs e)
        {
            picDrawMachine.Image.Dispose();
            picDrawMachine.Image = Resources.draw21;
            lbTitleZone2.BackColor = Color.Yellow;
            panelTitleZone2.BackColor = Color.Yellow;
        }

        private void panelControlZone2_MouseLeave(object sender, EventArgs e)
        {
            picDrawMachine.Image.Dispose();
            picDrawMachine.Image = Resources.drawOff1;
            lbTitleZone2.BackColor = Color.White;
            panelTitleZone2.BackColor = Color.White;
        }

    

        string cosaADescifrar = "3E2B3032352E31382B393939392E392B393939392E392B393939392E392B393939392E392B393939392E390D";

        public void ProcesarCadena(string cadena)
        {
            // Bucle para buscar y procesar cada ocurrencia de "2B" y dar separacion al valor correspondiente de cada temperatura
            int currentIndex = 0;
            int tCounter = 1;

            while ((currentIndex = cadena.IndexOf("2B", currentIndex)) != -1)
            {
                // Asegúrate de que hay al menos 12 caracteres después de "2B"
                if (currentIndex + 2 + 12 <= cadena.Length)
                {
                    // Extrae los 12 caracteres siguientes a "2B"
                    string siguiente12Caracteres = cadena.Substring(currentIndex + 2, 12);
                    // Asigna los caracteres a la variable correspondiente (T1, T2, ...)
                    switch (tCounter)
                    {
                        case 1:
                            T1 = siguiente12Caracteres;
                            break;
                        case 2:
                            T2 = siguiente12Caracteres;
                            break;
                        case 3:
                            T3 = siguiente12Caracteres;
                            break;
                        case 4:
                            T4 = siguiente12Caracteres;
                            break;
                        case 5:
                            T5 = siguiente12Caracteres;
                            break;
                        case 6:
                            T6 = siguiente12Caracteres;
                            break;
                        default:
                            break;
                    }
                    // Mueve el índice para buscar la siguiente ocurrencia de "2B"
                    currentIndex += 14; // 2B + 12 caracteres
                    tCounter++;
                    // Si ya hemos almacenado en todas las variables, salimos del bucle
                    if (tCounter > 6)
                        break;
                }
                else
                {
                    // No hay suficientes caracteres después de "2B", salimos del bucle
                    break;
                }
            }

            switch (whichRequestToSend)
            {
                case 1:
                    TF1 = HexStringToAscii(T1);
                    TF2 = HexStringToAscii(T2);
                    TF3 = HexStringToAscii(T3);   
                    TF4 = HexStringToAscii(T4);
                    TF5 = HexStringToAscii(T5);
                    TF6 = HexStringToAscii(T6);
                    whichRequestToSend = 2;
                    sendAgainRequest = true;
                    break;
                    case 2:
                    TF7 = HexStringToAscii(T6);
                    TF8 = HexStringToAscii(T5);
                    TF9 = HexStringToAscii(T4);
                    TF10 = HexStringToAscii(T3);
                    TF11 = HexStringToAscii(T2);
                    TF12 = HexStringToAscii(T1);
                    whichRequestToSend = 3;
                    sendAgainRequest = true;
                    break;
                    case 3:
                    TF13 = HexStringToAscii(T1);
                    TF14 = HexStringToAscii(T2);
                    TF15 = HexStringToAscii(T3);
                    TF16 = HexStringToAscii(T4);
                    TF17 = HexStringToAscii(T5);
                    TF18 = HexStringToAscii(T6);
                    whichRequestToSend = 4;
                    sendAgainRequest = true;
                    break;
                    case 4:
                    TF19 = HexStringToAscii(T6);
                    TF20 = HexStringToAscii(T5);
                    TF21 = HexStringToAscii(T4);
                    TF22 = HexStringToAscii(T3);
                    TF23 = HexStringToAscii(T2);
                    TF24 = HexStringToAscii(T1);
                    whichRequestToSend = 1;
                    sendAgainRequest = true;
                    break;
            }
        }

        public string HexStringToAscii(string hexString)
        {
            // Asegúrate de que la longitud de la cadena sea par
            if (hexString.Length % 2 != 0)
                throw new ArgumentException("La cadena hexadecimal debe tener una longitud par.");

            // Convierte cada par de caracteres hexadecimales a un byte
            byte[] bytes = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            // Convierte los bytes a una cadena ASCII
            string asciiString = Encoding.ASCII.GetString(bytes);


            int index = 0;

            // Find the first non-zero digit
            while (index < asciiString.Length && asciiString[index] == '0')
            {
                index++;
            }

            // Return the modified string
            return index < asciiString.Length ? asciiString.Substring(index) : asciiString;

            //return asciiString;
        }


        private void CountChillerUse(int whichChiller)
        {
            if (whichChiller == 1) 
            {
                Settings.Default.CountCool1++;
                Settings.Default.Save();
            }
            else if (whichChiller == 2)
            {
                Settings.Default.CountCool2++;
                Settings.Default.Save();
            }
        }

        private void CountOmronUse(int whichOmron)
        {
            if (whichOmron == 1)
            {
                Settings.Default.CountHeat1++;
                Settings.Default.Save();
            }
            else if (whichOmron == 2)
            {
                Settings.Default.CountHeat2++;
                Settings.Default.Save();
            }
        }



    }
}