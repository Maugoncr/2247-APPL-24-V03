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
            lbCountHeat.Text = Settings.Default.CountHeat.ToString();
            lbCountCool.Text = Settings.Default.CountCool.ToString();
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
    }
}
