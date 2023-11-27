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

        /*private void TrouverInfoDansBDD(string query, string info1, string info2, string info3)
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
        }*/

        private void info_Card_BDD()
        {
            // Créez une connexion avec la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Ouvrez la connexion
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT COUNT(Id_Livre) FROM Livres", connection))
                {
                    // Exécutez la commande et obtenez le résultat (nombre d'éléments)
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    
                    
                    // Définissez la position initiale des GroupBox
                    int initialX = 10;
                    int initialY = 50;
                    int groupBoxWidth = 150;
                    int groupBoxHeight = 300;
                    
                    
                    // Variables de position actuelle
                    int currentX = initialX;
                    int currentY = initialY;
                    for (int i = 0; i < count; i++)
                    {
                        GroupBox groupBox = CreerGroupBoxPourLivre(i + 1); // Utilisez i + 1 pour obtenir des numéros de groupe uniques
                        // Changez la couleur de fond du GroupBox
                        groupBox.BackColor = (i % 2 == 0) ? Color.LightBlue : Color.LightGray;
                        // Définissez la position du GroupBox
                        groupBox.Location = new Point(currentX, currentY);

                        // Ajoutez le GroupBox à votre formulaire ou à un autre conteneur
                        this.Controls.Add(groupBox);

                        // Mettez à jour la position actuelle
                        currentX += groupBoxWidth*2;
                        
                        //Mettre à jour la taille des éléments
                        groupBox.Width = groupBoxWidth;
                        groupBox.Height = groupBoxHeight;

                        // Vérifiez si le GroupBox sort de la fenêtre
                        if (currentX + groupBoxWidth > this.Width)
                        {
                            // Réinitialisez la position X et passez à la ligne suivante
                            currentX = initialX;
                            currentY += groupBoxHeight + (groupBoxHeight/2);
                        }
                    }
                }
            }
        }
        
        private GroupBox CreerGroupBoxPourLivre(int numero)
        {
            // Créez un GroupBox pour chaque livre
            GroupBox groupBox = new GroupBox();
            
            // Ajoutez des Labels pour afficher le nom du livre et le nom de l'auteur
            Label labelPages = new Label();
            Label labelLangues = new Label();
            Label labelTitre = new Label();
            Label labelAuteur = new Label();
            Label labelEditeur = new Label();
            Label labelPrix = new Label();


            // Créez une connexion avec la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Ouvrez la connexion
                connection.Open();

                // Créez une commande SQL pour récupérer le titre du livre et le nom de l'auteur
                string query = "SELECT * " +
                               "FROM Livres " +
                               "JOIN Auteur ON Livres.Id_Auteur = Auteur.Id_Auteur " +
                               "JOIN Langue ON Livres.Id_Langue = Langue.Id_Langue " +
                               "WHERE Livres.Id_Livre = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajoutez le paramètre Id_Livre
                    command.Parameters.AddWithValue("@id", numero);

                    // Exécutez la commande et lisez le résultat
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lisez les valeurs des champs Titre_Livre et Nom_Auteur
                            string pages = reader["Nb_Pages"].ToString();
                            string Langue = reader["Acronyme"].ToString();
                            string titreLivre = reader["Titre_Livre"].ToString();
                            string nomAuteur = reader["Nom"].ToString();
                            string editeur = reader["Editeur"].ToString();
                            string Prix = reader["Prix"].ToString();

                    
                            // Définissez le texte des Labels avec les informations récupérées
                            labelPages.Text = $"{pages} Pages";
                            labelLangues.Text = $"{Langue}";
                            labelTitre.Text = $"Titre : {titreLivre}";
                            labelAuteur.Text = $"Écrit par {nomAuteur}";
                            labelEditeur.Text = $"Édité par {editeur}";
                            labelPrix.Text = $"Vendu à {Prix}€";


                        }
                    }
                }
            }

            labelLangues.Location = new Point(120, 20);
            labelPages.Location = new Point(2, 20);
            labelTitre.Location = new Point(10, 45); // Ajustez la position du Label à l'intérieur du GroupBox
            labelAuteur.Location = new Point(10, 70); // Ajustez la position du deuxième Label
            labelEditeur.Location = new Point(10, 95);//Ajustez la position du troisièmme Label
            labelPrix.Location = new Point(10, 120);

            groupBox.Controls.Add(labelLangues);
            groupBox.Controls.Add(labelPages);
            groupBox.Controls.Add(labelTitre);
            groupBox.Controls.Add(labelAuteur);
            groupBox.Controls.Add(labelEditeur);
            groupBox.Controls.Add(labelPrix);

            // Ajoutez d'autres contrôles à l'intérieur du GroupBox si nécessaire

            return groupBox;
        }



        public Form1()
        {
            InitializeComponent();
        }
        

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créez une instance de MySqlConnection en utilisant la chaîne de connexion

            {
                try
                {
                    // TrouverInfoDansBDD("SELECT * FROM Genre", "Titre_Genre", "Description_Genre", "Restriction_Age");
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
                    // TrouverInfoDansBDD("SELECT * FROM Auteur", "Nom", "Nationalite", "Courant");
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
                    // TrouverInfoDansBDD("SELECT * FROM Types", "Types", "Description_Type", "");
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
                    //  TrouverInfoDansBDD("SELECT * FROM Livres", "Titre_Livre", "Editeur", "prix");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                    MessageBox.Show("Échec de la récupération des données");
                }
            }
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info_Card_BDD();
        }

        private void testConnexionBDDToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}