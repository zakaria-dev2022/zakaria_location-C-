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
            DataTable dataTable = Utils.ObtenirDonnees("SELECT c.id as N°Client, c.nom,c.prenom,c.cin,c.permis,c.tel,c.email,c.mot_de_passe,c.ph_cin from client c ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;
            tableau.Columns["ph_cin"].Visible = false;

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

        private void modifier_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "" && txtp.Text != "" && txtnc.Text != "" && txtnp.Text != "" && txtt.Text != "" && txte.Text != "" && txtmp.Text != "" && lb_cin.Text != "")
            {
                Client client = new Client(txtn.Text, txtp.Text, txtnc.Text, txtnp.Text, txtt.Text, txte.Text, txtmp.Text, lb_cin.Text);
                int id = int.Parse(txtid.Text);
                Client.ModifierClient(client,id);
                nouveau();
                remplir();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°Client"].Value.ToString();
                //txtid_marque.Text = row.Cells["N°Marque"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txtnc.Text = row.Cells["cin"].Value.ToString();
                txtnp.Text = row.Cells["permis"].Value.ToString();
                txtt.Text = row.Cells["tel"].Value.ToString();
                txte.Text = row.Cells["email"].Value.ToString();
                txtmp.Text = row.Cells["mot_de_passe"].Value.ToString();
                lb_cin.Text = row.Cells["ph_cin"].Value.ToString();
                ph_cin.Image = Image.FromFile(@"C:\laragon\www\zakaria location\assets\img\clients\" + lb_cin.Text);
                ajouter.Enabled = false;
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Zakaria Location");
                txtid.Text = "";
                nouveau();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void txtnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            remplir();

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer Ce Client?", "Zakaria Location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("client", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Zakaria Location");
                remplir();
                nouveau();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }
    }
}
