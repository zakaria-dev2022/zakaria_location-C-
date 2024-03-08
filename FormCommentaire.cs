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
    public partial class FormCommentaire : Form
    {
        public FormCommentaire()
        {
            InitializeComponent();
        }

        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select m.id AS N°Message,m.type_message,m.commentaire, c.nom,c.prenom ,c.email from message m join client c on m.client_id = c.id \r\n\r\n");
            //DataTable dataTable = Utils.ObtenirDonnees("select nom,prenom,cin,adresse,date_naissance,poste from employe");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        void nouveau()
        {
            txtn.Text = "";
            txtp.Text = "";
            txte.Text = "";
            txttm.Text = "";
            txtm.Text = "";
            txtid.Text = "";
            modifier.Enabled = false;
            supprimer.Enabled = false;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se Message?", "Zakaria Location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("message", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Zakaria Location");
                //Connection.CloseConnection();
                remplir();
                nouveau();
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
                txtid.Text = row.Cells["N°Message"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txte.Text = row.Cells["email"].Value.ToString();
                txttm.Text = row.Cells["type_message"].Value.ToString();
                txtm.Text = row.Cells["commentaire"].Value.ToString();
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Zakaria Location");
                txtid.Text = "";
                nouveau();
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (txttm.Text != "" && txtm.Text != "")
            {
                Message message = new Message();
                int id = int.Parse(txtid.Text);
                Message.ModifierMessage(txttm.Text, txtm.Text, id);
                nouveau();
                remplir();
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void FormCommentaire_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
