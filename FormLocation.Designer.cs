namespace Zakaria_Location
{
    partial class FormLocation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid_matricule = new System.Windows.Forms.TextBox();
            this.txtid_cin = new System.Windows.Forms.TextBox();
            this.txtdd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdf = new System.Windows.Forms.DateTimePicker();
            this.txtmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 102);
            this.panel1.TabIndex = 120;
            // 
            // exit
            // 
            this.exit.Image = global::Zakaria_Location.Properties.Resources.cross;
            this.exit.Location = new System.Drawing.Point(918, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(78, 59);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 46;
            this.exit.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(139, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(597, 56);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gestion Des Commentaire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zakaria_Location.Properties.Resources.email__2_;
            this.pictureBox1.Location = new System.Drawing.Point(40, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 663);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 48);
            this.panel2.TabIndex = 122;
            // 
            // txtm
            // 
            this.txtm.FormattingEnabled = true;
            this.txtm.Location = new System.Drawing.Point(243, 95);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(189, 28);
            this.txtm.TabIndex = 139;
            this.txtm.SelectedIndexChanged += new System.EventHandler(this.txtm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(65, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 138;
            this.label3.Text = "Matricule";
            // 
            // txtnc
            // 
            this.txtnc.FormattingEnabled = true;
            this.txtnc.Location = new System.Drawing.Point(243, 138);
            this.txtnc.Name = "txtnc";
            this.txtnc.Size = new System.Drawing.Size(189, 28);
            this.txtnc.TabIndex = 141;
            this.txtnc.SelectedIndexChanged += new System.EventHandler(this.txtnc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(65, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 140;
            this.label1.Text = "N° Cin";
            // 
            // txtid_matricule
            // 
            this.txtid_matricule.BackColor = System.Drawing.Color.White;
            this.txtid_matricule.Location = new System.Drawing.Point(482, 106);
            this.txtid_matricule.Margin = new System.Windows.Forms.Padding(4);
            this.txtid_matricule.Name = "txtid_matricule";
            this.txtid_matricule.Size = new System.Drawing.Size(72, 26);
            this.txtid_matricule.TabIndex = 150;
            // 
            // txtid_cin
            // 
            this.txtid_cin.BackColor = System.Drawing.Color.White;
            this.txtid_cin.Location = new System.Drawing.Point(482, 149);
            this.txtid_cin.Margin = new System.Windows.Forms.Padding(4);
            this.txtid_cin.Name = "txtid_cin";
            this.txtid_cin.Size = new System.Drawing.Size(72, 26);
            this.txtid_cin.TabIndex = 151;
            // 
            // txtdd
            // 
            this.txtdd.Location = new System.Drawing.Point(243, 256);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(268, 26);
            this.txtdd.TabIndex = 152;
            this.txtdd.ValueChanged += new System.EventHandler(this.txtdd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(65, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 153;
            this.label2.Text = "Date Début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(65, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 155;
            this.label4.Text = "Date Fin";
            // 
            // txtdf
            // 
            this.txtdf.Location = new System.Drawing.Point(243, 301);
            this.txtdf.Name = "txtdf";
            this.txtdf.Size = new System.Drawing.Size(268, 26);
            this.txtdf.TabIndex = 154;
            this.txtdf.ValueChanged += new System.EventHandler(this.txtdf_ValueChanged);
            // 
            // txtmt
            // 
            this.txtmt.Location = new System.Drawing.Point(243, 345);
            this.txtmt.Name = "txtmt";
            this.txtmt.ReadOnly = true;
            this.txtmt.Size = new System.Drawing.Size(189, 26);
            this.txtmt.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(65, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 157;
            this.label6.Text = "Montant";
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(70, 415);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(926, 229);
            this.tableau.TabIndex = 158;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(561, 160);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(97, 26);
            this.txtid.TabIndex = 159;
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Teal;
            this.modifier.Enabled = false;
            this.modifier.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(722, 279);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(186, 50);
            this.modifier.TabIndex = 161;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Teal;
            this.ajouter.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(722, 193);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(186, 50);
            this.ajouter.TabIndex = 160;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // FormLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 711);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdd);
            this.Controls.Add(this.txtnc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtid_cin);
            this.Controls.Add(this.txtid_matricule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLocation";
            this.Load += new System.EventHandler(this.FormLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txtm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid_matricule;
        private System.Windows.Forms.TextBox txtid_cin;
        private System.Windows.Forms.DateTimePicker txtdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtdf;
        private System.Windows.Forms.TextBox txtmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
    }
}