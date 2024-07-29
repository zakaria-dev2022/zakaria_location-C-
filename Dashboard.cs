using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Utils.NombreStatictique("client", lb_nc);
            Utils.NombreStatictique("voiture", lb_np);
            Utils.AfficherImageAdmin(logo);
            Utils.NomApplication(lb_na);
            Utils.nombreReclamation(lb_nr);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormVoiture emp = new FormVoiture();
            this.Hide();
            emp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormLocation emp = new FormLocation();
            this.Hide();
            emp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormClient emp = new FormClient();
            this.Hide();
            emp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormProfil emp = new FormProfil();
            this.Hide();
            emp.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Se Déconnecter??", "Gestion Location De Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin emp = new FormLogin();
            this.Hide();
            emp.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormSetting emp = new FormSetting();
            this.Hide();
            emp.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormCommentaire commentaire = new FormCommentaire();
            this.Hide();
            commentaire.Show();
        }
    }
}
