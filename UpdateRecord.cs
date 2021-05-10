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
    public partial class UpdateRecord : Form
    {
        public UpdateRecord()
        {
            InitializeComponent();
        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            if (moneyBox.Text == "" || numberBox.Text == "" || dateBox.Text == "" )
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            { 
               String query = "update Money set NameMoney = '" + moneyBox.Text + "', id_Date = '" + dateBox.Text + "' where Id_Money = '" + numberBox.Text + "';";
               MySqlConnection conn = DBUtils.GetDBConnection();
               MySqlCommand cmDB = new MySqlCommand(query, conn);
               cmDB.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Запись обновлена");
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка");
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
