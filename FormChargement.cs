using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    public partial class FormChargement : Form
    {
        public FormChargement()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            p++;
            progress.Value = p;
            porssentage.Text = p.ToString() + " %";
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                FormLogin cnx = new FormLogin();
                this.Hide();
                cnx.Show();
            }


        }

        private void FormChargement_Load(object sender, EventArgs e)
        {
            Utils.obtenirNomApp(lb_na);
            Utils.AfficherImageAdmin(logo);
        }
    }
}
