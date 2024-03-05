using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    internal class Assistant
    {
        public string nom;
        public string prenom;
        public string email;
        public string mot_de_passe;

        public Assistant(string nom, string prenom, string email, string mot_de_passe)
        {
            //this.AssistantsId = AssistantsId;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.mot_de_passe = mot_de_passe;

        }

        public static void ajouterAssistant(Assistant assistant)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO assistant (nom, prenom,email,mot_de_passe) VALUES (@Nom, @Prenom,@email, @mot_de_passe)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@Nom", assistant.nom);
                    command.Parameters.AddWithValue("@Prenom", assistant.prenom);
                    command.Parameters.AddWithValue("@email", assistant.email);
                    command.Parameters.AddWithValue("@mot_de_passe", assistant.mot_de_passe);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Votre Employee Bien Ajouter", "Zakaria Location");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void ModifierAssistant(Assistant assistant,int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE assistant SET nom = @nom, prenom = @prenom,email = @email, mot_de_passe = @mot_de_passe WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@nom", assistant.nom);
                        command.Parameters.AddWithValue("@prenom", assistant.prenom);
                        command.Parameters.AddWithValue("@email", assistant.email);
                        command.Parameters.AddWithValue("@mot_de_passe", assistant.mot_de_passe);
                        command.Parameters.AddWithValue("@id",id);

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
