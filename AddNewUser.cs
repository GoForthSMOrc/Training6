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

namespace Trenirovochka2
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (newlogBox.Text == "" || newpassBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                String query = "insert into UsersDB(Login,Password) values ('" + newlogBox.Text + "','" + newpassBox.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Пользователь добавлен");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
