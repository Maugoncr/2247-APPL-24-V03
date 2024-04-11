using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidoriValveTest.Forms
{
    public partial class FrmVisualizadorCrystalReport : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmVisualizadorCrystalReport()
        {
            InitializeComponent();
        }
        private void FrmVisualizadorCrystalReport_Load(object sender, EventArgs e)
        {
        }
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Report as PDF";

            saveFileDialog.FileName = "Report ELEN II Exported at " + DateTime.Now.ToString("MM-dd-yyyy  HH-mm-ss");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReportDocument reportDocument = crystalReportViewer1.ReportSource as ReportDocument;

                    // Exporta el contenido de CrystalReportViewer a un archivo PDF
                    ExportOptions exportOptions = new ExportOptions();
                    exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    exportOptions.DestinationOptions = new DiskFileDestinationOptions { DiskFileName = saveFileDialog.FileName };

                    reportDocument.Export(exportOptions);

                    MessageBox.Show("Report successfully exported to PDF.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred when exporting the report to PDF " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
