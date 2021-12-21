using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void Auto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.STAFF". При необходимости она может быть перемещена или удалена.
            this.sTAFFTableAdapter.Fill(this.dataSet.STAFF);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
                System.Data.OracleClient.OracleConnection con = new System.Data.OracleClient.OracleConnection(@"Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123");
                System.Data.OracleClient.OracleDataAdapter dataAdapter = new System.Data.OracleClient.OracleDataAdapter("Select id From staff where login = '" + usersbox.Text + "' and password = '" + pswrd.Text + "'", con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                // Проверяем, что количество строк из БД больше нуля
                if (dt.Rows.Count > 0)
                {
                    // Нужный Вам ID
                    string id = dt.Rows[0][0].ToString();
                    this.Hide();
                    Form1 ss = new Form1();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Неправильно введённые имя или пароль");
                }

         }

        private void bdbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pswrd_TextChanged(object sender, EventArgs e)
        {
            pswrd.PasswordChar = '*';
        }
    }
}
