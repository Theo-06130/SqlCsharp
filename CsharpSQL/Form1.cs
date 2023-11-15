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

        private void TrouverInfoDansBDD(string query, string columnName)
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

                        // Parcourez les résultats et ajoutez-les au ListBox
                        while (reader.Read())
                        {
                            // Ajoutez la valeur de la colonne spécifiée à la liste
                            listBox1.Items.Add(reader[columnName].ToString());
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
                   MessageBox.Show("Connexion réussie à la base de données: "+ connectionString.Substring(75));
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
                    TrouverInfoDansBDD( "SELECT * FROM Genre", "Titre_Genre");
                    //   MessageBox.Show("Données récupérées et affichées avec succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
            
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    TrouverInfoDansBDD( "SELECT * FROM Livres", "Titre_Livre");
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
                    TrouverInfoDansBDD( "SELECT * FROM Auteur", "Nom");
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
                    TrouverInfoDansBDD( "SELECT * FROM Types", "Types");
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
 

