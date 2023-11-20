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

                    // Affichez le nombre d'éléments dans le contrôle Name_book
                    Name_book.Text = count.ToString();
                    
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
            groupBox.Text = $"ID Livre n°{numero}"; // Utilisez la propriété du livre que vous souhaitez afficher

            // Ajoutez un Label pour afficher le nom du livre
            Label label = new Label();

            // Créez une connexion avec la chaîne de connexion
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Ouvrez la connexion
                connection.Open();
                
                string query = "SELECT Titre_Livre FROM Livres WHERE Id_Livre = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajoutez le paramètre Id_Livre
                    command.Parameters.AddWithValue("@id", numero);

                    // Exécutez la commande et lisez le résultat
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lisez la valeur du champ Titre_Livre dans la colonne
                            string titreLivre = reader["Titre_Livre"].ToString();
                            //string NomAuteur = reader["Intrigue"].ToString();
                    
                            // Définissez le texte du Label avec le titre du livre
                            label.Text = $"Titre : {titreLivre}";
                            //label.Text = $"Prix : {NomAuteur}";
                        }
                    }
                }
            }

            label.Location = new Point(5, 20); // Ajustez la position du Label à l'intérieur du GroupBox
            label.Height = 40;
            groupBox.Controls.Add(label);

            // Ajoutez d'autres contrôles à l'intérieur du GroupBox si nécessaire

            return groupBox;
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
            Groupe_livre.Visible = false;
            info_Card_BDD();
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
        
    }
}
 

