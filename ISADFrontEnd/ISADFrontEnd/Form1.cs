using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISADFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQueryChoice.SelectedIndex == 0)
            {
                string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                    "UID=" + DBConnection.UserName + ";" + "PASSWORD=" + DBConnection.Password + ";" + "SslMode=" + DBConnection.SSLMODE + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM isad157_jflemans.profile";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable profileDataTable = new DataTable();
                    sqlDA.Fill(profileDataTable);
                    dgvProfile.DataSource = profileDataTable;
                }
            }
            else
            {
                if (cbxQueryChoice.SelectedIndex == 1)
                {
                    string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                        "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


                    using (MySqlConnection connection =
                        new MySqlConnection(ConnectionString))
                    {
                        string query = "SELECT * FROM isad157_jflemans.friendlink";
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                        DataTable friendlinkDataTable = new DataTable();
                        sqlDA.Fill(friendlinkDataTable);
                        dgvFriendLink.DataSource = friendlinkDataTable;
                    }
                }
                else
                {
                    if (cbxQueryChoice.SelectedIndex == 2)
                    {
                        string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                            "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


                        using (MySqlConnection connection =
                            new MySqlConnection(ConnectionString))
                        {
                            string query = "SELECT * FROM isad157_jflemans.messages";
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                            DataTable messagesDataTable = new DataTable();
                            sqlDA.Fill(messagesDataTable);
                            dgvMessages.DataSource = messagesDataTable;
                        }
                    }
                    else
                    {
                        if (cbxQueryChoice.SelectedIndex == 3)
                        {
                            string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                                "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


                            using (MySqlConnection connection =
                                new MySqlConnection(ConnectionString))
                            {
                                string query = "SELECT * FROM isad157_jflemans.universities";
                                connection.Open();
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                                DataTable universitiesDataTable = new DataTable();
                                sqlDA.Fill(universitiesDataTable);
                                dgvUniversities.DataSource = universitiesDataTable;
                            }
                        }
                        else
                        {
                            if (cbxQueryChoice.SelectedIndex == 4)
                            {
                                string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                                    "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


                                using (MySqlConnection connection =
                                    new MySqlConnection(ConnectionString))
                                {
                                    string query = "SELECT * FROM isad157_jflemans.workplace";
                                    connection.Open();
                                    MySqlCommand cmd = new MySqlCommand(query, connection);
                                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                                    DataTable workplaceDataTable = new DataTable();
                                    sqlDA.Fill(workplaceDataTable);
                                    dgvWorkPlace.DataSource = workplaceDataTable;
                                }
                            }
                            else
                            {
                                if (cbxQueryChoice.SelectedIndex == 5)
                                {
                                    string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                                        "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


                                    using (MySqlConnection connection =
                                        new MySqlConnection(ConnectionString))
                                    {
                                        string query = "SELECT * FROM isad157_jflemans.relationships";
                                        connection.Open();
                                        MySqlCommand cmd = new MySqlCommand(query, connection);
                                        MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                                        DataTable relationshipsDataTable = new DataTable();
                                        sqlDA.Fill(relationshipsDataTable);
                                        dgvRelationships.DataSource = relationshipsDataTable;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
