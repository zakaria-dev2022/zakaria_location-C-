using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    public partial class FormLocation : Form
    {
        public FormLocation()
        {
            InitializeComponent();
            
        }
        public void formattimepicker()
        {
            txtdd.MinDate = DateTime.Today;
            txtdf.MinDate = txtdd.Value.AddDays(2);
        }

        public int TransferTypeInt()
        {
            Utils.CloseConnection();
            DataTable dataTable = Utils.ObtenirDonnees("select id from voiture where matricule = '" + txtm.Text + "'");

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

        public void remplir_txttp()
        {
            Utils.CloseConnection();
            //remplir txttp depuis la base de donner
            DataTable dataTable = Utils.ObtenirDonnees("select * from voiture");
            foreach (DataRow row in dataTable.Rows)
            {
                string texte = row["matricule"].ToString(); // Remplacez "colonne_texte" par le nom de votre colonne
                //txttp.Items.AppendText(texte + Environment.NewLine);
                txtm.Items.Add(texte);

            }


        }
        public static int CalculerNombreDeJours(DateTime dateDebut, DateTime dateFin)
        {
            TimeSpan difference = dateFin - dateDebut;
            return difference.Days+1;
        }

        public void remplir_txtmt()
        {
            Utils.CloseConnection();
            //remplir txttp depuis la base de donner
            DataTable dataTable = Utils.ObtenirDonnees("select * from voiture  where matricule = '" + txtm.Text + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                string prix = row["prix"].ToString();
                //string texte = row["matricule"].ToString(); // Remplacez "colonne_texte" par le nom de votre colonne
                //txttp.Items.AppendText(texte + Environment.NewLine);
                //txtm.Items.Add(texte);
                int jour = CalculerNombreDeJours(txtdd.Value,txtdf.Value);
                //txtp.Text= jour.ToString();
                float m = float.Parse(prix) * jour;
                txtmt.Text = m.ToString();

            }


        }
        public int TransferTypeIntClient()
        {
            Utils.CloseConnection();
            DataTable dataTable = Utils.ObtenirDonnees("select id from client where cin = '" + txtnc.Text + "'");

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
            throw new Exception("Aucune donnée trouvée pour le type de produit : " + txtnc.Text);
        }

        public void remplir_txttp_client()
        {
            Utils.CloseConnection();
            //remplir txttp depuis la base de donner
            DataTable dataTable = Utils.ObtenirDonnees("select * from client");
            foreach (DataRow row in dataTable.Rows)
            {
                string texte = row["cin"].ToString(); // Remplacez "colonne_texte" par le nom de votre colonne
                //txttp.Items.AppendText(texte + Environment.NewLine);
                txtnc.Items.Add(texte);

            }


        }
        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("SELECT * FROM reservation  ");
            //DataTable dataTable = Utils.ObtenirDonnees("SELECT v.id as N°Voiture,m.type as Type_voiture,m.id as N°Marque,v.nom_voiture,v.matricule,v.type_boite_vitesse,v.type_carburant,v.model,v.prix,v.assurance,v.carte_grise,v.visite,v.ph_voiture\r\nFROM voiture v \r\nJOIN type_marque m on v.id_marque=m.id ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;
        }

        void nouveau()
        {
            Utils.CloseConnection();
            txtid.Text = "";
            txtid_cin.Text = "";
            txtid_matricule.Text = "";
            txtm.Text = "";
            txtnc.Text = "";
            txtmt.Text = "";
            txtdd.Value = DateTime.Today;
            txtdf.Value = DateTime.Today.AddDays(2);

        }

        private void FormLocation_Load(object sender, EventArgs e)
        {
            formattimepicker();
            remplir_txttp();
            remplir_txttp_client();
            remplir();
        }

        private void txtm_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = TransferTypeInt();
            txtid_matricule.Text = id.ToString();
            remplir_txtmt();
            
        }

        private void txtnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = TransferTypeIntClient();
            txtid_cin.Text = id.ToString();
        }

        private void txtdd_ValueChanged(object sender, EventArgs e)
        {
            formattimepicker();
            CalculerNombreDeJours(txtdd.Value,txtdf.Value);
            remplir_txtmt();
        }

        private void txtdf_ValueChanged(object sender, EventArgs e)
        {
            formattimepicker();
            CalculerNombreDeJours(txtdd.Value, txtdf.Value);
            remplir_txtmt();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            //*******************************************************probleme d'ajoute************************************
            Utils.CloseConnection();
            //int id_type_produit = TransferTypeInt();
            //txtid_marque.Text = id_type_produit.ToString();
            /*Reservation reservation = new Reservation(int.Parse(txtid_matricule.Text),int.Parse(txtid_cin.Text),Convert.ToDateTime(txtdd.Text),Convert.ToDateTime(txtdf.Text),int.Parse(txtm.Text));
            Reservation.ajouterReservation(reservation);
            nouveau();
            remplir();
            ajouter.Enabled = true;
            modifier.Enabled = false;
            //supprimer.Enabled = false;*/

            int voitureId = Convert.ToInt32(txtid_matricule.Text);
            int clientId = Convert.ToInt32(txtid_cin.Text);
            DateTime dateDebut = Convert.ToDateTime(txtdd.Text);
            DateTime dateFin = Convert.ToDateTime(txtdf.Text);
            int montant = Convert.ToInt32(txtm.Text);

            Reservation nouvelleReservation = new Reservation(voitureId, clientId, dateDebut, dateFin, montant);

            // Appeler la méthode pour ajouter la réservation à la base de données
           Reservation.ajouterReservation(nouvelleReservation);

        }
    }
}
