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
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("SELECT a.id as N°Employe,a.nom,a.prenom,a.email,a.mot_de_passe from assistant a ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;
           // tableau.Columns["ph_cin"].Visible = false;

        }

        void nouveau()
        {
            Utils.CloseConnection();
            txtn.Text = "";
            txtp.Text = "";
            txte.Text = "";
            txtmp.Text = "";
            txtcmp.Text = "";
            lb_msg.Visible= false;
            txtn.Focus();

        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (txtmp.Text==txtcmp.Text)
            {
            Utils.CloseConnection();
            Assistant assistant = new Assistant(txtn.Text, txtp.Text, txte.Text, txtmp.Text);
            Assistant.ajouterAssistant(assistant);
            nouveau();
            remplir();
            ajouter.Enabled = true;
            modifier.Enabled = false;
            supprimer.Enabled = false;
            }
            else
            {
                //MessageBox.Show("Mot De Passe Incorect", "Zakaria Location");
                lb_msg.Visible = true;
                lb_msg.Text = "Mot De Passe Incorect";
                txtcmp.Text="";
                txtcmp.Focus();
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (txtn.Text !="" && txtp.Text !="" && txte.Text !="" && txtmp.Text!="" && txtcmp.Text!="" &&  txtmp.Text == txtcmp.Text )
            {
                Utils.CloseConnection();
                Assistant assistant = new Assistant(txtn.Text, txtp.Text, txte.Text, txtmp.Text);
                int id = int.Parse(txtid.Text);
                Assistant.ModifierAssistant(assistant,id);
                nouveau();
                remplir();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
            else
            {
                //MessageBox.Show("Mot De Passe Incorect", "Zakaria Location");
                lb_msg.Visible = true;
                lb_msg.Text = "Les Donners Incorect";
            }
        } 

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°Employe"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txte.Text = row.Cells["email"].Value.ToString();
                txtmp.Text = row.Cells["mot_de_passe"].Value.ToString();
                txtcmp.Text = row.Cells["mot_de_passe"].Value.ToString();
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

        private void exit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer Ce Profil?", "Zakaria Location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("assistant", txtid.Text);
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
