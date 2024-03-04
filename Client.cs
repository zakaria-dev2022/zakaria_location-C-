using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    internal class Client
    {


        public string nom;
        public string prenom;
        public string cin;
        public string permis;
        public string tel;
        public string email;
        public string mot_de_passe;
        public string ph_cin;


        public Client(string nom, string prenom, string cin, string permis, string tel, string email, string mot_de_passe, string ph_cin)
        {
            //this.ClientId = ClientId;
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.permis = permis;
            this.tel = tel;
            this.email = email;
            this.mot_de_passe = mot_de_passe;
            this.ph_cin = ph_cin;
        }

        public static void ajouterclient(Client Client)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO client (nom, prenom,cin,permis,tel,email,mot_de_passe,ph_cin) VALUES (@Nom, @Prenom,@cin,@permis, @tel, @email, @mot_de_passe,@ph_cin)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@Nom", Client.nom);
                    command.Parameters.AddWithValue("@Prenom", Client.prenom);
                    command.Parameters.AddWithValue("@cin", Client.cin);
                    command.Parameters.AddWithValue("@permis", Client.permis);
                    command.Parameters.AddWithValue("@tel", Client.tel);
                    command.Parameters.AddWithValue("@email", Client.email);
                    command.Parameters.AddWithValue("@mot_de_passe", Client.mot_de_passe);
                    command.Parameters.AddWithValue("@ph_cin", Client.ph_cin);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Votre Client Bien Ajouter", "Zakaria Location");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void ModifierClient(Client Client, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE client SET nom = @Nom, prenom = @Prenom,cin = @cin,permis = @permis, tel = @tel, email = @email, mot_de_passe = @mot_de_passe, ph_cin = @ph_cin, WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@Nom", Client.nom);
                        command.Parameters.AddWithValue("@Prenom", Client.prenom);
                        command.Parameters.AddWithValue("@cin", Client.cin);
                        command.Parameters.AddWithValue("@permis", Client.permis);
                        command.Parameters.AddWithValue("@tel", Client.tel);
                        command.Parameters.AddWithValue("@email", Client.email);
                        command.Parameters.AddWithValue("@mot_de_passe", Client.mot_de_passe);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Zakaria Location");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}");
            }
        }


























    }
}
