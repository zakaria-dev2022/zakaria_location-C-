namespace Zakaria_Location
{
    partial class FormVoiture
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtbv = new System.Windows.Forms.TextBox();
            this.lb_cg = new System.Windows.Forms.Label();
            this.lb_v = new System.Windows.Forms.Label();
            this.txtmd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmt = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.lb_vt = new System.Windows.Forms.Label();
            this.lb_a = new System.Windows.Forms.Label();
            this.btn_v = new System.Windows.Forms.Button();
            this.btn_cg = new System.Windows.Forms.Button();
            this.btn_vt = new System.Windows.Forms.Button();
            this.btn_a = new System.Windows.Forms.Button();
            this.txtid_marque = new System.Windows.Forms.TextBox();
            this.assurance = new System.Windows.Forms.PictureBox();
            this.visite = new System.Windows.Forms.PictureBox();
            this.ph_voiture = new System.Windows.Forms.PictureBox();
            this.carte_grise = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ph_voiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte_grise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 833);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 48);
            this.panel2.TabIndex = 117;
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(48, 504);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(1250, 339);
            this.tableau.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 56);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gestion Des Voiture";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 80);
            this.panel1.TabIndex = 102;
            // 
            // txttc
            // 
            this.txttc.BackColor = System.Drawing.Color.White;
            this.txttc.Location = new System.Drawing.Point(238, 281);
            this.txttc.Margin = new System.Windows.Forms.Padding(4);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(190, 26);
            this.txttc.TabIndex = 135;
            // 
            // txtbv
            // 
            this.txtbv.BackColor = System.Drawing.Color.White;
            this.txtbv.Location = new System.Drawing.Point(239, 233);
            this.txtbv.Margin = new System.Windows.Forms.Padding(4);
            this.txtbv.Name = "txtbv";
            this.txtbv.Size = new System.Drawing.Size(190, 26);
            this.txtbv.TabIndex = 134;
            // 
            // lb_cg
            // 
            this.lb_cg.AutoSize = true;
            this.lb_cg.Location = new System.Drawing.Point(1040, 136);
            this.lb_cg.Name = "lb_cg";
            this.lb_cg.Size = new System.Drawing.Size(51, 20);
            this.lb_cg.TabIndex = 133;
            this.lb_cg.Text = "label9";
            this.lb_cg.Visible = false;
            // 
            // lb_v
            // 
            this.lb_v.AutoSize = true;
            this.lb_v.Location = new System.Drawing.Point(718, 169);
            this.lb_v.Name = "lb_v";
            this.lb_v.Size = new System.Drawing.Size(51, 20);
            this.lb_v.TabIndex = 132;
            this.lb_v.Text = "label7";
            this.lb_v.Visible = false;
            // 
            // txtmd
            // 
            this.txtmd.BackColor = System.Drawing.Color.White;
            this.txtmd.Location = new System.Drawing.Point(238, 326);
            this.txtmd.Margin = new System.Windows.Forms.Padding(4);
            this.txtmd.Name = "txtmd";
            this.txtmd.Size = new System.Drawing.Size(190, 26);
            this.txtmd.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(31, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 126;
            this.label3.Text = "Matricule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 28);
            this.label4.TabIndex = 129;
            this.label4.Text = "Boite Vitesse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(31, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 128;
            this.label2.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(31, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 130;
            this.label6.Text = "Type Carburant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(31, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 127;
            this.label7.Text = "Marque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(31, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 28);
            this.label8.TabIndex = 131;
            this.label8.Text = "Prix";
            // 
            // txtmt
            // 
            this.txtmt.BackColor = System.Drawing.Color.White;
            this.txtmt.Location = new System.Drawing.Point(239, 193);
            this.txtmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtmt.Name = "txtmt";
            this.txtmt.Size = new System.Drawing.Size(190, 26);
            this.txtmt.TabIndex = 118;
            // 
            // txtp
            // 
            this.txtp.BackColor = System.Drawing.Color.White;
            this.txtp.Location = new System.Drawing.Point(238, 369);
            this.txtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(190, 26);
            this.txtp.TabIndex = 121;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(319, 109);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(72, 26);
            this.txtid.TabIndex = 136;
            this.txtid.Visible = false;
            // 
            // txtm
            // 
            this.txtm.FormattingEnabled = true;
            this.txtm.Location = new System.Drawing.Point(238, 107);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(189, 28);
            this.txtm.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(31, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 28);
            this.label9.TabIndex = 139;
            this.label9.Text = "Nom Voiture";
            // 
            // txtnv
            // 
            this.txtnv.BackColor = System.Drawing.Color.White;
            this.txtnv.Location = new System.Drawing.Point(239, 149);
            this.txtnv.Margin = new System.Windows.Forms.Padding(4);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(190, 26);
            this.txtnv.TabIndex = 138;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Teal;
            this.ajouter.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(220, 421);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(186, 50);
            this.ajouter.TabIndex = 140;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Teal;
            this.modifier.Enabled = false;
            this.modifier.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(23, 421);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(186, 50);
            this.modifier.TabIndex = 141;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Teal;
            this.supprimer.Enabled = false;
            this.supprimer.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(426, 421);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(186, 50);
            this.supprimer.TabIndex = 142;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            // 
            // lb_vt
            // 
            this.lb_vt.AutoSize = true;
            this.lb_vt.Location = new System.Drawing.Point(740, 421);
            this.lb_vt.Name = "lb_vt";
            this.lb_vt.Size = new System.Drawing.Size(51, 20);
            this.lb_vt.TabIndex = 143;
            this.lb_vt.Text = "label9";
            this.lb_vt.Visible = false;
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(1040, 356);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(51, 20);
            this.lb_a.TabIndex = 144;
            this.lb_a.Text = "label9";
            this.lb_a.Visible = false;
            // 
            // btn_v
            // 
            this.btn_v.BackColor = System.Drawing.Color.Teal;
            this.btn_v.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_v.ForeColor = System.Drawing.Color.White;
            this.btn_v.Location = new System.Drawing.Point(690, 233);
            this.btn_v.Name = "btn_v";
            this.btn_v.Size = new System.Drawing.Size(156, 50);
            this.btn_v.TabIndex = 145;
            this.btn_v.Text = "Voiture";
            this.btn_v.UseVisualStyleBackColor = false;
            this.btn_v.Click += new System.EventHandler(this.btn_v_Click);
            // 
            // btn_cg
            // 
            this.btn_cg.BackColor = System.Drawing.Color.Teal;
            this.btn_cg.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cg.ForeColor = System.Drawing.Color.White;
            this.btn_cg.Location = new System.Drawing.Point(996, 230);
            this.btn_cg.Name = "btn_cg";
            this.btn_cg.Size = new System.Drawing.Size(156, 50);
            this.btn_cg.TabIndex = 146;
            this.btn_cg.Text = "Carte Grise";
            this.btn_cg.UseVisualStyleBackColor = false;
            this.btn_cg.Click += new System.EventHandler(this.btn_cg_Click);
            // 
            // btn_vt
            // 
            this.btn_vt.BackColor = System.Drawing.Color.Teal;
            this.btn_vt.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vt.ForeColor = System.Drawing.Color.White;
            this.btn_vt.Location = new System.Drawing.Point(680, 448);
            this.btn_vt.Name = "btn_vt";
            this.btn_vt.Size = new System.Drawing.Size(156, 50);
            this.btn_vt.TabIndex = 147;
            this.btn_vt.Text = "Visite";
            this.btn_vt.UseVisualStyleBackColor = false;
            this.btn_vt.Click += new System.EventHandler(this.btn_vt_Click);
            // 
            // btn_a
            // 
            this.btn_a.BackColor = System.Drawing.Color.Teal;
            this.btn_a.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a.ForeColor = System.Drawing.Color.White;
            this.btn_a.Location = new System.Drawing.Point(996, 448);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(156, 50);
            this.btn_a.TabIndex = 148;
            this.btn_a.Text = "Assurance";
            this.btn_a.UseVisualStyleBackColor = false;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // txtid_marque
            // 
            this.txtid_marque.BackColor = System.Drawing.Color.White;
            this.txtid_marque.Location = new System.Drawing.Point(334, 109);
            this.txtid_marque.Margin = new System.Windows.Forms.Padding(4);
            this.txtid_marque.Name = "txtid_marque";
            this.txtid_marque.ReadOnly = true;
            this.txtid_marque.Size = new System.Drawing.Size(72, 26);
            this.txtid_marque.TabIndex = 149;
            this.txtid_marque.Visible = false;
            // 
            // assurance
            // 
            this.assurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assurance.Location = new System.Drawing.Point(932, 307);
            this.assurance.Margin = new System.Windows.Forms.Padding(4);
            this.assurance.Name = "assurance";
            this.assurance.Size = new System.Drawing.Size(251, 134);
            this.assurance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assurance.TabIndex = 122;
            this.assurance.TabStop = false;
            // 
            // visite
            // 
            this.visite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visite.Location = new System.Drawing.Point(637, 306);
            this.visite.Margin = new System.Windows.Forms.Padding(4);
            this.visite.Name = "visite";
            this.visite.Size = new System.Drawing.Size(251, 135);
            this.visite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visite.TabIndex = 125;
            this.visite.TabStop = false;
            // 
            // ph_voiture
            // 
            this.ph_voiture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ph_voiture.Location = new System.Drawing.Point(637, 87);
            this.ph_voiture.Margin = new System.Windows.Forms.Padding(4);
            this.ph_voiture.Name = "ph_voiture";
            this.ph_voiture.Size = new System.Drawing.Size(251, 135);
            this.ph_voiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ph_voiture.TabIndex = 124;
            this.ph_voiture.TabStop = false;
            // 
            // carte_grise
            // 
            this.carte_grise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carte_grise.Location = new System.Drawing.Point(932, 87);
            this.carte_grise.Margin = new System.Windows.Forms.Padding(4);
            this.carte_grise.Name = "carte_grise";
            this.carte_grise.Size = new System.Drawing.Size(251, 135);
            this.carte_grise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carte_grise.TabIndex = 123;
            this.carte_grise.TabStop = false;
            // 
            // exit
            // 
            this.exit.Image = global::Zakaria_Location.Properties.Resources.cross;
            this.exit.Location = new System.Drawing.Point(1132, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(61, 52);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 46;
            this.exit.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zakaria_Location.Properties.Resources.sports_car__1_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 881);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.btn_vt);
            this.Controls.Add(this.btn_cg);
            this.Controls.Add(this.btn_v);
            this.Controls.Add(this.assurance);
            this.Controls.Add(this.visite);
            this.Controls.Add(this.ph_voiture);
            this.Controls.Add(this.carte_grise);
            this.Controls.Add(this.lb_a);
            this.Controls.Add(this.lb_vt);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnv);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtbv);
            this.Controls.Add(this.lb_cg);
            this.Controls.Add(this.lb_v);
            this.Controls.Add(this.txtmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmt);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtid_marque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVoiture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVoiture";
            this.Load += new System.EventHandler(this.FormVoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ph_voiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte_grise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtbv;
        private System.Windows.Forms.Label lb_cg;
        private System.Windows.Forms.Label lb_v;
        private System.Windows.Forms.TextBox txtmd;
        private System.Windows.Forms.PictureBox assurance;
        private System.Windows.Forms.PictureBox ph_voiture;
        private System.Windows.Forms.PictureBox visite;
        private System.Windows.Forms.PictureBox carte_grise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmt;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox txtm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label lb_vt;
        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.Button btn_v;
        private System.Windows.Forms.Button btn_cg;
        private System.Windows.Forms.Button btn_vt;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.TextBox txtid_marque;
    }
}