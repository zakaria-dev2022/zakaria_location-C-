using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Zakaria_Location
{
    internal class Utils
    {

        public static MySqlConnection cnx = new MySqlConnection("server=localhost;database=location;uid=root;password=");
        public static DataTable dataTable = new DataTable();



        public static void OpenConnection()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Closed)
                {
                    cnx.Open();
                    // Console.WriteLine("Connexion à la base de données ouverte avec succès.");
                    // MessageBox.Show("Connexion à la base de données ouverte avec succès.", "Zakaria Location");
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                //MessageBox.Show("Erreur lors de l'ouverture de la connexion : " + ex.Message, "Zakaria Location");
            }
        }

        // Méthode pour fermer la connexion
        public static void CloseConnection()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    cnx.Close();
                    //Console.WriteLine("Connexion à la base de données fermée avec succès.");
                    //MessageBox.Show("Connexion à la base de données fermer avec succès.", "Zakaria Location");
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
                // MessageBox.Show("Connexion à la base de données fermer avec succès.", "Zakaria Location");
            }
        }


        public static void SuprimerDonner(string table, string id)
        {
            try
            {
                {
                    cnx.Open();

                    string query = $"delete from {table} where id=  {id}";

                    //using (SqlCommand command = new SqlCommand(query,cnx))
                    MySqlCommand command = new MySqlCommand(query, cnx);
                    {
                        command.ExecuteNonQuery();
                        //Console.WriteLine($"La colonne {id} a été supprimée de la table {table} avec succès.");
                        //MessageBox.Show($"La colonne {id} a été supprimée de la table {table} avec succès.", "Zakaria Location");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la suppression de la colonne : {ex.Message}");
                // MessageBox.Show($"Erreur lors de la suppression de la colonne : {ex.Message}");
            }
        }



        public static DataTable ObtenirDonnees(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, cnx);

                {
                    cnx.Open();
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des données : {ex.Message}");
                MessageBox.Show($"Erreur lors de la récupération des données .{ex.Message}", "Zakaria Location");
            }

            return dataTable;
        }




        public static void NombreStatictique(string table, Label label)
        {
            try
            {
                OpenConnection(); // Ouvrir la connexion à la base de données

                string query = $"SELECT COUNT(*) FROM {table}"; // Requête SQL pour compter les employés

                MySqlCommand command = new MySqlCommand(query, cnx);
                int nombreEmployes = Convert.ToInt32(command.ExecuteScalar());

                // Remplissage de la Label avec le résultat de la requête
                label.Text = nombreEmployes.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message, "Zakaria Location");
            }
            finally
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close(); // Fermer la connexion à la base de données après utilisation
            }


        }
        /* public static void chartReservation(Chart chart)
         {
             try
             {
                 OpenConnection(); // Ouvrir la connexion à la base de données

                 string query = "SELECT MONTH(date_reservation) AS Mois, COUNT(*) AS NombreReservations " +
                                "FROM reservation " +
                                "WHERE YEAR(date_reservation) = YEAR(CURRENT_DATE()) " +
                 "GROUP BY MONTH(date_reservation)";

                 MySqlCommand command = new MySqlCommand(query, cnx);
                 MySqlDataReader reader = command.ExecuteReader();

                 // Effacer toutes les séries de données existantes dans le graphique
                 chart.Series.Clear();

                 // Ajouter une nouvelle série de données au graphique
                 chart.Series.Add("Nombre de réservations par mois");

                 // Ajouter les données récupérées à la série
                 while (reader.Read())
                 {
                     string mois = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(reader.GetInt32("Mois"));
                     int nombreReservations = reader.GetInt32("NombreReservations");
                     chart.Series["Nombre de réservations par mois"].Points.AddXY(mois, nombreReservations);
                 }

                 // Titre du graphique
                 chart.Titles.Add("Nombre de réservations effectuées chaque mois cette année");

                 // Actualiser le graphique
                 chart.Update();

                 reader.Close();
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                 MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message, "Zakaria Location");
             }
             finally
             {
                 if (cnx.State == System.Data.ConnectionState.Open)
                     cnx.Close(); // Fermer la connexion à la base de données après utilisation
             }


         }*/

        public static void AfficherImageAdmin(PictureBox pictureBox)
        {
            try
            {
                OpenConnection(); // Ouvrir la connexion à la base de données

                string query = "SELECT logo FROM admin WHERE id = @Id"; // Requête SQL pour récupérer le chemin de l'image de la table admin
                MySqlCommand command = new MySqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Id", 1); // Remplacer 1 par l'ID de l'admin dont vous voulez afficher l'image

                // Récupérer le chemin de l'image à partir de la base de données
                string imagePath = (string)command.ExecuteScalar();

                pictureBox.Load(@"C:\laragon\www\zakaria location\assets\img\logo\" + imagePath);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message, "Zakaria Location");
            }
            finally
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close(); // Fermer la connexion à la base de données après utilisation
            }
        }

        public static void NomApplication(Label label)
        {
            try
            {
                OpenConnection(); // Ouvrir la connexion à la base de données

                string query = "SELECT nom_app FROM admin WHERE id = @Id"; // Requête SQL pour récupérer le chemin de l'image de la table admin
                MySqlCommand command = new MySqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Id", 1); // Remplacer 1 par l'ID de l'admin dont vous voulez afficher l'image

                // Récupérer le chemin de l'image à partir de la base de données
                string nom_app = (string)command.ExecuteScalar();

                label.Text= nom_app;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message, "Zakaria Location");
            }
            finally
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close(); // Fermer la connexion à la base de données après utilisation
            }


        }


        public static void AfficherReservationsPourDemain(Label label)
        {
            try
            {
                OpenConnection(); // Ouvrir la connexion à la base de données

                // Obtenir la date de demain
                DateTime dateDemain = DateTime.Today.AddDays(1);

                // Formater la date de demain en une chaîne de caractères au format YYYY-MM-DD pour l'utiliser dans la requête SQL
                string dateDemainString = dateDemain.ToString("yyyy-MM-dd");

                // Requête SQL pour sélectionner toutes les réservations pour la date de demain
                string query = $"SELECT COUNT(*) FROM reservation WHERE DATE(date_reservation) = '{dateDemainString}'";

                MySqlCommand command = new MySqlCommand(query, cnx);
                int nombreReservations = Convert.ToInt32(command.ExecuteScalar());

                // Afficher le nombre de réservations dans la Label
                label.Text = nombreReservations.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message, "Zakaria Location");
            }
            finally
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close(); // Fermer la connexion à la base de données après utilisation
            }
        }



    }
}
