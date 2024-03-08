namespace Zakaria_Location
{
    partial class FormChargement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChargement));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.porssentage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lb_na = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // porssentage
            // 
            this.porssentage.AutoSize = true;
            this.porssentage.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.porssentage.ForeColor = System.Drawing.Color.White;
            this.porssentage.Location = new System.Drawing.Point(316, 421);
            this.porssentage.Name = "porssentage";
            this.porssentage.Size = new System.Drawing.Size(38, 37);
            this.porssentage.TabIndex = 10;
            this.porssentage.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chargement ";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(319, 103);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(353, 218);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // lb_na
            // 
            this.lb_na.AutoSize = true;
            this.lb_na.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_na.ForeColor = System.Drawing.Color.White;
            this.lb_na.Location = new System.Drawing.Point(393, 20);
            this.lb_na.Name = "lb_na";
            this.lb_na.Size = new System.Drawing.Size(45, 57);
            this.lb_na.TabIndex = 7;
            this.lb_na.Text = "z";
            // 
            // progress
            // 
            this.progress.ForeColor = System.Drawing.Color.Teal;
            this.progress.Location = new System.Drawing.Point(127, 470);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(810, 32);
            this.progress.TabIndex = 11;
            // 
            // FormChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1027, 544);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.porssentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lb_na);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChargement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChargement";
            this.Load += new System.EventHandler(this.FormChargement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label porssentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lb_na;
        private System.Windows.Forms.ProgressBar progress;
    }
}