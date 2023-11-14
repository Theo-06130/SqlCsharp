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
        private string connectionString = "Server=176.31.132.185;User ID=biblivres;Password=ig%B-7K2*59WzOc_;Database=biblivres";
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
                  //  MessageBox.Show("Connexion réussie");
                }
                catch (MySqlException co)
                {
                    MessageBox.Show(co.ToString());
                    MessageBox.Show("Connexion échouée");
                }
            }
            throw new System.NotImplementedException();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouvrez la connexion
                    connection.Open();
    
                    // Commande SQL pour récupérer toutes les données de la table "nom_de_votre_table"
                    string query = "SELECT * FROM Genre";

                    // Créez une instance de MySqlCommand avec la commande SQL et la connexion
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Créez un lecteur de données pour récupérer les résultats de la commande SQL
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Effacez les éléments existants dans le ListBox
                            listBox1.Items.Clear();

                            // Parcourez les résultats et ajoutez-les au ListBox
                            while (reader.Read())
                            {
                                // Ajoutez ici les colonnes spécifiques que vous souhaitez afficher
                                // Par exemple, si vous avez une colonne nom, vous pouvez ajouter : reader["Nom"].ToString()
                                listBox1.Items.Add(reader["Titre_Genre"].ToString());
                            }
                        }
                    }

                 //   MessageBox.Show("Données récupérées et affichées avec succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
            throw new System.NotImplementedException();
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouvrez la connexion
                    connection.Open();
    
                    // Commande SQL pour récupérer toutes les données de la table "nom_de_votre_table"
                    string query = "SELECT * FROM Livres";

                    // Créez une instance de MySqlCommand avec la commande SQL et la connexion
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Créez un lecteur de données pour récupérer les résultats de la commande SQL
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Effacez les éléments existants dans le ListBox
                            listBox1.Items.Clear();

                            // Parcourez les résultats et ajoutez-les au ListBox
                            while (reader.Read())
                            {
                                // Ajoutez ici les colonnes spécifiques que vous souhaitez afficher
                                // Par exemple, si vous avez une colonne nom, vous pouvez ajouter : reader["Nom"].ToString()
                                listBox1.Items.Add(reader["Titre_Livre"].ToString());
                            }
                        }
                    }

                   // MessageBox.Show("Données récupérées et affichées avec succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
            throw new System.NotImplementedException();
        }

        private void auteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouvrez la connexion
                    connection.Open();
    
                    // Commande SQL pour récupérer toutes les données de la table "nom_de_votre_table"
                    string query = "SELECT * FROM Auteur";

                    // Créez une instance de MySqlCommand avec la commande SQL et la connexion
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Créez un lecteur de données pour récupérer les résultats de la commande SQL
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Effacez les éléments existants dans le ListBox
                            listBox1.Items.Clear();

                            // Parcourez les résultats et ajoutez-les au ListBox
                            while (reader.Read())
                            {
                                // Ajoutez ici les colonnes spécifiques que vous souhaitez afficher
                                // Par exemple, si vous avez une colonne nom, vous pouvez ajouter : reader["Nom"].ToString()
                                listBox1.Items.Add(reader["Nom"].ToString());
                            }
                        }
                    }

                    //MessageBox.Show("Données récupérées et affichées avec succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
            throw new System.NotImplementedException();
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouvrez la connexion
                    connection.Open();
    
                    // Commande SQL pour récupérer toutes les données de la table "nom_de_votre_table"
                    string query = "SELECT * FROM Types";

                    // Créez une instance de MySqlCommand avec la commande SQL et la connexion
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Créez un lecteur de données pour récupérer les résultats de la commande SQL
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Effacez les éléments existants dans le ListBox
                            listBox1.Items.Clear();

                            // Parcourez les résultats et ajoutez-les au ListBox
                            while (reader.Read())
                            {
                                // Ajoutez ici les colonnes spécifiques que vous souhaitez afficher
                                // Par exemple, si vous avez une colonne nom, vous pouvez ajouter : reader["Nom"].ToString()
                                listBox1.Items.Add(reader["Types"].ToString());
                            }
                        }
                    }

                    //MessageBox.Show("Données récupérées et affichées avec succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
            throw new System.NotImplementedException();
        }
    }
    }
 

