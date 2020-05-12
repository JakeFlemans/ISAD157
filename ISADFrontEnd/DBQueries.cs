using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.MysqlClient;


public class DBForm : Form
{

    public DBForm()
    {
        InitializeComponent();
    }

    private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxQueryChoice.SelectedIndex == 0)
        {
            string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


            using (MySQLConnnection connection =
                new MySQLConnnection(ConnectionString))
            {
                string query = "SELECT * FROM isad157_JFlemans.profile";
                connection.Open();
                MySQLCommand cmd = new MySQLCommand(query, connection);
                MySQLDataAdapter sqlDA = new MySQLDataAdapter(cmd);
                DataTable profileDataTable = new DataTable();
                sqlDA.Fill(profileDataTable);
                dataGridViewProfile.DataSource = profileDataTable;
            }
        }
        else
        {
            string ConnectionString = "SERVER=" + DBConnection.ServerName + ";" + "DATABASE=" + DBConnection.DataBaseName + ";" +
                "USERNAME=" + DBConnection.UserName + ";" + "Password=" + DBConnection.Password + ";" + "SSLMODE=" + DBConnection.SSLMODE + ";";


            using (MySQLConnnection connection =
                new MySQLConnnection(ConnectionString))
            {
                string query = "SELECT * FROM isad157_JFlemans.friendlink";
                connection.Open();
                MySQLCommand cmd = new MySQLCommand(query, connection);
                MySQLDataAdapter sqlDA = new MySQLDataAdapter(cmd);
                DataTable friendlinkDataTable = new DataTable();
                sqlDA.Fill(friendlinkDataTable);
                dataGridViewProfile.DataSource = friendlinkDataTable;
            }
        }
    }

}
