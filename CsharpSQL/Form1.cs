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

        

        private void info_Card_BDD( bool afficherTitre, bool afficherAuteur, bool afficherPages, bool afficherLangue,bool afficherEditeur, bool afficherPrix, bool afficherGenre, bool afficherTypes)
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
                    int initialX = 0;
                    int initialY = 50;
                    int groupBoxWidth = 180;
                    int groupBoxHeight = 300;
                    
                    
                    // Variables de position actuelle
                    int currentX = initialX;
                    int currentY = initialY;
                    for (int i = 0; i < count; i++)
                    {
                        
                        GroupBox groupBox = CreerGroupBoxPourLivre(i + 1,afficherTitre,afficherAuteur,afficherPages,afficherLangue,afficherEditeur,afficherPrix,afficherGenre,afficherTypes); // Utilisez i + 1 pour obtenir des numéros de groupe uniques
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
        
        private GroupBox CreerGroupBoxPourLivre(int numero, bool afficherTitre, bool afficherAuteur, bool afficherPages, bool afficherLangue,bool afficherEditeur, bool afficherPrix, bool afficherGenre, bool afficherTypes)
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
            Label labelGenre = new Label();
            Label labelTypes = new Label();


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
                               "JOIN Genre ON Livres.Id_Genre = Genre.Id_Genre " +
                               "JOIN Types ON Livres.Id_Types = Types.Id_Types " +
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
                            string Genre = reader["Titre_Genre"].ToString();
                            string Types = reader["Types"].ToString();

                            
                            // Définissez le texte des Labels avec les informations récupérées
                            labelPages.Text = $"{pages} Pages";
                            labelLangues.Text = $"{Langue}";
                            labelTitre.Text = $"Titre : {titreLivre}";
                            labelAuteur.Text = $"Écrit par {nomAuteur}";
                            labelEditeur.Text = $"Édité par {editeur}";
                            labelPrix.Text = $"Vendu à {Prix}€";
                            labelGenre.Text = $"Genres : {Genre}";
                            labelTypes.Text = $"De type : {Types}";


                        }
                    }
                }
            }
            // disposition des labels
            labelLangues.Location = new Point(120, 20);
            labelPages.Location = new Point(2, 20);
            labelTitre.Location = new Point(2, 45); 
            labelAuteur.Location = new Point(2, 70); 
            labelEditeur.Location = new Point(2, 95);
            labelPrix.Location = new Point(1, 120);
            labelGenre.Location = new Point(2, 145);
            labelTypes.Location = new Point(2, 170);


            // Ajoutez des Labels pour afficher les informations en fonction des paramètres
            if (afficherTitre)
            {
                groupBox.Controls.Add(labelTitre);
            }

            if (afficherAuteur)
            {
                groupBox.Controls.Add(labelAuteur);
            }

            if (afficherPages)
            {
                groupBox.Controls.Add(labelPages);
            }

            if (afficherLangue)
            {
                groupBox.Controls.Add(labelLangues);
            }
            if (afficherEditeur)
            {
                groupBox.Controls.Add(labelEditeur);
            }
            if (afficherPrix)
            {
                groupBox.Controls.Add(labelPrix);
            }
            if (afficherGenre)
            {
                groupBox.Controls.Add(labelGenre);
            }
            if (afficherTypes)
            {
                groupBox.Controls.Add(labelTypes);
            }
            return groupBox;
        }



        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info_Card_BDD(true,true,true,true,true,true,true,true);
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

        private void genresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info_Card_BDD(false,false,false,false,false,false,true, false);
        }

        private void livresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info_Card_BDD(true,true,true,true,true,true,false,true);
        }

        private void auteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info_Card_BDD(false,true,false,false,false,false,false,false);
        }

        private void typesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info_Card_BDD(false,false,false,false,false,false,false,true);
        }
    }
}