using Apple_24_Zones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Apple_24_Zones.Forms
{
    public partial class FrmInformation : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmInformation()
        {
            InitializeComponent();
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInformation_Load(object sender, EventArgs e)
        {
            txtNotes.Text = Settings.Default.Notes;

            lbCountCool1.Text = Settings.Default.CountCool1.ToString();
            lbCountCool2.Text = Settings.Default.CountCool2.ToString();

            lbCountHeat1.Text = Settings.Default.CountHeat1.ToString(); 
            lbCountHeat2.Text = Settings.Default.CountHeat2.ToString();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the notes?", "Verification question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Settings.Default.Notes = "";
                txtNotes.Text = Settings.Default.Notes;
                Settings.Default.Save();
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNotes.Text))
            {
                Settings.Default.Notes = txtNotes.Text;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("There is nothing to save", "Advertisement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNotes_Enter(object sender, EventArgs e)
        {
            // Obtén la fecha y hora actual en el formato deseado
            string fechaActual = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

            // Verifica si el RichTextBox está vacío
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                // Si está vacío, simplemente agrega la fecha actual
                txtNotes.AppendText(fechaActual + " : ");
            }
            else
            {
                // Si no está vacío, verifica si la fecha actual ya está presente
                if (!txtNotes.Text.Contains(fechaActual))
                {
                    // Si la fecha actual no está presente, agrega un salto de línea y la fecha actual
                    txtNotes.AppendText("\n" + fechaActual + " : ");
                }
            }
        }
    }
}
