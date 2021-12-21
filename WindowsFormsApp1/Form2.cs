using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.CITY". При необходимости она может быть перемещена или удалена.
            this.cITYTableAdapter.Fill(this.dataSet.CITY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet3.CITY". При необходимости она может быть перемещена или удалена.
            //this.cITYTableAdapter.Fill(this.dataSet3.CITY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.CLIENT". При необходимости она может быть перемещена или удалена.
            // this.cLIENTTableAdapter.Fill(this.dataSet2.CLIENT);

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source = localhost:1521/CUR_exchange; User ID=ADMIN_TT;password=123";
            string a = textBox2.Text;
            string b = textBox1.Text;
            int c = Convert.ToInt32(comboBox1.SelectedValue);
            int d = Convert.ToInt32(textBox3.Text);
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                cmd.CommandText = "INSERT INTO CLIENT(FULLNAME,NAME_LOG,ID_CITY, ID_C) VALUES (:a,:b,:c, :d)";
                cmd.Connection = ConnectionToOracle;
                cmd.Parameters.Add("a", OracleType.VarChar).Value = a;
                cmd.Parameters.Add("b", OracleType.VarChar).Value = b;
                cmd.Parameters.Add("c", OracleType.Int32).Value = c;
                cmd.Parameters.Add("d", OracleType.Int32).Value = d;
                ConnectionToOracle.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
