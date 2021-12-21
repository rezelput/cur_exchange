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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.COUNTRY". При необходимости она может быть перемещена или удалена.
            this.cOUNTRYTableAdapter.Fill(this.dataSet.COUNTRY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.CITY". При необходимости она может быть перемещена или удалена.
            this.cITYTableAdapter.Fill(this.dataSet.CITY);

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
            //string a = textBox2.Text;
            //string b = login_box.Text;
            //int c = Convert.ToInt32(comboBox1.SelectedValue);
            //int d = Convert.ToInt32(textBox3.Text);
            try
            {
            int a = Convert.ToInt32(textBox3.Text);
            string b = login_box.Text;
            string c = textBox2.Text;
            int d = Convert.ToInt32(comboBox1.SelectedValue);
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                cmd.CommandText = "INSERT INTO USERS(ID, LOGIN, NAME, ID_CNTR) VALUES (:a,:b,:c, :d)";
                cmd.Connection = ConnectionToOracle;
                cmd.Parameters.Add("a", OracleType.Int32).Value = a;
                cmd.Parameters.Add("b", OracleType.VarChar).Value = b;
                cmd.Parameters.Add("c", OracleType.VarChar).Value = c;
                cmd.Parameters.Add("d", OracleType.Int32).Value = d;
                ConnectionToOracle.Open();
                cmd.ExecuteNonQuery();
            }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Ошибка в обработке события" + exp.Message);
            }
            
        }

        private void очиститьФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void addbtn_CheckedChanged(object sender, EventArgs e)
        {
             if (addbtn.Checked)
            {
                comboBox2.Enabled = false;
                comboBox1.Enabled = true;

                login_box.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                updatebtn.Checked = false;
            }
        }

        private void updatebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (updatebtn.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                //выкл
                login_box.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;

                addbtn.Checked = false;
            }
        }

        private void CloseFr2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
