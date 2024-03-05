using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Zakaria_Location
{
    public partial class FormVoiture : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public FormVoiture()
        {
            InitializeComponent();
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                ph_voiture.Image = img;
                lb_v.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtmt.Text + " De Type " + txtnv.Text + typeFile;
                chemin = lb_v.Text ;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\zakaria location\assets\img\voiture\" + chemin);

            }
        }


        private void btn_cg_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                carte_grise.Image = img;
                lb_cg.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtmt.Text + " De Type " + txtnv.Text + typeFile;
                chemin = lb_cg.Text;
                //lb_cg.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\zakaria location\assets\img\carte_grise\" + chemin);

            }
        }

        private void btn_vt_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                visite.Image = img;
                lb_vt.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtmt.Text + " De Type " + txtnv.Text + typeFile;
                chemin = lb_vt.Text;
                //lb_vt.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\zakaria location\assets\img\visite\" + chemin);

            }
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                assurance.Image = img;
                lb_a.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtmt.Text + " De Type " + txtnv.Text + typeFile;
                 chemin=lb_a.Text;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\zakaria location\assets\img\assurance\" + chemin);

            }
        }



        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("SELECT v.id as N°Voiture,m.type as Type_voiture,m.id as N°Marque,v.nom_voiture,v.matricule,v.type_boite_vitesse,v.type_carburant,v.model,v.prix,v.assurance,v.carte_grise,v.visite,v.ph_voiture\r\nFROM voiture v \r\nJOIN type_marque m on v.id_marque=m.id ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;
            tableau.Columns["N°Marque"].Visible = false;
            tableau.Columns["assurance"].Visible = false;
            tableau.Columns["carte_grise"].Visible = false;
            tableau.Columns["visite"].Visible = false;
            tableau.Columns["ph_voiture"].Visible = false;
        }

        public void remplir_txttp()
        {
            Utils.CloseConnection();
            //remplir txttp depuis la base de donner
            DataTable dataTable = Utils.ObtenirDonnees("select * from type_marque");
            foreach (DataRow row in dataTable.Rows)
            {
                string texte = row["type"].ToString(); // Remplacez "colonne_texte" par le nom de votre colonne
                //txttp.Items.AppendText(texte + Environment.NewLine);
                txtm.Items.Add(texte);

            }


        }

        void nouveau()
        {
            Utils.CloseConnection();
            txtid.Text = "";
            txtid_marque.Text = "";
            txtm.Text = "";
            txtnv.Text = "";
            txtmt.Text = "";
            txtbv.Text = "";
            txttc.Text = "";
            txtm.Text = "";
            txtmd.Text = "";
            txtp.Text = "";
            lb_v.Text = "";
            lb_cg.Text = "";
            lb_vt.Text = "";
            lb_a.Text = "";
            ph_voiture.Image = null;
            assurance.Image = null;
            carte_grise.Image = null;
            visite.Image = null;
            txtnv.Focus();

        }

        private void FormVoiture_Load(object sender, EventArgs e)
        {
            remplir();
            remplir_txttp();
            
        }
        public int TransferTypeInt()
        {
            Utils.CloseConnection();
            DataTable dataTable = Utils.ObtenirDonnees("select id from type_marque where type = '" + txtm.Text + "'");

            if (dataTable.Rows.Count > 0)
            {
                // Si des données ont été retournées par la requête
                int id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                //Console.WriteLine("ID récupéré : " + id);
                //MessageBox.Show("ID récupéré : " + id);
                //txttp.Text = id.ToString();
                return id;
                // Vous pouvez maintenant utiliser la variable "id" comme vous le souhaitez
            }

            // S'il n'y a aucune donnée retournée, vous pouvez retourner une valeur par défaut ou jeter une exception, selon votre cas.
            throw new Exception("Aucune donnée trouvée pour le type de produit : " + txtm.Text);
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            int id_type_produit = TransferTypeInt();
            txtid_marque.Text=id_type_produit.ToString();
            Voiture voiture = new Voiture(int.Parse(txtid_marque.Text), txtnv.Text,txtmt.Text,txtbv.Text,txttc.Text, int.Parse(txtmd.Text), float.Parse(txtp.Text),lb_a.Text,lb_cg.Text,lb_vt.Text,lb_v.Text);
            Voiture.ajoutervoiture(voiture);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            ajouter.Enabled = true;
            //pictureBox2.Enabled = true;
            modifier.Enabled = false;
            supprimer.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard=new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°Voiture"].Value.ToString();
                txtid_marque.Text = row.Cells["N°Marque"].Value.ToString();
                txtnv.Text = row.Cells["nom_voiture"].Value.ToString();
                txtmt.Text = row.Cells["matricule"].Value.ToString();
                txtbv.Text = row.Cells["type_boite_vitesse"].Value.ToString();
                txttc.Text = row.Cells["type_carburant"].Value.ToString();
                txtm.Text = row.Cells["type_voiture"].Value.ToString();
                txtmd.Text = row.Cells["model"].Value.ToString();
                txtp.Text = row.Cells["prix"].Value.ToString();
                lb_a.Text = row.Cells["assurance"].Value.ToString();
                lb_cg.Text = row.Cells["carte_grise"].Value.ToString();
                lb_v.Text = row.Cells["ph_voiture"].Value.ToString();
                lb_vt.Text = row.Cells["visite"].Value.ToString();
                assurance.Image = Image.FromFile(@"C:\laragon\www\zakaria location\assets\img\assurance\" + lb_a.Text);
                carte_grise.Image = Image.FromFile(@"C:\laragon\www\zakaria location\assets\img\carte_grise\" + lb_cg.Text);
                ph_voiture.Image = Image.FromFile(@"C:\laragon\www\zakaria location\assets\img\voiture\" + lb_v.Text);
                visite.Image = Image.FromFile(@"C:\laragon\www\zakaria location\assets\img\visite\" + lb_vt.Text);
                ajouter.Enabled = false;
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Restaurantly");
                txtid.Text = "";
                nouveau();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (txtnv.Text != "" && txtmt.Text != "" && txtbv.Text != "" && txttc.Text != "" && txtm.Text != "" && txtmd.Text != "" && txtp.Text != "" && assurance.Image != null && ph_voiture.Image != null && visite.Image != null && carte_grise.Image != null)
            {
                Voiture voiture = new Voiture(int.Parse(txtid_marque.Text), txtnv.Text, txtmt.Text, txtbv.Text, txttc.Text, int.Parse(txtmd.Text), float.Parse(txtp.Text), lb_a.Text, lb_cg.Text, lb_vt.Text, lb_v.Text);
                int id = int.Parse(txtid.Text);
                Voiture.ModifierVoiture(voiture,id);
                nouveau();
                remplir();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }


        private void txtm_SelectedIndexChanged(object sender, EventArgs e)
        {
           int id= TransferTypeInt();
            txtid_marque.Text= id.ToString();
        }
    }
}
