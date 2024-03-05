using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    public partial class FormClient : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public FormClient()
        {
            InitializeComponent();
        }


        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from client ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        void nouveau()
        {
            Utils.CloseConnection();
            txtn.Text = "";
            txtp.Text = "";
            txtnc.Text = "";
            txtnp.Text = "";
            txtt.Text = "";
            txte.Text = "";
            txtmp.Text = "";
            lb_cin.Text = "";
            ph_cin.Image = null;
            txtn.Focus();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();            
            Client client = new Client(txtn.Text, txtp.Text, txtnc.Text,txtnp.Text, txtt.Text, txte.Text,txtmp.Text, lb_cin.Text);
            Client.ajouterclient(client);
             nouveau();
            remplir();
            ajouter.Enabled = true;
            modifier.Enabled = false;
            supprimer.Enabled = false;
        }

        private void btncr_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                ph_cin.Image = img;
                lb_cin.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtnc.Text +  typeFile;
                chemin = lb_cin.Text;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\zakaria location\assets\img\clients\" + chemin);

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard= new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
