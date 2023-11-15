using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Librairie MySQL ajoutée précédemment dans les références
using MySql.Data.MySqlClient;

namespace CsharpSQL
{
    public partial class Form1 : Form
    {


        // Déplacez la déclaration de la chaîne de connexion en dehors de la méthode
        private string connectionString =
            "Server=176.31.132.185;User ID=biblivres;Password=ig%B-7K2*59WzOc_;Database=biblivres";

        private void TrouverInfoDansBDD(string query, string info1, string info2, string info3)
        {

            // Créez une connexion avec la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Ouvrez la connexion
                connection.Open();

                // Créez une instance de MySqlCommand avec la commande SQL et la connexion
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Créez un lecteur de données pour récupérer les résultats de la commande SQL
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Effacez les éléments existants dans le ListBox
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        listBox3.Items.Clear();


                        listBox1.Items.Add(info1);
                        listBox2.Items.Add(info2);
                        listBox3.Items.Add(info3);
                        listBox1.Items.Add(" ");
                        listBox2.Items.Add(" ");
                        listBox3.Items.Add(" ");
                        
                        // Parcourez les résultats et ajoutez-les au ListBox
                        while (reader.Read())
                        {
                            
                            // Ajoutez la valeur de la colonne spécifiée à la liste
                            if (info1 == "")
                            {
                                listBox1.Items.Add("Aucune information disponible");
                            }
                            else
                            {
                                listBox1.Items.Add(reader[info1].ToString()); 
                            }
                            if (info2 == "")
                            {
                                listBox2.Items.Add("Aucune information disponible");
                            }
                            else
                            {
                                listBox2.Items.Add(reader[info2].ToString()); 
                            }
                            if (info3 == "")
                            {
                                listBox3.Items.Add("Aucune information disponible");
                            }
                            else
                            {
                                listBox3.Items.Add(reader[info3].ToString()); 
                            }
                            
                            
                        }

                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void rechargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))


            {
                try
                {
                    // Ouvrez la connexion
                    connection.Open();
                    MessageBox.Show("Connexion réussie à la base de données: " + connectionString.Substring(75));
                    // nom de la base de données récupérés de façon statique  avec l'indice de "connectionString"
                }
                catch (MySqlException co)
                {
                    MessageBox.Show(co.ToString());
                    MessageBox.Show("Connexion échouée");
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion

            {
                try
                {
                    TrouverInfoDansBDD("SELECT * FROM Genre", "Titre_Genre", "Description_Genre", "Restriction_Age");
                    //   MessageBox.Show("Données récupérées et affichées avec succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }

        }

        private void auteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    TrouverInfoDansBDD("SELECT * FROM Auteur", "Nom", "Nationalite", "Courant");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }

        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    TrouverInfoDansBDD("SELECT * FROM Types", "Types", "Description_Type", "");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }

        }

        private void livresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    TrouverInfoDansBDD("SELECT * FROM Livres", "Titre_Livre", "Editeur", "prix");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
        }
    }
}
 

