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
                    MessageBox.Show("Connexion réussie");
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
            FormTest formTest = new FormTest();
            formTest.Show();
            throw new System.NotImplementedException();
        }
    }
    }
 

