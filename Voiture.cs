using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    internal class Voiture
    {

        public int id_marque;
        public string nom_voiture;
        public string matricule;
        public string type_boite_vitesse;
        public string type_carburant;
        public int model;
        public float prix;
        public string assurance;
        public string carte_grise;
        public string visite;
        public string ph_voiture;


        public Voiture(int id_marque,string nom_voiture, string matricule, string type_boite_vitesse, string type_carburant, int model,float prix, string assurance, string carte_grise, string visite, string ph_voiture)
        {
            this.id_marque = id_marque;
            this.nom_voiture = nom_voiture;
            this.matricule = matricule;
            this.type_boite_vitesse = type_boite_vitesse;
            this.type_carburant = type_carburant;
            this.model = model;
            this.prix = prix;
            this.assurance = assurance;
            this.carte_grise = carte_grise;
            this.visite = visite;
            this.ph_voiture=ph_voiture;

        }

        public static void ajoutervoiture(Voiture voiture)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO voiture (id_marque,nom_voiture,matricule,type_boite_vitesse,type_carburant,model,prix,assurance,carte_grise,visite,ph_voiture) VALUES (@id_marque,@nom_voiture,@matricule,@type_boite_vitesse,@type_carburant,@model,@prix,@assurance,@carte_grise,@visite,@ph_voiture)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@id_marque", voiture.id_marque);
                    command.Parameters.AddWithValue("@nom_voiture", voiture.nom_voiture);
                    command.Parameters.AddWithValue("@matricule", voiture.matricule);
                    command.Parameters.AddWithValue("@type_boite_vitesse", voiture.type_boite_vitesse);
                    command.Parameters.AddWithValue("@type_carburant", voiture.type_carburant);
                    command.Parameters.AddWithValue("@model", voiture.model);
                    command.Parameters.AddWithValue("@prix", voiture.prix);
                    command.Parameters.AddWithValue("@assurance", voiture.assurance);
                    command.Parameters.AddWithValue("@carte_grise", voiture.carte_grise);
                    command.Parameters.AddWithValue("@visite", voiture.visite);
                    command.Parameters.AddWithValue("@ph_voiture", voiture.ph_voiture);


                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success", " Zakaria Location");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ", " Zakaria Location");
            }
        }
        public static void ajouterTypevoiture(string type)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO type_Voiture (type) VALUES (@type)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@type", type);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ajouter Le Type " + type + " avec success", " Zakaria Location");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ", " Zakaria Location");
            }
        }

        public static void ModifierVoiture(Voiture voiture, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE voiture SET id_marque = @id_marque,nom_voiture = @nom_voiture,matricule = @matricule,type_boite_vitesse=@type_boite_vitesse,type_carburant=@type_carburant,mode=@model ,prix = @prix,assurance = @assurance,carte_grise=@carte_grise,visite=@visite,ph_voiture=@ph_voiture WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@id_marque", voiture.id_marque);
                        command.Parameters.AddWithValue("@nom_voiture", voiture.nom_voiture);
                        command.Parameters.AddWithValue("@matricule", voiture.matricule);
                        command.Parameters.AddWithValue("@type_boite_vitesse", voiture.type_boite_vitesse);
                        command.Parameters.AddWithValue("@type_carburant", voiture.type_carburant);
                        command.Parameters.AddWithValue("@model", voiture.model);
                        command.Parameters.AddWithValue("@prix", voiture.prix);
                        command.Parameters.AddWithValue("@assurance", voiture.assurance);
                        command.Parameters.AddWithValue("@carte_grise", voiture.carte_grise);
                        command.Parameters.AddWithValue("@visite", voiture.visite);
                        command.Parameters.AddWithValue("@ph_voiture", voiture.ph_voiture);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", " Zakaria Location");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}", " Zakaria Location");
            }
        }






























    }
}
