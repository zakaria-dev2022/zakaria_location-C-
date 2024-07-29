using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    internal class Reservation
    {
        public int voiture_id;
        public int client_id;
        public DateTime date_debut;
        public DateTime date_fin;
        public int montant;

        public Reservation(int voiture_id, int client_id, DateTime date_debut, DateTime date_fin, int montant)
        {
            //this.reservationsId = reservationsId;
            this.voiture_id = voiture_id;
            this.client_id = client_id;
            this.date_debut = date_debut;
            this.date_fin = date_fin;
            this.montant = montant;

        }


        public static void ajouterReservation(Reservation reservation)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO reservation (voiture_id,client_id,date_debut,date_fin,montant) VALUES (@voiture_id, @client_id,@date_debut,@date_fin,@montant)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@voiture_id", reservation.voiture_id);
                    command.Parameters.AddWithValue("@client_id", reservation.client_id);
                    command.Parameters.AddWithValue("@date_debut", reservation.date_debut);
                    command.Parameters.AddWithValue("@date_fin", reservation.date_fin);
                    command.Parameters.AddWithValue("@montant", reservation.montant);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Votre Client Bien Ajouter", "Zakaria Location");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void ModifierReservation(Reservation reservation,int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE reservation SET voiture_id = @voiture_id, client_id = @client_id,date_debut = @date_debut, date_fin = @date_fin,montant=@montant WHERE id =@id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@voiture_id", reservation.voiture_id);
                        command.Parameters.AddWithValue("@client_id", reservation.client_id);
                        command.Parameters.AddWithValue("@email", reservation.date_debut);
                        command.Parameters.AddWithValue("@mot_de_passe", reservation.date_fin);
                        command.Parameters.AddWithValue("@montant", reservation.montant);
                        command.Parameters.AddWithValue("@id", id);

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
