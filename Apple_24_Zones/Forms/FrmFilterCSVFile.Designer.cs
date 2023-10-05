namespace Apple_24_Zones.Forms
{
    partial class FrmFilterCSVFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilterCSVFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRutaArchivoFiltrado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportFile = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHoraInicial = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutoInicial = new System.Windows.Forms.ComboBox();
            this.comboBoxHoraFinal = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutoFinal = new System.Windows.Forms.ComboBox();
            this.btnExportFile = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.IconClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 27);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // IconClose
            // 
            this.IconClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconClose.FlatAppearance.BorderSize = 0;
            this.IconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.IconClose.IconColor = System.Drawing.Color.White;
            this.IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconClose.IconSize = 30;
            this.IconClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconClose.Location = new System.Drawing.Point(233, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(37, 27);
            this.IconClose.TabIndex = 1;
            this.IconClose.UseVisualStyleBackColor = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 479);
            this.panel2.TabIndex = 91;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(265, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 479);
            this.panel3.TabIndex = 92;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 5);
            this.panel4.TabIndex = 93;
            // 
            // txtRutaArchivoFiltrado
            // 
            this.txtRutaArchivoFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivoFiltrado.Location = new System.Drawing.Point(36, 164);
            this.txtRutaArchivoFiltrado.Name = "txtRutaArchivoFiltrado";
            this.txtRutaArchivoFiltrado.ReadOnly = true;
            this.txtRutaArchivoFiltrado.Size = new System.Drawing.Size(193, 26);
            this.txtRutaArchivoFiltrado.TabIndex = 97;
            this.txtRutaArchivoFiltrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRutaArchivoFiltrado.TextChanged += new System.EventHandler(this.txtRutaArchivoFiltrado_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 28);
            this.label3.TabIndex = 96;
            this.label3.Text = "Path of the imported file:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImportFile
            // 
            this.btnImportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(220)))));
            this.btnImportFile.FlatAppearance.BorderSize = 0;
            this.btnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFile.ForeColor = System.Drawing.Color.White;
            this.btnImportFile.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnImportFile.IconColor = System.Drawing.Color.White;
            this.btnImportFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportFile.IconSize = 35;
            this.btnImportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportFile.Location = new System.Drawing.Point(69, 81);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(129, 36);
            this.btnImportFile.TabIndex = 114;
            this.btnImportFile.Text = "         Import Data";
            this.btnImportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportFile.UseVisualStyleBackColor = false;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(68, 224);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(129, 26);
            this.dateTimePickerInicial.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 117;
            this.label1.Text = "Date Start:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(68, 344);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(129, 26);
            this.dateTimePickerFinal.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 119;
            this.label2.Text = "Date End:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxHoraInicial
            // 
            this.comboBoxHoraInicial.FormattingEnabled = true;
            this.comboBoxHoraInicial.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxHoraInicial.Location = new System.Drawing.Point(68, 276);
            this.comboBoxHoraInicial.Name = "comboBoxHoraInicial";
            this.comboBoxHoraInicial.Size = new System.Drawing.Size(58, 21);
            this.comboBoxHoraInicial.TabIndex = 120;
            // 
            // comboBoxMinutoInicial
            // 
            this.comboBoxMinutoInicial.FormattingEnabled = true;
            this.comboBoxMinutoInicial.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinutoInicial.Location = new System.Drawing.Point(139, 276);
            this.comboBoxMinutoInicial.Name = "comboBoxMinutoInicial";
            this.comboBoxMinutoInicial.Size = new System.Drawing.Size(58, 21);
            this.comboBoxMinutoInicial.TabIndex = 121;
            // 
            // comboBoxHoraFinal
            // 
            this.comboBoxHoraFinal.FormattingEnabled = true;
            this.comboBoxHoraFinal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxHoraFinal.Location = new System.Drawing.Point(68, 396);
            this.comboBoxHoraFinal.Name = "comboBoxHoraFinal";
            this.comboBoxHoraFinal.Size = new System.Drawing.Size(58, 21);
            this.comboBoxHoraFinal.TabIndex = 122;
            // 
            // comboBoxMinutoFinal
            // 
            this.comboBoxMinutoFinal.FormattingEnabled = true;
            this.comboBoxMinutoFinal.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinutoFinal.Location = new System.Drawing.Point(139, 396);
            this.comboBoxMinutoFinal.Name = "comboBoxMinutoFinal";
            this.comboBoxMinutoFinal.Size = new System.Drawing.Size(58, 21);
            this.comboBoxMinutoFinal.TabIndex = 123;
            // 
            // btnExportFile
            // 
            this.btnExportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(220)))));
            this.btnExportFile.FlatAppearance.BorderSize = 0;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.ForeColor = System.Drawing.Color.White;
            this.btnExportFile.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnExportFile.IconColor = System.Drawing.Color.White;
            this.btnExportFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportFile.IconSize = 32;
            this.btnExportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.Location = new System.Drawing.Point(68, 440);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(129, 36);
            this.btnExportFile.TabIndex = 124;
            this.btnExportFile.Text = "          Export File";
            this.btnExportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.UseVisualStyleBackColor = false;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 28);
            this.label4.TabIndex = 125;
            this.label4.Text = "Filter data by date and time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 127;
            this.label6.Text = "HH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 128;
            this.label7.Text = "mm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "mm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 129;
            this.label8.Text = "HH";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmFilterCSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.comboBoxMinutoFinal);
            this.Controls.Add(this.comboBoxHoraFinal);
            this.Controls.Add(this.comboBoxMinutoInicial);
            this.Controls.Add(this.comboBoxHoraInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerInicial);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.txtRutaArchivoFiltrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFilterCSVFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Data";
            this.Load += new System.EventHandler(this.FrmFilterCSVFile_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IconClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRutaArchivoFiltrado;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnImportFile;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHoraInicial;
        private System.Windows.Forms.ComboBox comboBoxMinutoInicial;
        private System.Windows.Forms.ComboBox comboBoxHoraFinal;
        private System.Windows.Forms.ComboBox comboBoxMinutoFinal;
        private FontAwesome.Sharp.IconButton btnExportFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}