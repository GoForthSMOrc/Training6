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
    public partial class AddNewRecord : Form
    {
        public AddNewRecord()
        {
            InitializeComponent();
        }

        private void AddNewRecordButton_Click(object sender, EventArgs e)
        {
            
            String query = "insert into Money (NameMoney,id_Date) values ('" + newnameBox.Text + "', '" + dateBox.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Запись добавлена");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка ввода");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
