using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    internal class Message
    {
        public static void ModifierMessage(string type_message, string commentaire, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE message SET type_message = @type_message, commentaire = @commentaire WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@type_message", type_message);
                        command.Parameters.AddWithValue("@commentaire", commentaire);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Restaurantly");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}", " Restaurantly");
            }
        }
    }
}
