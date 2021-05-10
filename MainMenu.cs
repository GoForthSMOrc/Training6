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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            getInfo(listView1);
        }

        void getInfo(ListView List)
        {
            String query = "select Money.Id_Money, Money.NameMoney, DateM.NameDateM from Money join DateM on DateM.Id_Date = Money.id_Date order by Id_Money ASC";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                MessageBox.Show(ex.Message);
            }
        }
        private void backAuthoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization win = new Authorization();
            win.Show();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            AddNewUser win = new AddNewUser();
            win.Show();
        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            AddNewRecord win = new AddNewRecord();
            win.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateRecord win = new UpdateRecord();
            win.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (deleteBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                listView1.Items.Clear();
                String query = "delete from Money where Id_Money = '" + deleteBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            if (findBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                listView1.Items.Clear();
                String query = "select * from Money where Id_Money = '" + findBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    conn.Close();
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
