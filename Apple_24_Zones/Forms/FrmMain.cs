using AppleSoftware.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Media3D;
using ContentAlignment = System.Drawing.ContentAlignment;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Apple_24_Zones.Forms
{
    public partial class FrmMain : Form

         
    {
        
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private double runningCount = 0;
        private double timeCs = 0;
        private Stopwatch stopwatch = new Stopwatch();
        private Boolean freeze = false;
        private Boolean running = true;
        private List<Point> points = new List<Point>();

        //
        //Panel swap status
        //
        List<Panel> listPanel = new List<Panel>();

        //LED on and off
        List<PictureBox> leds = new List<PictureBox>();

        public FrmMain()
        {
            
            InitializeComponent();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //TODO
            //if (serialPort1.IsOpen)
            //{
            //    serialPort1.DiscardInBuffer();
            //    serialPort1.DiscardOutBuffer();
            //    serialPort1.Write("#020000" + "\r");
            //    BanderaRespuestaParaTCS = false;
            //    serialPort1.Close();
            //}
           // Application.Exit();
        }


        /*
        private void MenuItemExport_Click(object sender, EventArgs e)
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
        */
            
        private void MenuItemConnect_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmConnect);

            if(frm==null)
            {
                FrmConnect nt = new FrmConnect();
                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }


        }
        

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        



        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
               // btnDownUpMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubMenu()
        {
           // if (panelSubMenuGestion.Visible == true)
           // {
           //     panelSubMenuGestion.Visible = false;
           // }
           /*
            if (panelSubMenu2.Visible == true)
            {
                panelSubMenu2.Visible = false;
            }
            if (panelSubMenu3.Visible == true)
            {
                panelSubMenu3.Visible = false;
            }
            if (panelSubMenu4.Visible == true)
            {
                panelSubMenu4.Visible = false;
            }
            if (panelSubMenu5.Visible == true)
            {
                panelSubMenu5.Visible = false;
            }
            if (panelSubMenu6.Visible == true)
            {
                panelSubMenu6.Visible = false;
            }
           */
        }

        private void ResetAllDefault()
        {
            // Reset Seccion Conection
           // cbSelect.SelectedIndex = -1;
            //btnRefreshCOM1.Enabled = true;
            //btnConnectCOM1.Enabled = false;
           // cbCOMSelect1.Enabled = true;
            string[] ports = SerialPort.GetPortNames();
            //cbCOMSelect1.Items.Clear();
            //cbCOMSelect1.Items.AddRange(ports);
            //btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            // Comunicacion
            //SetConfigSerialPortForTCS();
            //BanderaRespuestaParaTCS = false;

            //Reset View Options
           // panelGhost.Visible = false;
           // cbSelectViewZone.SelectedIndex = -1;
           // cbSelectViewChartZone.SelectedIndex = -1;
            //cbZonesMode.SelectedIndex = -1;

            //ledZ1.Image.Dispose();
            //ledZ2.Image.Dispose();

            //ledZ1.Image = Properties.Resources.led_off;
            //ledZ2.Image = Properties.Resources.led_off;

            // Disable All buttoms
            /*
            cbZonesMode.Enabled = false;
            cbSelect.Enabled = false;
            txtSetTemp.Enabled = false;
            btnSetTemperature.Enabled = false;
            btnOnOff.Enabled = false;
            btnStartStopChart.Enabled = false;
            btnChartMode.Enabled = false;
            btnRecordDataChart.Enabled = false;
            btnClearChart.Enabled = false;
            btnTypeTime.Enabled = false;
            

            btnReportes.Text = "Status: OFF";
            btnOnOff.Text = "         Turn On";
            */

            //Chart things

            ChartArea CA = chartZone2.ChartAreas[0];
            CA.CursorX.AutoScroll = true;

            chartZone2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartZone2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartZone2.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;

            CA.AxisY.MinorTickMark.Enabled = true;
            CA.AxisY.MinorGrid.Enabled = true;



            //Record things
            DATETIMES.Clear();
            TIMES.Clear();
            TC1A.Clear(); TC2A.Clear(); TC3A.Clear(); TC4A.Clear(); TC5A.Clear(); TC6A.Clear(); TC7A.Clear(); TC8A.Clear(); TC9A.Clear(); TC10A.Clear(); TC11A.Clear(); TC12A.Clear(); TC13A.Clear(); TC14A.Clear(); TC15A.Clear(); TC16A.Clear(); TC17A.Clear(); TC18A.Clear(); TC19A.Clear(); TC20A.Clear(); TC21A.Clear(); TC22A.Clear(); TC23A.Clear(); TC24A.Clear();

            btnRecordDataChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            Record = false;
            end_record = DateTime.Now;
            lbRecord.Text = "Record Data";
            lbRecord.ForeColor = Color.Black;

            chartZone2.Series.Clear();
            chartZone1.Series.Clear();
            GenerarChart12();
            GenerarChart24();


            chartZone2.Series["T-13"].Points.Clear(); chartZone2.Series["T-14"].Points.Clear(); chartZone2.Series["T-15"].Points.Clear(); chartZone2.Series["T-16"].Points.Clear(); chartZone2.Series["T-17"].Points.Clear(); chartZone2.Series["T-18"].Points.Clear(); chartZone2.Series["T-19"].Points.Clear(); chartZone2.Series["T-20"].Points.Clear(); chartZone2.Series["T-21"].Points.Clear(); chartZone2.Series["T-22"].Points.Clear(); chartZone2.Series["T-23"].Points.Clear(); chartZone2.Series["T-24"].Points.Clear();
            chartZone1.Series["T-1"].Points.Clear(); chartZone1.Series["T-2"].Points.Clear(); chartZone1.Series["T-3"].Points.Clear(); chartZone1.Series["T-4"].Points.Clear(); chartZone1.Series["T-5"].Points.Clear(); chartZone1.Series["T-6"].Points.Clear(); chartZone1.Series["T-7"].Points.Clear(); chartZone1.Series["T-8"].Points.Clear(); chartZone1.Series["T-9"].Points.Clear(); chartZone1.Series["T-10"].Points.Clear(); chartZone1.Series["T-11"].Points.Clear(); chartZone1.Series["T-12"].Points.Clear();

            timerForChartTC.Stop();


            tiempo = 0;

            FuncModeAntiguo();
            ModeChartTimeSS();

            // Limpiar todos txt's

            //txtSetTemp.ResetText();
            //txtTCView1.Clear(); txtTCView2.Clear(); txtTCView3.Clear(); txtTCView4.Clear(); txtTCView5.Clear(); txtTCView6.Clear(); txtTCView7.Clear(); txtTCView8.Clear(); txtTCView9.Clear(); txtTCView10.Clear(); txtTCView11.Clear(); txtTCView12.Clear(); txtTCView13.Clear(); txtTCView14.Clear(); txtTCView15.Clear(); txtTCView16.Clear(); txtTCView17.Clear(); txtTCView18.Clear(); txtTCView19.Clear(); txtTCView20.Clear(); txtTCView21.Clear(); txtTCView22.Clear(); txtTCView23.Clear(); txtTCView24.Clear();
            txtTC1.Clear(); txtTC2.Clear(); txtTC3.Clear(); txtTC4.Clear(); txtTC5.Clear(); txtTC6.Clear(); txtTC7.Clear(); txtTC8.Clear(); txtTC9.Clear(); txtTC10.Clear(); txtTC11.Clear(); txtTC12.Clear(); txtTC13.Clear(); txtTC14.Clear(); txtTC15.Clear(); txtTC16.Clear(); txtTC17.Clear(); txtTC18.Clear(); txtTC19.Clear(); txtTC20.Clear(); txtTC21.Clear(); txtTC22.Clear(); txtTC23.Clear(); txtTC24.Clear();
            txtSetPointZone2.Clear();


            // Reset variables

            TC1S = ""; TC2S = ""; TC3S = ""; TC4S = ""; TC5S = ""; TC6S = ""; TC7S = ""; TC8S = ""; TC9S = ""; TC10S = ""; TC11S = ""; TC12S = ""; TC13S = ""; TC14S = ""; TC15S = ""; TC16S = ""; TC17S = ""; TC18S = ""; TC19S = ""; TC20S = ""; TC21S = ""; TC22S = ""; TC23S = ""; TC24S = "";
            TC1Num = 0; TC2Num = 0; TC3Num = 0; TC4Num = 0; TC5Num = 0; TC6Num = 0; TC7Num = 0; TC8Num = 0; TC9Num = 0; TC10Num = 0; TC11Num = 0; TC12Num = 0; TC13Num = 0; TC14Num = 0; TC15Num = 0; TC16Num = 0; TC17Num = 0; TC18Num = 0; TC19Num = 0; TC20Num = 0; TC21Num = 0; TC22Num = 0; TC23Num = 0; TC24Num = 0;


            ZonasSelecionadasChart = 0;
            ZonasSelecionadasTXT = 0;
            ZonasSelecionadasSendTCSETPOINT = 0;
            i = false;

            // led1.Image.Dispose();
            // led2.Image.Dispose();
            // led1.Image = Properties.Resources.led_off;
            // led2.Image = Properties.Resources.led_off;
            

        }
                                                                                                      

        private void CiclosEnOtroHilo()
        {
            Thread.Sleep(2000);
            serialPort1.Write("P");
            Console.WriteLine("Hablando desde otro hilo :)");

        }

        private void FuncModeAntiguo()
        {
            lbCharMode.Text = "Chart Dinamic";
            //lbMinChartMode.Visible = false;
            //NumMinChart.Visible = false;
            //NumMinChart.Value = 2;
            ModoAntiguo = true;
            btnChartMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            TimerHoraFecha.Start();
            ResetAllDefault();

            listPanel.Add(panel10);
            listPanel.Add(panel11);
            listPanel.Add(panel13);
            listPanel.Add(panel14);
            listPanel[0].BringToFront();
            listPanel[2].BringToFront();

            //LED on Manual Control
            leds.Add(pictureBox15);// red on top ->id:0
            leds.Add(pictureBox14);// green on top ->id:1
            leds.Add(pictureBox16);//green on bot ->id:2
            leds.Add(pictureBox17);//red on bot; ->id:3

            //LED off Manual Control
            leds.Add(pictureBox11);//red on top ->id:4
            leds.Add(pictureBox10);// green on top ->id:5
            leds.Add(pictureBox13);//green on bot ->id:6
            leds.Add(pictureBox12);//red on bot; ->id:7

            //LED Status Bottom
            leds.Add(pictureBox18);//Green on -> id:8
            leds.Add(pictureBox5);// Green off -> id:9

            //LED status Top
            leds.Add(pictureBox19); //Green on -> id:10
            leds.Add(pictureBox8);// Green off -> id:11

            leds[4].BringToFront();
            leds[6].BringToFront();

            updateChart(chartZone1);
            updateChart(chartZone2);

            timerForChartTC.Interval = 100;
            timerForChartTC.Start();


        }


        /*
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu2);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu3);
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu4);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu5);
        }

        private void btnGestionArchivos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu6);
        }
        */

        /*
        private void AbrirMenu()
        {
            //panelSubMenuGestion.Visible = true;
            panelSubMenu2.Visible = true;
            panelSubMenu3.Visible = true;
            panelSubMenu4.Visible = true;
            panelSubMenu5.Visible = true;
           // panelSubMenu6.Visible = true;
            btnDownUpMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
        }

        private void CerrarMenu()
        {
            //panelSubMenuGestion.Visible = false;
            panelSubMenu2.Visible = false;
            panelSubMenu3.Visible = false;
            panelSubMenu4.Visible = false;
            panelSubMenu5.Visible = false;
           // panelSubMenu6.Visible = false;
            btnDownUpMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
        }

        private void btnDownUpMenu_Click(object sender, EventArgs e)
        {
            if (btnDownUpMenu.IconChar == FontAwesome.Sharp.IconChar.ChevronCircleDown)
            {
                AbrirMenu();
            }
            else if (btnDownUpMenu.IconChar == FontAwesome.Sharp.IconChar.ChevronCircleUp)
            {
                CerrarMenu();
            }
        }

        private void cbSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex >= 0)
            {
                btnSetTemperature.Enabled = true;
                txtSetTemp.Enabled = true;
                btnOnOff.Enabled = true;
            }
            if (cbSelect.SelectedIndex == 0)
            {
                led1.Image.Dispose();
                led2.Image.Dispose();
                led1.Image = Properties.Resources.led_on_green;
                led2.Image = Properties.Resources.led_off;
            }
            else if (cbSelect.SelectedIndex == 1)
            {
                led1.Image.Dispose();
                led2.Image.Dispose();
                led2.Image = Properties.Resources.led_on_green;
                led1.Image = Properties.Resources.led_off;
            }
        }
        */

        private void TimerHoraFecha_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dddd, MM/dd/yyyy");
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbFecha.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fecha);
        }

        private void cbCOMSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // if (cbCOMSelect1.SelectedIndex >= 0)
            {
               // btnConnectCOM1.Enabled = true;
            }
        }


        private void GenerarChart12()
        {

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

        private void GenerarChart24()
        {
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

        private void btnConnectCOM_Click(object sender, EventArgs e)
        {
           // if (btnConnectCOM1.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
               // if (reconocerCOM(cbCOMSelect1.SelectedItem.ToString()))
                {
                   // btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                   // cbCOMSelect1.Enabled = false;
                    //btnRefreshCOM1.Enabled = false;

                    // Se debe elegir Zona para trabajar / la pongo por defecto en todas
                   // cbSelect.Enabled = true;
                   // cbZonesMode.Enabled = true;
                   // cbZonesMode.SelectedIndex = 0;
                    ZonasSelecionadasSendTCSETPOINT = 0;

                   // ledZ1.Image.Dispose();
                   // ledZ1.Image = Properties.Resources.led_on_green;
                    ledZ2.Image.Dispose();
                    ledZ2.Image = Properties.Resources.led_on_green;


                    btnTypeTime.Enabled = true;
                    btnClearChart.Enabled = true;
                    btnStartStopChart.Enabled = true;
                    btnChartMode.Enabled = true;
                    btnRecordDataChart.Enabled = true;


                    //ChartMain.ChartAreas.Clear();

                    btnTypeTime.Visible = false;
                    btnClearChart.Visible = false;
                    btnStartStopChart.Visible = false;
                    btnChartMode.Visible = false;
                    btnRecordDataChart.Visible = false;

                    //picGREEN.Dispose();
                    //picYELLOW.Dispose();
                    //picRED.Dispose();

                    lbRecord.Visible = false;
                    lbCharMode.Visible = false;
                    label32.Visible = false;

                    //SIMULATION...
                    chartZone2.ChartAreas[0].AxisX.Minimum = 0;
                    chartZone2.Series["T-1"].Points.AddXY(0, 20);
                    chartZone2.Series["T-1"].Points.AddXY(1, 21);
                    chartZone2.Series["T-1"].Points.AddXY(2, 23);
                    chartZone2.Series["T-1"].Points.AddXY(3, 23);
                    chartZone2.Series["T-1"].Points.AddXY(4, 21);
                    chartZone2.Series["T-1"].Points.AddXY(5, 24);
                    chartZone2.Series["T-1"].Points.AddXY(6, 20);


                }
            }
           // else if (btnConnectCOM1.IconChar == FontAwesome.Sharp.IconChar.ToggleOn)
            {
               // btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            }
        }
        string TC1S = "";
        string TC2S = "";
        string TC3S = "";
        string TC4S = "";
        string TC5S = "";
        string TC6S = "";
        string TC7S = "";
        string TC8S = "";
        string TC9S = "";
        string TC10S = "";
        string TC11S = "";
        string TC12S = "";
        string TC13S = "";
        string TC14S = "";
        string TC15S = "";
        string TC16S = "";
        string TC17S = "";
        string TC18S = "";
        string TC19S = "";
        string TC20S = "";
        string TC21S = "";
        string TC22S = "";
        string TC23S = "";
        string TC24S = "";
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
        double TC11Num = 0;
        double TC12Num = 0;
        double TC13Num = 0;
        double TC14Num = 0;
        double TC15Num = 0;
        double TC16Num = 0;
        double TC17Num = 0;
        double TC18Num = 0;
        double TC19Num = 0;
        double TC20Num = 0;
        double TC21Num = 0;
        double TC22Num = 0;
        double TC23Num = 0;
        double TC24Num = 0;

        bool ModoAntiguo = true;

        double rt = 0;                              // Time X from chart
        double tempa = 0;
        
        

        private void timerForChartTC_Tick(object sender, EventArgs e)
        {
            //ChartMain.Series.Add("T-13");

            ChartArea CA = chartZone2.ChartAreas[0];
            CA.CursorX.AutoScroll = true;

            rt = rt + 100;
            tempa = rt / 1000;

            chartZone1.Series["T-1"].IsVisibleInLegend = true;

            chartZone2.Series["T-13"].Points.AddXY(tempa.ToString("0.0"), "20");

            chartZone2.ChartAreas[0].AxisY2.Maximum = Double.NaN;
            chartZone2.ChartAreas[0].AxisY2.Minimum = Double.NaN;
            chartZone2.ChartAreas[0].RecalculateAxesScale();
            
           
            

            if (chartZone2.Series["T-13"].Points.Count == 31)
            {

                chartZone2.Series["T-13"].Points.RemoveAt(0);
            }





            chartZone1.ChartAreas[0].AxisX.Interval = 5;
            //chart1.ChartAreas[0].AxisY2.Maximum = Double.NaN;
            //chart1.ChartAreas[0].AxisY2.Minimum = Double.NaN;
            chartZone1.ChartAreas[0].RecalculateAxesScale();
            stopwatch.Start();
            //ChartMain.Series["End"].IsVisibleInLegend = false;
            Random rnd = new Random();
            
            /*
            if (ModoAntiguo)
            {
                ChartModeAutoScrollLosingInfo();
            }
            else
            {
                //ChartModeNewZoomWithLimits();
            }
            */

            /* Option 2 for scrolling
           if (runningCount >= 15 && !freeze)
           {
               int ix = s.Points.AddXY(runningCount + timeCs, rnd.Next(90));
               ca.AxisX.Minimum = double.NaN;
               ca.AxisX.Maximum = double.NaN;
               ca.RecalculateAxesScale();

               ca.AxisX.ScaleView.Zoom(s.Points[ix - 15].XValue, s.Points[ix].XValue);

           }
            */

           //Test points random generated
           if ((stopwatch.ElapsedMilliseconds / 1000.0) < 30 && freeze != true)
           {
               chartZone1.Series["T-1"].Points.AddXY((stopwatch.ElapsedMilliseconds/1000.0), rnd.Next(90, 100));
               chartZone1.Series["T-2"].Points.AddXY((stopwatch.ElapsedMilliseconds/1000.0), rnd.Next(80, 90));
               chartZone1.Series["T-3"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(70, 80));
               chartZone1.Series["T-4"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(60, 70));
               chartZone1.Series["T-5"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(50, 60));
               chartZone1.Series["T-6"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(40, 50));
               chartZone1.Series["T-7"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(30, 40));
               chartZone1.Series["T-8"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(20, 30));
               chartZone1.Series["T-9"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(10, 20));
               chartZone1.Series["T-10"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(0, 0));
               chartZone1.Series["T-11"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(0, 0));
               chartZone1.Series["T-12"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(0, 0));

                

            }

           ChartArea ca = chartZone1.ChartAreas["ChartArea1"];
           Series s = chartZone1.Series["T-1"];



           if((stopwatch.ElapsedMilliseconds / 1000.0) > 30 && !freeze)
           {
               int ix = s.Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(80, 90));
               chartZone1.Series["T-1"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(90, 100));
                chartZone1.Series["T-2"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(80, 90));
                chartZone1.Series["T-3"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(70, 80));
                chartZone1.Series["T-4"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(60, 70));
                chartZone1.Series["T-5"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(50, 60));
                chartZone1.Series["T-6"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(40, 50));
                chartZone1.Series["T-7"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(30, 40));
                chartZone1.Series["T-8"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(20, 30));
                chartZone1.Series["T-9"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(10, 20));
                chartZone1.Series["T-10"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(0, 0));
                chartZone1.Series["T-11"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(0, 0));
                chartZone1.Series["T-12"].Points.AddXY((stopwatch.ElapsedMilliseconds / 1000.0), rnd.Next(0, 0));
              
                double temper = s.Points[ix].XValue;
                //ca.AxisX.Maximum = Math.Round(s.Points[ix].XValue, 1);
                //ca.AxisX.Maximum = double.NaN;
                //ca.AxisX.Minimum += Math.Round(s.Points[ix].XValue - s.Points[ix-1].XValue, 1);
                //ca.AxisX.Minimum += double.NaN;
                //ca.RecalculateAxesScale();
                txtTC1.Text = temper.ToString();        
            }

/*
           if (runningCount < 30 && freeze != true)
           {
               ChartMain.Series["T-13"].Points.AddXY(runningCount + timeCs, rnd.Next(90, 100));
               ChartMain.Series["T-14"].Points.AddXY(runningCount + timeCs, rnd.Next(80, 90));
               ChartMain.Series["T-15"].Points.AddXY(runningCount + timeCs, rnd.Next(70, 80));
               ChartMain.Series["T-16"].Points.AddXY(runningCount + timeCs, rnd.Next(60, 70));
               ChartMain.Series["T-17"].Points.AddXY(runningCount + timeCs, rnd.Next(50, 60));
               ChartMain.Series["T-18"].Points.AddXY(runningCount + timeCs, rnd.Next(40, 50));
               ChartMain.Series["T-19"].Points.AddXY(runningCount + timeCs, rnd.Next(30, 40));
               ChartMain.Series["T-20"].Points.AddXY(runningCount + timeCs, rnd.Next(20, 30));
               ChartMain.Series["T-21"].Points.AddXY(runningCount + timeCs, rnd.Next(10, 20));
               ChartMain.Series["T-22"].Points.AddXY(runningCount + timeCs, rnd.Next(0, 10));
               ChartMain.Series["T-23"].Points.AddXY(runningCount + timeCs, rnd.Next(0));
               ChartMain.Series["T-24"].Points.AddXY(runningCount + timeCs,rnd.Next(0));
               ChartMain.Series["End"].Points.AddXY(runningCount + 3, 0);
            }
*/



           ChartArea ca2 = chartZone2.ChartAreas[0];
           Series s2 = chartZone2.Series["T-13"];

            /*
            if (runningCount >= 30 && !freeze)
            {
                int ix = s2.Points.AddXY(runningCount + timeCs, rnd.Next(90, 100));
                ChartMain.Series["T-14"].Points.AddXY(runningCount + timeCs, rnd.Next(70, 80));
                ChartMain.Series["T-15"].Points.AddXY(runningCount + timeCs, rnd.Next(60, 70));
                ChartMain.Series["T-16"].Points.AddXY(runningCount + timeCs, rnd.Next(50, 60));
                ChartMain.Series["T-17"].Points.AddXY(runningCount + timeCs, rnd.Next(40, 50));
                ChartMain.Series["T-18"].Points.AddXY(runningCount + timeCs, rnd.Next(30, 40));
                ChartMain.Series["T-19"].Points.AddXY(runningCount + timeCs, rnd.Next(20, 30));
                ChartMain.Series["T-20"].Points.AddXY(runningCount + timeCs, rnd.Next(10, 20));
                ChartMain.Series["T-21"].Points.AddXY(runningCount + timeCs, rnd.Next(0, 10));
                ChartMain.Series["T-22"].Points.AddXY(runningCount + timeCs, rnd.Next(0));
                ChartMain.Series["T-23"].Points.AddXY(runningCount + timeCs, rnd.Next(0));
                ChartMain.Series["T-24"].Points.AddXY(runningCount + timeCs, rnd.Next(0));
                ChartMain.Series["End"].Points.AddXY(runningCount + 3, 0);

                // ca2.AxisX.Maximum = s.Points[ix].XValue;
                // ca2.AxisX.Minimum += s.Points[ix].XValue - s.Points[ix - 1].XValue;
                // ca2.RecalculateAxesScale();
            }
            */


            DataPoint[] points = new DataPoint[12];
            DataPoint[] points2 = new DataPoint[12];
           /* 
            points[0] = ChartMain.Series["T-13"].Points.Last();
            points[1] = ChartMain.Series["T-14"].Points.Last();
            points[2] = ChartMain.Series["T-15"].Points.Last();
            points[3] = ChartMain.Series["T-16"].Points.Last();
            points[4] = ChartMain.Series["T-17"].Points.Last();
            points[5] = ChartMain.Series["T-18"].Points.Last();
            points[6] = ChartMain.Series["T-19"].Points.Last();
            points[7] = ChartMain.Series["T-20"].Points.Last();
            points[8] = ChartMain.Series["T-21"].Points.Last();
            points[9] = ChartMain.Series["T-22"].Points.Last();
            points[10] = ChartMain.Series["T-23"].Points.Last();
            points[11] = ChartMain.Series["T-24"].Points.Last();
           */
            points2[0] = chartZone1.Series["T-1"].Points.Last();
            points2[1] = chartZone1.Series["T-2"].Points.Last();
            points2[2] = chartZone1.Series["T-3"].Points.Last();     
            points2[3] = chartZone1.Series["T-4"].Points.Last();
            points2[4] = chartZone1.Series["T-5"].Points.Last();
            points2[5] = chartZone1.Series["T-6"].Points.Last();
            points2[6] = chartZone1.Series["T-7"].Points.Last();
            points2[7] = chartZone1.Series["T-8"].Points.Last();
            points2[8] = chartZone1.Series["T-9"].Points.Last();
            points2[9] = chartZone1.Series["T-10"].Points.Last();
            points2[10] = chartZone1.Series["T-11"].Points.Last();
            points2[11] = chartZone1.Series["T-12"].Points.Last();


            
            Double[] values = new Double[12];
            Double[] values2 = new Double[12];

            //for(int i = 0; i < values.Length; i++)   values[i] = points[i].YValues[0];
            

            for(int i=0; i < values2.Length;i++) values2[i] = points2[i].YValues[0];

            /*
            textBox28.Text = values[0].ToString() + "°C";
            textBox29.Text = values[1].ToString() + "°C";
            textBox30.Text = values[2].ToString() + "°C";
            textBox31.Text = values[3].ToString() + "°C";
            textBox32.Text = values[4].ToString() + "°C";
            textBox33.Text = values[5].ToString() + "°C";
            textBox34.Text = values[6].ToString() + "°C";
            textBox35.Text = values[7].ToString() + "°C";
            textBox36.Text = values[8].ToString() + "°C";
            textBox37.Text = values[9].ToString() + "°C";
            textBox38.Text = values[10].ToString() + "°C";
            textBox39.Text = values[11].ToString() + "°C";
            */

            double temp = stopwatch.ElapsedMilliseconds/1000.0;

            txtTC1.Text = temp.ToString();//values[12].ToString() + "°C";  
            txtTC2.Text = values2[2].ToString() + "°C"; //temp.ToString();//timeCs.ToString();//values[13].ToString() + "°C";
            txtTC3.Text = values2[2].ToString() + "°C";     
            txtTC4.Text = values2[3].ToString() + "°C";
            txtTC5.Text = values2[4].ToString() + "°C";
            txtTC6.Text = values2[5].ToString() + "°C";
            txtTC7.Text = values2[6].ToString() + "°C";
            txtTC8.Text = values2[7].ToString() + "°C";
            txtTC9.Text = values2[8].ToString() + "°C";
            txtTC10.Text = values2[9].ToString() + "°C";
            txtTC11.Text = values2[10].ToString() + "°C";
            txtTC12.Text = values2[11].ToString() + "°C";

            double average = 0;
            for(int i = 0; i < values2.Length; i++)
            {
                average += values2[i];
            }

            average = Math.Truncate(average/ values2.Length);
            textBox48.Text = average.ToString();

            chartZone1.ChartAreas[0].AxisX.IsMarginVisible = true;
            chartZone1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;

            if (textBox46.Text != null)
            {
               // if (average > Double.Parse(textBox46.Text)) leds[0].BringToFront();
                //else if (average < Double.Parse(textBox46.Text)) leds[0].BringToFront();
            }

            if (running)
            {
                if ((stopwatch.ElapsedMilliseconds / 1000) % 2 == 0)
                {
                    leds[8].BringToFront();
                    leds[10].BringToFront();
                }
                else { 
                    leds[9].BringToFront();
                    leds[11].BringToFront();
                }

            }
            

        }

        private void ChartModeAutoScrollLosingInfo()
        {
            GraficarChart();

            chartZone2.ChartAreas[0].AxisX.Minimum = double.NaN;
            chartZone2.ChartAreas[0].AxisX.Maximum = double.NaN;
            chartZone2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartZone2.ChartAreas[0].CursorX.AutoScroll = true;
            chartZone2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartZone2.ChartAreas[0].RecalculateAxesScale();

            if (ZonasSelecionadasChart == 0)
            {
                if (chartZone2.Series["T-1"].Points.Count >= 100)
                {
                    chartZone2.Series["T-1"].Points.RemoveAt(0); chartZone2.Series["T-2"].Points.RemoveAt(0); chartZone2.Series["T-3"].Points.RemoveAt(0); chartZone2.Series["T-4"].Points.RemoveAt(0); chartZone2.Series["T-5"].Points.RemoveAt(0); chartZone2.Series["T-6"].Points.RemoveAt(0); chartZone2.Series["T-7"].Points.RemoveAt(0); chartZone2.Series["T-8"].Points.RemoveAt(0); chartZone2.Series["T-9"].Points.RemoveAt(0); chartZone2.Series["T-10"].Points.RemoveAt(0); chartZone2.Series["T-11"].Points.RemoveAt(0); chartZone2.Series["T-12"].Points.RemoveAt(0); chartZone2.Series["T-13"].Points.RemoveAt(0); chartZone2.Series["T-14"].Points.RemoveAt(0); chartZone2.Series["T-15"].Points.RemoveAt(0); chartZone2.Series["T-16"].Points.RemoveAt(0); chartZone2.Series["T-17"].Points.RemoveAt(0); chartZone2.Series["T-18"].Points.RemoveAt(0); chartZone2.Series["T-19"].Points.RemoveAt(0); chartZone2.Series["T-20"].Points.RemoveAt(0); chartZone2.Series["T-21"].Points.RemoveAt(0); chartZone2.Series["T-22"].Points.RemoveAt(0); chartZone2.Series["T-23"].Points.RemoveAt(0); chartZone2.Series["T-24"].Points.RemoveAt(0);
                }
            }
            else if (ZonasSelecionadasChart == 1)
            {
                if (chartZone2.Series["T-1"].Points.Count >= 100)
                {
                    chartZone2.Series["T-1"].Points.RemoveAt(0); chartZone2.Series["T-2"].Points.RemoveAt(0); chartZone2.Series["T-3"].Points.RemoveAt(0); chartZone2.Series["T-4"].Points.RemoveAt(0); chartZone2.Series["T-5"].Points.RemoveAt(0); chartZone2.Series["T-6"].Points.RemoveAt(0); chartZone2.Series["T-7"].Points.RemoveAt(0); chartZone2.Series["T-8"].Points.RemoveAt(0); chartZone2.Series["T-9"].Points.RemoveAt(0); chartZone2.Series["T-10"].Points.RemoveAt(0); chartZone2.Series["T-11"].Points.RemoveAt(0); chartZone2.Series["T-12"].Points.RemoveAt(0);
                } 
            }
            else if (ZonasSelecionadasChart == 2)
            {
                if (chartZone2.Series["T-13"].Points.Count >= 100)
                {
                    chartZone2.Series["T-13"].Points.RemoveAt(0); chartZone2.Series["T-14"].Points.RemoveAt(0); chartZone2.Series["T-15"].Points.RemoveAt(0); chartZone2.Series["T-16"].Points.RemoveAt(0); chartZone2.Series["T-17"].Points.RemoveAt(0); chartZone2.Series["T-18"].Points.RemoveAt(0); chartZone2.Series["T-19"].Points.RemoveAt(0); chartZone2.Series["T-20"].Points.RemoveAt(0); chartZone2.Series["T-21"].Points.RemoveAt(0); chartZone2.Series["T-22"].Points.RemoveAt(0); chartZone2.Series["T-23"].Points.RemoveAt(0); chartZone2.Series["T-24"].Points.RemoveAt(0);
                }
            }

        }

        double tiempo = 0;
        //ZonasSeleccionadas 0 = Todas 1 = Zona 1 2 = Zona 2 3 = Zona 3 4 = Zona 4
        int ZonasSelecionadasChart = 0;
        int ZonasSelecionadasTXT = 0;
        int ZonasSelecionadasSendTCSETPOINT = 0;

        private void GraficarChart()
        {
            tiempo = tiempo + 100;

            if (TimeEnSegundosChart)
            {
                double temp = tiempo / 1000;
                if (ZonasSelecionadasChart == 0)
                {
                    chartZone2.Series["TC-1"].Points.AddXY(temp.ToString(), TC1Num.ToString()); chartZone2.Series["TC-2"].Points.AddXY(temp.ToString(), TC2Num.ToString()); chartZone2.Series["TC-3"].Points.AddXY(temp.ToString(), TC3Num.ToString()); chartZone2.Series["TC-4"].Points.AddXY(temp.ToString(), TC4Num.ToString()); chartZone2.Series["TC-5"].Points.AddXY(temp.ToString(), TC5Num.ToString()); chartZone2.Series["TC-6"].Points.AddXY(temp.ToString(), TC6Num.ToString()); chartZone2.Series["TC-7"].Points.AddXY(temp.ToString(), TC7Num.ToString()); chartZone2.Series["TC-8"].Points.AddXY(temp.ToString(), TC8Num.ToString()); chartZone2.Series["TC-9"].Points.AddXY(temp.ToString(), TC9Num.ToString()); chartZone2.Series["TC-10"].Points.AddXY(temp.ToString(), TC10Num.ToString()); chartZone2.Series["TC-11"].Points.AddXY(temp.ToString(), TC11Num.ToString()); chartZone2.Series["TC-12"].Points.AddXY(temp.ToString(), TC12Num.ToString()); chartZone2.Series["TC-13"].Points.AddXY(temp.ToString(), TC13Num.ToString()); chartZone2.Series["TC-14"].Points.AddXY(temp.ToString(), TC14Num.ToString()); chartZone2.Series["TC-15"].Points.AddXY(temp.ToString(), TC15Num.ToString()); chartZone2.Series["TC-16"].Points.AddXY(temp.ToString(), TC16Num.ToString()); chartZone2.Series["TC-17"].Points.AddXY(temp.ToString(), TC17Num.ToString()); chartZone2.Series["TC-18"].Points.AddXY(temp.ToString(), TC18Num.ToString()); chartZone2.Series["TC-19"].Points.AddXY(temp.ToString(), TC19Num.ToString()); chartZone2.Series["TC-20"].Points.AddXY(temp.ToString(), TC20Num.ToString()); chartZone2.Series["TC-21"].Points.AddXY(temp.ToString(), TC21Num.ToString()); chartZone2.Series["TC-22"].Points.AddXY(temp.ToString(), TC22Num.ToString()); chartZone2.Series["TC-23"].Points.AddXY(temp.ToString(), TC23Num.ToString()); chartZone2.Series["TC-24"].Points.AddXY(temp.ToString(), TC24Num.ToString());
                }
                else if (ZonasSelecionadasChart == 1)
                {
                    chartZone2.Series["TC-1"].Points.AddXY(temp.ToString(), TC1Num.ToString()); chartZone2.Series["TC-2"].Points.AddXY(temp.ToString(), TC2Num.ToString()); chartZone2.Series["TC-3"].Points.AddXY(temp.ToString(), TC3Num.ToString()); chartZone2.Series["TC-4"].Points.AddXY(temp.ToString(), TC4Num.ToString()); chartZone2.Series["TC-5"].Points.AddXY(temp.ToString(), TC5Num.ToString()); chartZone2.Series["TC-6"].Points.AddXY(temp.ToString(), TC6Num.ToString()); chartZone2.Series["TC-7"].Points.AddXY(temp.ToString(), TC7Num.ToString()); chartZone2.Series["TC-8"].Points.AddXY(temp.ToString(), TC8Num.ToString()); chartZone2.Series["TC-9"].Points.AddXY(temp.ToString(), TC9Num.ToString()); chartZone2.Series["TC-10"].Points.AddXY(temp.ToString(), TC10Num.ToString()); chartZone2.Series["TC-11"].Points.AddXY(temp.ToString(), TC11Num.ToString()); chartZone2.Series["TC-12"].Points.AddXY(temp.ToString(), TC12Num.ToString());
                }
                else if (ZonasSelecionadasChart == 2)
                {
                    chartZone2.Series["TC-13"].Points.AddXY(temp.ToString(), TC13Num.ToString()); chartZone2.Series["TC-14"].Points.AddXY(temp.ToString(), TC14Num.ToString()); chartZone2.Series["TC-15"].Points.AddXY(temp.ToString(), TC15Num.ToString()); chartZone2.Series["TC-16"].Points.AddXY(temp.ToString(), TC16Num.ToString()); chartZone2.Series["TC-17"].Points.AddXY(temp.ToString(), TC17Num.ToString()); chartZone2.Series["TC-18"].Points.AddXY(temp.ToString(), TC18Num.ToString()); chartZone2.Series["TC-19"].Points.AddXY(temp.ToString(), TC19Num.ToString()); chartZone2.Series["TC-20"].Points.AddXY(temp.ToString(), TC20Num.ToString()); chartZone2.Series["TC-21"].Points.AddXY(temp.ToString(), TC21Num.ToString()); chartZone2.Series["TC-22"].Points.AddXY(temp.ToString(), TC22Num.ToString()); chartZone2.Series["TC-23"].Points.AddXY(temp.ToString(), TC23Num.ToString()); chartZone2.Series["TC-24"].Points.AddXY(temp.ToString(), TC24Num.ToString());
                }
            }
            else
            {
                string HoraMinSeg = DateTime.Now.ToString("hh:mm:ss");
                if (ZonasSelecionadasChart == 0)
                {
                    chartZone2.Series["TC-1"].Points.AddXY(HoraMinSeg.ToString(), TC1Num.ToString()); chartZone2.Series["TC-2"].Points.AddXY(HoraMinSeg.ToString(), TC2Num.ToString()); chartZone2.Series["TC-3"].Points.AddXY(HoraMinSeg.ToString(), TC3Num.ToString()); chartZone2.Series["TC-4"].Points.AddXY(HoraMinSeg.ToString(), TC4Num.ToString()); chartZone2.Series["TC-5"].Points.AddXY(HoraMinSeg.ToString(), TC5Num.ToString()); chartZone2.Series["TC-6"].Points.AddXY(HoraMinSeg.ToString(), TC6Num.ToString()); chartZone2.Series["TC-7"].Points.AddXY(HoraMinSeg.ToString(), TC7Num.ToString()); chartZone2.Series["TC-8"].Points.AddXY(HoraMinSeg.ToString(), TC8Num.ToString()); chartZone2.Series["TC-9"].Points.AddXY(HoraMinSeg.ToString(), TC9Num.ToString()); chartZone2.Series["TC-10"].Points.AddXY(HoraMinSeg.ToString(), TC10Num.ToString()); chartZone2.Series["TC-11"].Points.AddXY(HoraMinSeg.ToString(), TC11Num.ToString()); chartZone2.Series["TC-12"].Points.AddXY(HoraMinSeg.ToString(), TC12Num.ToString()); chartZone2.Series["TC-13"].Points.AddXY(HoraMinSeg.ToString(), TC13Num.ToString()); chartZone2.Series["TC-14"].Points.AddXY(HoraMinSeg.ToString(), TC14Num.ToString()); chartZone2.Series["TC-15"].Points.AddXY(HoraMinSeg.ToString(), TC15Num.ToString()); chartZone2.Series["TC-16"].Points.AddXY(HoraMinSeg.ToString(), TC16Num.ToString()); chartZone2.Series["TC-17"].Points.AddXY(HoraMinSeg.ToString(), TC17Num.ToString()); chartZone2.Series["TC-18"].Points.AddXY(HoraMinSeg.ToString(), TC18Num.ToString()); chartZone2.Series["TC-19"].Points.AddXY(HoraMinSeg.ToString(), TC19Num.ToString()); chartZone2.Series["TC-20"].Points.AddXY(HoraMinSeg.ToString(), TC20Num.ToString()); chartZone2.Series["TC-21"].Points.AddXY(HoraMinSeg.ToString(), TC21Num.ToString()); chartZone2.Series["TC-22"].Points.AddXY(HoraMinSeg.ToString(), TC22Num.ToString()); chartZone2.Series["TC-23"].Points.AddXY(HoraMinSeg.ToString(), TC23Num.ToString()); chartZone2.Series["TC-24"].Points.AddXY(HoraMinSeg.ToString(), TC24Num.ToString());
                }
                else if (ZonasSelecionadasChart == 1)
                {
                    chartZone2.Series["TC-1"].Points.AddXY(HoraMinSeg.ToString(), TC1Num.ToString()); chartZone2.Series["TC-2"].Points.AddXY(HoraMinSeg.ToString(), TC2Num.ToString()); chartZone2.Series["TC-3"].Points.AddXY(HoraMinSeg.ToString(), TC3Num.ToString()); chartZone2.Series["TC-4"].Points.AddXY(HoraMinSeg.ToString(), TC4Num.ToString()); chartZone2.Series["TC-5"].Points.AddXY(HoraMinSeg.ToString(), TC5Num.ToString()); chartZone2.Series["TC-6"].Points.AddXY(HoraMinSeg.ToString(), TC6Num.ToString()); chartZone2.Series["TC-7"].Points.AddXY(HoraMinSeg.ToString(), TC7Num.ToString()); chartZone2.Series["TC-8"].Points.AddXY(HoraMinSeg.ToString(), TC8Num.ToString()); chartZone2.Series["TC-9"].Points.AddXY(HoraMinSeg.ToString(), TC9Num.ToString()); chartZone2.Series["TC-10"].Points.AddXY(HoraMinSeg.ToString(), TC10Num.ToString()); chartZone2.Series["TC-11"].Points.AddXY(HoraMinSeg.ToString(), TC11Num.ToString()); chartZone2.Series["TC-12"].Points.AddXY(HoraMinSeg.ToString(), TC12Num.ToString());
                }
                else if (ZonasSelecionadasChart == 2)
                {
                    chartZone2.Series["TC-13"].Points.AddXY(HoraMinSeg.ToString(), TC13Num.ToString()); chartZone2.Series["TC-14"].Points.AddXY(HoraMinSeg.ToString(), TC14Num.ToString()); chartZone2.Series["TC-15"].Points.AddXY(HoraMinSeg.ToString(), TC15Num.ToString()); chartZone2.Series["TC-16"].Points.AddXY(HoraMinSeg.ToString(), TC16Num.ToString()); chartZone2.Series["TC-17"].Points.AddXY(HoraMinSeg.ToString(), TC17Num.ToString()); chartZone2.Series["TC-18"].Points.AddXY(HoraMinSeg.ToString(), TC18Num.ToString()); chartZone2.Series["TC-19"].Points.AddXY(HoraMinSeg.ToString(), TC19Num.ToString()); chartZone2.Series["TC-20"].Points.AddXY(HoraMinSeg.ToString(), TC20Num.ToString()); chartZone2.Series["TC-21"].Points.AddXY(HoraMinSeg.ToString(), TC21Num.ToString()); chartZone2.Series["TC-22"].Points.AddXY(HoraMinSeg.ToString(), TC22Num.ToString()); chartZone2.Series["TC-23"].Points.AddXY(HoraMinSeg.ToString(), TC23Num.ToString()); chartZone2.Series["TC-24"].Points.AddXY(HoraMinSeg.ToString(), TC24Num.ToString());
                }
            }
        }

        bool TimeEnSegundosChart = true;

        private void btnTypeTime_Click(object sender, EventArgs e)
        {
            if (btnTypeTime.IconChar == FontAwesome.Sharp.IconChar.Stopwatch)
            {
                ModeChartTimeHHmmss();
            }
            else if (btnTypeTime.IconChar == FontAwesome.Sharp.IconChar.Clock)
            {
                ModeChartTimeSS();
            }
        }

        private void ModeChartTimeHHmmss()
        {
            btnTypeTime.IconChar = FontAwesome.Sharp.IconChar.Clock;
            btnTypeTime.IconFont = FontAwesome.Sharp.IconFont.Regular;
            TimeEnSegundosChart = false;
        }
        private void ModeChartTimeSS()
        {
            btnTypeTime.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            btnTypeTime.IconFont = FontAwesome.Sharp.IconFont.Solid;
            TimeEnSegundosChart = true;
        }

        bool Record;
        DateTime star_record = new DateTime();
        DateTime end_record = new DateTime();

        private List<string> TC1A = new List<string>();
        private List<string> TC2A = new List<string>();
        private List<string> TC3A = new List<string>();
        private List<string> TC4A = new List<string>();
        private List<string> TC5A = new List<string>();
        private List<string> TC6A = new List<string>();
        private List<string> TC7A = new List<string>();
        private List<string> TC8A = new List<string>();
        private List<string> TC9A = new List<string>();
        private List<string> TC10A = new List<string>();
        private List<string> TC11A = new List<string>();
        private List<string> TC12A = new List<string>();
        private List<string> TC13A = new List<string>();
        private List<string> TC14A = new List<string>();
        private List<string> TC15A = new List<string>();
        private List<string> TC16A = new List<string>();
        private List<string> TC17A = new List<string>();
        private List<string> TC18A = new List<string>();
        private List<string> TC19A = new List<string>();
        private List<string> TC20A = new List<string>();
        private List<string> TC21A = new List<string>();
        private List<string> TC22A = new List<string>();
        private List<string> TC23A = new List<string>();
        private List<string> TC24A = new List<string>();
        private List<string> DATETIMES = new List<string>();
        private List<string> TIMES = new List<string>();

        private void btnRecordDataChart_Click(object sender, EventArgs e)
        {

        }

        private void btnSetTemperature_Click(object sender, EventArgs e)
        {
            if (ZonasSelecionadasSendTCSETPOINT == 0)
            {
               // txtSetPointZone1.Text = txtSetTemp.Value.ToString();
               // txtSetPointZone2.Text = txtSetTemp.Value.ToString();
            }
            else if (ZonasSelecionadasSendTCSETPOINT == 1)
            {
               // txtSetPointZone1.Text = txtSetTemp.Value.ToString();
            }
            else if (ZonasSelecionadasSendTCSETPOINT == 2)
            {
               // txtSetPointZone2.Text = txtSetTemp.Value.ToString();
            }
            
        }

        private void btnStartStopChart_Click(object sender, EventArgs e)
        {
            if (btnStartStopChart.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                EncenderChart();
            }
            else if (btnStartStopChart.IconChar == FontAwesome.Sharp.IconChar.ToggleOn)
            {
                ApagarChartSinBorrar();
            }
        }
        private void ApagarChartSinBorrar()
        {
            timerForChartTC.Stop();
            btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
        }

        private void EncenderChart()
        {
            ResetearChart();
            timerForChartTC.Start();
            btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
        }

        bool BanderaRespuestaParaTCS = false;
        Boolean i = false;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (i == false)
                {
                    tiempo = 0;
                    i = true;
                }

                if (BanderaRespuestaParaTCS)
                {
                    try
                    {
                        Thread.Sleep(2000);
                        string DataIn = serialPort1.ReadExisting();
                        if (DataIn != null && DataIn != String.Empty)
                        {
                            ReadData(DataIn);
                            serialPort1.DiscardInBuffer();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        private void ReadData(string data)
        {
            if (data != null && data != string.Empty)
            {
                // Paso 1 Quitar cualquier espacio
                string tcs = data.Trim();
                if (tcs.Length == 71)
                {
                    tcs = tcs.Replace("\r", string.Empty);
                    //Paso 2 quitar el >+ inicial
                    tcs = tcs.Substring(2);
                    //Paso 3 separar por +
                    string[] TC = tcs.Split('+');

                    //Paso 4 asignar cada TC
                    if (TC.Length == 10)
                    {
                        TC1S = TC[0];
                        TC2S = TC[1];
                        TC3S = TC[2];
                        TC4S = TC[3];
                        TC5S = TC[4];
                        TC6S = TC[5];
                        TC7S = TC[6];
                        TC8S = TC[7];
                        TC9S = TC[8];
                        TC10S = TC[9];
                    }

                    // Paso 5 reasignar valores

                    TC1S = TC1S.Substring(2);
                    TC2S = TC2S.Substring(2);
                    TC3S = TC3S.Substring(2);
                    TC4S = TC4S.Substring(2);
                    TC5S = TC5S.Substring(2);
                    TC6S = TC6S.Substring(2);
                    TC7S = TC7S.Substring(2);
                    TC8S = TC8S.Substring(2);
                    TC9S = TC9S.Substring(2);
                    TC10S = TC10S.Substring(2);

                    // Paso 6 Separar a las con numeros a las con C°

                    TC1Num = Convert.ToDouble(TC1S);
                    TC2Num = Convert.ToDouble(TC2S);
                    TC3Num = Convert.ToDouble(TC3S);
                    TC4Num = Convert.ToDouble(TC4S);
                    TC5Num = Convert.ToDouble(TC5S);
                    TC6Num = Convert.ToDouble(TC6S);
                    TC7Num = Convert.ToDouble(TC7S);
                    TC8Num = Convert.ToDouble(TC8S);
                    TC9Num = Convert.ToDouble(TC9S);
                    TC10Num = Convert.ToDouble(TC10S);

                    // Paso Final
                    TC1S = TC1S + " C°";
                    TC2S = TC2S + " C°";
                    TC3S = TC3S + " C°";
                    TC4S = TC4S + " C°";
                    TC5S = TC5S + " C°";
                    TC6S = TC6S + " C°";
                    TC7S = TC7S + " C°";
                    TC8S = TC8S + " C°";
                    TC9S = TC9S + " C°";
                    TC10S = TC10S + " C°";

                    //TODO GRAFICAR.
                    GraficarDatosTxt();
                }
            }
        }

        private void GraficarDatosTxt()
        {

            if (ZonasSelecionadasTXT == 1)
            {
               // txtTCView1.Text = TC1S; txtTCView2.Text = TC2S; txtTCView3.Text = TC3S; txtTCView4.Text = TC4S; txtTCView5.Text = TC5S; txtTCView6.Text = TC6S; txtTCView7.Text = TC7S; txtTCView8.Text = TC8S; txtTCView9.Text = TC9S; txtTCView10.Text = TC10S; txtTCView11.Text = TC11S; txtTCView12.Text = TC12S; txtTCView13.Text = TC13S; txtTCView14.Text = TC14S; txtTCView15.Text = TC15S; txtTCView16.Text = TC16S; txtTCView17.Text = TC17S; txtTCView18.Text = TC18S; txtTCView19.Text = TC19S; txtTCView20.Text = TC20S; txtTCView21.Text = TC21S; txtTCView22.Text = TC22S; txtTCView23.Text = TC23S; txtTCView24.Text = TC24S;
            }
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            ApagarChart();
        }
        private void ApagarChart()
        {
            ResetearChart();
            timerForChartTC.Stop();
            btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
        }

        private void ResetearChart()
        {
            if (ZonasSelecionadasChart == 0)
            {
                chartZone2.Series["TC-1"].Points.Clear(); chartZone2.Series["TC-2"].Points.Clear(); chartZone2.Series["TC-3"].Points.Clear(); chartZone2.Series["TC-4"].Points.Clear(); chartZone2.Series["TC-5"].Points.Clear(); chartZone2.Series["TC-6"].Points.Clear(); chartZone2.Series["TC-7"].Points.Clear(); chartZone2.Series["TC-8"].Points.Clear(); chartZone2.Series["TC-9"].Points.Clear(); chartZone2.Series["TC-10"].Points.Clear(); chartZone2.Series["TC-11"].Points.Clear(); chartZone2.Series["TC-12"].Points.Clear(); chartZone2.Series["TC-13"].Points.Clear(); chartZone2.Series["TC-14"].Points.Clear(); chartZone2.Series["TC-15"].Points.Clear(); chartZone2.Series["TC-16"].Points.Clear(); chartZone2.Series["TC-17"].Points.Clear(); chartZone2.Series["TC-18"].Points.Clear(); chartZone2.Series["TC-19"].Points.Clear(); chartZone2.Series["TC-20"].Points.Clear(); chartZone2.Series["TC-21"].Points.Clear(); chartZone2.Series["TC-22"].Points.Clear(); chartZone2.Series["TC-23"].Points.Clear(); chartZone2.Series["TC-24"].Points.Clear();
            }

            ChartArea CA = chartZone2.ChartAreas[0];
            CA.CursorX.AutoScroll = true;
            i = false;
            tiempo = 0;
        }

        private void btnChartMode_Click(object sender, EventArgs e)
        {

        }

        private void timerRequestData_Tick(object sender, EventArgs e)
        {

        }

        /*
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (btnOnOff.Text.Trim() == "Turn On")
            {
                btnOnOff.Text = "         Turn Off";
                btnReportes.Text = "Status: " + "ON";
                btnOnOff.IconColor = Color.White;
            }
            else if (btnOnOff.Text.Trim() == "Turn Off")
            {
                btnOnOff.Text = "         Turn On";
                btnReportes.Text = "Status: OFF";
                btnOnOff.IconColor = Color.White;
            }
        }
        */



        private void btnEMO_Click(object sender, EventArgs e)
        {
            freeze = true;
            //ResetAllDefault();
            //Thread t = new Thread(new ThreadStart(CiclosEnOtroHilo));
            //t.Start();
        }

        /*
        private void cbZonesMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbZonesMode.SelectedIndex == 0)
            {
               // ledZ1.Image.Dispose();
               // ledZ2.Image.Dispose();
               // ledZ1.Image = Properties.Resources.led_on_green;
               // ledZ2.Image = Properties.Resources.led_on_green;
                ZonasSelecionadasSendTCSETPOINT = 0;

            }
            else if (cbZonesMode.SelectedIndex == 1)
            {
              //  ledZ1.Image.Dispose();
                ledZ2.Image.Dispose();
               // ledZ1.Image = Properties.Resources.led_on_green;
                ledZ2.Image = Properties.Resources.led_off;
                ZonasSelecionadasSendTCSETPOINT = 1;

            }
            else if (cbZonesMode.SelectedIndex == 2)
            {
              //  ledZ1.Image.Dispose();
                ledZ2.Image.Dispose();
                //ledZ1.Image = Properties.Resources.led_off;
                ledZ2.Image = Properties.Resources.led_on_green;
                ZonasSelecionadasSendTCSETPOINT = 2;

            }
        }
        */

        private void btnRefreshCOM_Click(object sender, EventArgs e)
        {
           // cbSelect.SelectedIndex = -1;
           // btnConnectCOM1.Enabled = false;
           // cbCOMSelect1.Enabled = true;
            string[] ports = SerialPort.GetPortNames();
           // cbCOMSelect1.Items.Clear();
           // cbCOMSelect1.Items.AddRange(ports);
        }

        private void lbCharMode_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void lbRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnCSVFileFilter_Click(object sender, EventArgs e)
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbZone1_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone2label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void zone2label3_Click(object sender, EventArgs e)
        {

        }

        private void zone2label6_Click(object sender, EventArgs e)
        {
                                                            
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

       

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listPanel[3].BringToFront();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelZone1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtTC12_TextChanged(object sender, EventArgs e)
        {

        }

        private void led1_Click(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmConnect);
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmModbus);

            if (frm == null)
            {
                FrmModbus nt = new FrmModbus();
                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }
            

        }


        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void textBox46_TextChanged(object sender, EventArgs e) { }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
                
            

         
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void ChartMain_Click(object sender, EventArgs e)
        {

        }

        private void lbTCView7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int setPoint;
            String value;
            String checkSum;
            if (!String.IsNullOrEmpty(textBox46.Text))
            {
                setPoint = Int32.Parse(textBox46.Text);
                value = FrmModbus.decimalHexadecimal(setPoint);

                checkSum = "CC 00 01 F0 02 00 " + value + " 12";

                textBox45.Text = checkSum;
            }

            textBox41.Text = textBox46.Text;
            textBox42.Text = textBox45.Text;
            textBox46.Text = "";
            listPanel[0].BringToFront();

        }


        private void updateChart(Chart chart) 
        {


            chart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart.ChartAreas["ChartArea1"].AxisX.Maximum = 30;
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 5;
            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = true;
            chart.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = true;
            //chart.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = true;
            chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "0.00";
           // chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Interval = 15;
            chart.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineWidth = 1;
            chart.ChartAreas["ChartArea1"].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;


            ChartArea CA = chart.ChartAreas[0];  // quick reference
            Series s = chart.Series[0];
           CA.AxisX.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;




            chart.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart.ChartAreas["ChartArea1"].AxisY.Maximum = 100;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 10;
            chart.ChartAreas["ChartArea1"].AxisY.MinorTickMark.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MinorTickMark.LineColor = Color.LightGray;

            chart.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = true;
            chart.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.LightGray;

            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Black;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int setPoint;
            String value;
            String checkSum;
            if (!String.IsNullOrEmpty(textBox49.Text))
            {
               setPoint = Int32.Parse(textBox49.Text);
               value = FrmModbus.decimalHexadecimal(setPoint);

                checkSum = "CC 00 01 F0 02 00 " + value + " 12";
             
                textBox45.Text = checkSum;
            }

            textBox47.Text = textBox49.Text;
            textBox49.Text = "";
            listPanel[2].BringToFront();
        }

        

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked) chartZone2.Series["T-13"].Enabled = true;
        //    else chartZone2.Series["T-13"].Enabled = false;

        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox2.Checked) chartZone2.Series["T-14"].Enabled = true;
        //    else chartZone2.Series["T-14"].Enabled = false;
        //}

        private void ChartMain_CustomizeLegend(object sender, CustomizeLegendEventArgs e)
        {
            e.LegendItems.Clear();
            foreach (var series in this.chartZone2.Series)
            {
                var legendItem = new LegendItem();
                legendItem.SeriesName = series.Name;
                legendItem.ImageStyle = LegendImageStyle.Rectangle;
                legendItem.BorderColor = Color.Transparent;
                legendItem.Name = series.Name + "_legend_item";

                int i = legendItem.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
                legendItem.Cells.Add(LegendCellType.Text, series.Name, ContentAlignment.MiddleCenter);

                if (series.Enabled)
                    legendItem.Color = series.Color;
                else
                    legendItem.Color = Color.FromArgb(100, series.Color);
                e.LegendItems.Add(legendItem);
            }

            foreach (LegendItem lit in e.LegendItems)
            {
                var cells = lit.Cells;
                cells[0].Margins = new Margins(30, 0, 0, 0);
                cells[1].Margins = new Margins(30, 0, 0, 200);
            }

        }



        private void chart1_CustomizeLegend(object sender, CustomizeLegendEventArgs e)
        {
            e.LegendItems.Clear();
            foreach (var series in this.chartZone1.Series)
            {
                var legendItem = new LegendItem();
                legendItem.SeriesName = series.Name;
                legendItem.ImageStyle = LegendImageStyle.Rectangle;
                legendItem.BorderColor = Color.Transparent;
                legendItem.Name = series.Name + "_legend_item";

                int i = legendItem.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
                legendItem.Cells.Add(LegendCellType.Text, series.Name, ContentAlignment.MiddleCenter);

                if (series.Enabled)
                    legendItem.Color = series.Color;
                else
                    legendItem.Color = Color.FromArgb(100, series.Color);
                e.LegendItems.Add(legendItem);
            }

            foreach (LegendItem lit in e.LegendItems)
            {
                var cells = lit.Cells;
                cells[0].Margins = new Margins(30, 0, 0, 100);
                cells[1].Margins = new Margins(30, 0, 0, 200);
            }
        }

        //private void checkBox25_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox25.Checked) chartZone1.Series["T-1"].Enabled = true;
        //    else chartZone1.Series["T-1"].Enabled = false;
        //}

        //private void checkBox24_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox24.Checked) chartZone1.Series["T-2"].Enabled = true;
        //    else chartZone1.Series["T-2"].Enabled = false;
        //}

        //private void checkBox23_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox23.Checked) chartZone1.Series["T-3"].Enabled = true;
        //    else chartZone1.Series["T-3"].Enabled = false;
        //}

        //private void checkBox22_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox22.Checked) chartZone1.Series["T-4"].Enabled = true;
        //    else chartZone1.Series["T-4"].Enabled = false;
        //}

        //private void checkBox21_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox21.Checked) chartZone1.Series["T-5"].Enabled = true;
        //    else chartZone1.Series["T-5"].Enabled = false;
        //}

        //private void checkBox20_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox20.Checked) chartZone1.Series["T-6"].Enabled = true;
        //    else chartZone1.Series["T-6"].Enabled = false;
        //}

        //private void checkBox19_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox19.Checked) chartZone1.Series["T-7"].Enabled = true;
        //    else chartZone1.Series["T-7"].Enabled = false;
        //}

        //private void checkBox18_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox18.Checked) chartZone1.Series["T-8"].Enabled = true;
        //    else chartZone1.Series["T-8"].Enabled = false;
        //}

        //private void checkBox17_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox17.Checked) chartZone1.Series["T-9"].Enabled = true;
        //    else chartZone1.Series["T-9"].Enabled = false;
        //}

        //private void checkBox16_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox16.Checked) chartZone1.Series["T-10"].Enabled = true;
        //    else chartZone1.Series["T-10"].Enabled = false;
        //}

        //private void checkBox15_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox15.Checked) chartZone1.Series["T-11"].Enabled = true;
        //    else chartZone1.Series["T-11"].Enabled = false;
        //}

        //private void checkBox14_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox14.Checked) chartZone1.Series["T-12"].Enabled = true;
        //    else chartZone1.Series["T-12"].Enabled = false;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmPopup);

            if (frm == null)
            {
                FrmPopup nt = new FrmPopup();
                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }
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

        private void bothZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewChartZone();
        }

        private void zone1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewChartZone(1);
            timerGhost.Start();
        }

        private void zone2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeViewChartZone(2);
        }



        double rt2 = 0;                              // Time X from chart
        double tempa2 = 0;
        private void timerGhost_Tick(object sender, EventArgs e)
        {
            ChartArea CA = chartZone2.ChartAreas[0];
            CA.CursorX.AutoScroll = true;

            rt2 = rt + 100;
            tempa2 = rt / 1000;


            chartView.Series["T-1"].Points.AddXY(tempa.ToString("0.0"), "20");

            chartView.ChartAreas[0].AxisY2.Maximum = Double.NaN;
            chartView.ChartAreas[0].AxisY2.Minimum = Double.NaN;
            chartView.ChartAreas[0].RecalculateAxesScale();




            if (chartView.Series["T-1"].Points.Count == 31)
            {

                chartView.Series["T-1"].Points.RemoveAt(0);
            }
        }


        



      
            

        }
    }
