using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Apple_24_Zones.Forms
{
    public partial class FrmFilterCSVFile : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmFilterCSVFile()
        {
            InitializeComponent();
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string elenIISoftwarePath = Path.Combine(documentsPath, "ELEN II SOFTWARE");

                if (Directory.Exists(elenIISoftwarePath))
                    openFileDialog.InitialDirectory = elenIISoftwarePath;
                else
                    openFileDialog.InitialDirectory = documentsPath;

                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta seleccionada y guárdala en un campo de texto
                    string rutaArchivoSeleccionado = openFileDialog.FileName;
                    txtRutaArchivoFiltrado.Text = rutaArchivoSeleccionado;
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtRutaArchivoFiltrado_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRutaArchivoFiltrado.Text))
            {
                btnExportFile.Enabled = true;
            }
            else
            {
                btnExportFile.Enabled = false;
            }
        }

        private void FrmFilterCSVFile_Load(object sender, EventArgs e)
        {
            btnExportFile.Enabled = false;
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaArchivo = txtRutaArchivoFiltrado.Text;
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("The file does not exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                // Resto del código para procesar el archivo y filtrar los datos
                DateTime fechaInicial = dateTimePickerInicial.Value.Date + ObtenerHoraDesdeComboBox(comboBoxHoraInicial, comboBoxMinutoInicial);
                DateTime fechaFinal = dateTimePickerFinal.Value.Date + ObtenerHoraDesdeComboBox(comboBoxHoraFinal, comboBoxMinutoFinal);

                List<string> lineasFiltradas = new List<string>();

                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string linea;
                    bool primeraLinea = true;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (primeraLinea)
                        {
                            primeraLinea = false;
                            lineasFiltradas.Add(linea);
                            continue;  // Ignorar la primera línea (encabezado)
                        }

                        string[] partes = linea.Split(',');
                        DateTime fechaHora = DateTime.ParseExact(partes[0] + " " + partes[1], "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                        if (fechaHora >= fechaInicial && fechaHora <= fechaFinal)
                            lineasFiltradas.Add(linea);
                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    string defaultFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ELEN II SOFTWARE", "RECORD FILTERED");
                    Directory.CreateDirectory(defaultFolderPath);  // Crear subcarpetas si no existen

                    saveFileDialog.InitialDirectory = defaultFolderPath;
                    saveFileDialog.FileName = Path.GetFileNameWithoutExtension(rutaArchivo) + " FILTERED FROM " + fechaInicial.ToString("MM-dd-yyyy HH-mm") + " TO " + fechaFinal.ToString("MM-dd-yyyy HH-mm");
                    saveFileDialog.DefaultExt = ".txt";
                    saveFileDialog.Filter = "Archivos de texto|*.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(saveFileDialog.FileName, lineasFiltradas);
                        MessageBox.Show("Filtered file saved successfully", "Successful Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TimeSpan ObtenerHoraDesdeComboBox(ComboBox horaComboBox, ComboBox minutoComboBox)
        {
            int hora = Convert.ToInt32(horaComboBox.SelectedItem);
            int minuto = Convert.ToInt32(minutoComboBox.SelectedItem);

            return new TimeSpan(hora, minuto, 0);
        }
    }
}
