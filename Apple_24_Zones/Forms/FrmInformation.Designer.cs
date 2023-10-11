namespace Apple_24_Zones.Forms
{
    partial class FrmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformation));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountHeat = new System.Windows.Forms.Label();
            this.lbCountCool = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.IconClose = new FontAwesome.Sharp.IconButton();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveNotes = new FontAwesome.Sharp.IconButton();
            this.btnDeleteNotes = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Heating cycle counter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cooling cycle counter:";
            // 
            // lbCountHeat
            // 
            this.lbCountHeat.AutoSize = true;
            this.lbCountHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCountHeat.ForeColor = System.Drawing.Color.White;
            this.lbCountHeat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCountHeat.Location = new System.Drawing.Point(170, 53);
            this.lbCountHeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountHeat.Name = "lbCountHeat";
            this.lbCountHeat.Size = new System.Drawing.Size(15, 16);
            this.lbCountHeat.TabIndex = 29;
            this.lbCountHeat.Text = "0";
            // 
            // lbCountCool
            // 
            this.lbCountCool.AutoSize = true;
            this.lbCountCool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCountCool.ForeColor = System.Drawing.Color.White;
            this.lbCountCool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCountCool.Location = new System.Drawing.Point(170, 78);
            this.lbCountCool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountCool.Name = "lbCountCool";
            this.lbCountCool.Size = new System.Drawing.Size(15, 16);
            this.lbCountCool.TabIndex = 30;
            this.lbCountCool.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IconClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 36);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 232;
            this.label3.Text = "ELEN II SOFTWARE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.IconClose.Location = new System.Drawing.Point(752, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(35, 36);
            this.IconClose.TabIndex = 41;
            this.IconClose.UseVisualStyleBackColor = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 175);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(763, 346);
            this.txtNotes.TabIndex = 32;
            this.txtNotes.Text = "";
            this.txtNotes.Enter += new System.EventHandler(this.txtNotes_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(352, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "NOTES";
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.BackColor = System.Drawing.Color.Gray;
            this.btnSaveNotes.FlatAppearance.BorderSize = 0;
            this.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNotes.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveNotes.IconColor = System.Drawing.Color.White;
            this.btnSaveNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveNotes.IconSize = 30;
            this.btnSaveNotes.Location = new System.Drawing.Point(740, 527);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(35, 36);
            this.btnSaveNotes.TabIndex = 42;
            this.btnSaveNotes.UseVisualStyleBackColor = false;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteNotes.FlatAppearance.BorderSize = 0;
            this.btnDeleteNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotes.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteNotes.IconColor = System.Drawing.Color.White;
            this.btnDeleteNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNotes.IconSize = 25;
            this.btnDeleteNotes.Location = new System.Drawing.Point(684, 527);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(35, 36);
            this.btnDeleteNotes.TabIndex = 43;
            this.btnDeleteNotes.UseVisualStyleBackColor = false;
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(664, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ranges to use";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(592, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "85 °C   -- Heating --  27 °C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(625, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "26 °C   -- RT --  21 °C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(601, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "20 °C   -- Cooling --  5 °C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(170, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(170, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(13, 153);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cooling cycle counter:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(13, 128);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Heating cycle counter:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(13, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Zone 2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(13, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Zone 1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(787, 582);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteNotes);
            this.Controls.Add(this.btnSaveNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCountCool);
            this.Controls.Add(this.lbCountHeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformation";
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountHeat;
        private System.Windows.Forms.Label lbCountCool;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IconClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnSaveNotes;
        private FontAwesome.Sharp.IconButton btnDeleteNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}