namespace Zakaria_Location
{
    partial class FormProfil
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
            this.label1 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.lb_msg = new System.Windows.Forms.Label();
            this.txtcmp = new System.Windows.Forms.TextBox();
            this.lb_cmp = new System.Windows.Forms.Label();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 100);
            this.panel2.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestion Des Profils";
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Teal;
            this.supprimer.Enabled = false;
            this.supprimer.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(738, 271);
            this.supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(194, 44);
            this.supprimer.TabIndex = 93;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(383, 139);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 26);
            this.txtid.TabIndex = 92;
            this.txtid.Visible = false;
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(78, 445);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(854, 247);
            this.tableau.TabIndex = 91;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Teal;
            this.modifier.Enabled = false;
            this.modifier.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(738, 140);
            this.modifier.Margin = new System.Windows.Forms.Padding(4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(194, 44);
            this.modifier.TabIndex = 90;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Teal;
            this.ajouter.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(738, 207);
            this.ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(194, 44);
            this.ajouter.TabIndex = 88;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msg.ForeColor = System.Drawing.Color.Red;
            this.lb_msg.Location = new System.Drawing.Point(369, 309);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(46, 20);
            this.lb_msg.TabIndex = 87;
            this.lb_msg.Text = "label2";
            this.lb_msg.Visible = false;
            // 
            // txtcmp
            // 
            this.txtcmp.BackColor = System.Drawing.Color.White;
            this.txtcmp.Location = new System.Drawing.Point(350, 334);
            this.txtcmp.Multiline = true;
            this.txtcmp.Name = "txtcmp";
            this.txtcmp.Size = new System.Drawing.Size(253, 26);
            this.txtcmp.TabIndex = 5;
            // 
            // lb_cmp
            // 
            this.lb_cmp.AutoSize = true;
            this.lb_cmp.BackColor = System.Drawing.Color.White;
            this.lb_cmp.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_cmp.ForeColor = System.Drawing.Color.Teal;
            this.lb_cmp.Location = new System.Drawing.Point(47, 327);
            this.lb_cmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cmp.Name = "lb_cmp";
            this.lb_cmp.Size = new System.Drawing.Size(287, 33);
            this.lb_cmp.TabIndex = 85;
            this.lb_cmp.Text = "Confirmer Mot De Passe ";
            // 
            // txtmp
            // 
            this.txtmp.BackColor = System.Drawing.Color.White;
            this.txtmp.Location = new System.Drawing.Point(350, 281);
            this.txtmp.Multiline = true;
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(253, 26);
            this.txtmp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(47, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 83;
            this.label3.Text = "Mot De Passe";
            // 
            // txte
            // 
            this.txte.BackColor = System.Drawing.Color.White;
            this.txte.Location = new System.Drawing.Point(350, 234);
            this.txte.Multiline = true;
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(253, 26);
            this.txte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 33);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(47, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 94;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(47, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 33);
            this.label5.TabIndex = 95;
            this.label5.Text = "Email";
            // 
            // txtp
            // 
            this.txtp.BackColor = System.Drawing.Color.White;
            this.txtp.Location = new System.Drawing.Point(350, 185);
            this.txtp.Multiline = true;
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(253, 26);
            this.txtp.TabIndex = 2;
            // 
            // txtn
            // 
            this.txtn.BackColor = System.Drawing.Color.White;
            this.txtn.Location = new System.Drawing.Point(350, 139);
            this.txtn.Multiline = true;
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(253, 26);
            this.txtn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 48);
            this.panel1.TabIndex = 118;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zakaria_Location.Properties.Resources.multiple_users_silhouette;
            this.pictureBox2.Location = new System.Drawing.Point(55, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // exit
            // 
            this.exit.Image = global::Zakaria_Location.Properties.Resources.cross;
            this.exit.Location = new System.Drawing.Point(906, 28);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(61, 52);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 49;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.txtcmp);
            this.Controls.Add(this.lb_cmp);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfil";
            this.Load += new System.EventHandler(this.FormProfil_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label lb_msg;
        private System.Windows.Forms.TextBox txtcmp;
        private System.Windows.Forms.Label lb_cmp;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox exit;
    }
}