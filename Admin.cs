using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    internal class Admin
    {

        public string nom;
        public string prenom;
        public string email;
        public string mot_de_passe;
        public string nom_app;
        public string logo;

        public Admin(string nom, string prenom, string email, string mot_de_passe, string nom_app, string logo)
        {
            //this.AdminsId = AdminsId;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.mot_de_passe = mot_de_passe;
            this.nom_app = nom_app;
            this.logo = logo;

        }

        public static void ModifierAdmin(Admin Admin)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE Admin SET nom = @nom, prenom = @prenom,login = @email, mot_de_passe = @mot_de_passe,nom_app=@nom_app,logo = @logo WHERE id =1";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@nom", Admin.nom);
                        command.Parameters.AddWithValue("@prenom", Admin.prenom);
                        command.Parameters.AddWithValue("@email", Admin.email);
                        command.Parameters.AddWithValue("@mot_de_passe", Admin.mot_de_passe);
                        command.Parameters.AddWithValue("@nom_app", Admin.nom_app);
                        command.Parameters.AddWithValue("@logo", Admin.logo);
                        //command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Zakaria Location");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}", "Zakaria Location");
            }
        }


    }
}
