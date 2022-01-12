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

        const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
        OracleConnectionStringBuilder conn = new OracleConnectionStringBuilder(connectionString);
        DataSet ds = new DataSet();

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
            
            try
            {
                if (addbtn.Checked)
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


                MessageBox.Show("Запись добавлена!");
            }


            catch (Exception exp)
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
                comboBox3.Enabled = false;

                login_box.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                updatebtn.Checked = false;
                name_ff_box.Enabled = false ;

                сохранитьToolStripMenuItem.Enabled = true;
                обновитьToolStripMenuItem.Enabled = false;
            }
        }

        private void updatebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (updatebtn.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                //name_ff_box.Enabled = true;
                //выкл
                login_box.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                addbtn.Checked = false;

                сохранитьToolStripMenuItem.Enabled = false;
                обновитьToolStripMenuItem.Enabled = true;
            }
        }

        private void CloseFr2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked)
                {
                    comboBox3.Enabled = true;
                }
                else 
                {
                comboBox3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                name_ff_box.Enabled = true;
            }
            else
            {
                name_ff_box.Enabled = false;
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (updatebtn.Checked)
                {

                    if (checkBox2.Checked)
                    {
                        int id_b = Convert.ToInt32(comboBox2.SelectedValue);
                        string fullname = name_ff_box.Text;
                        using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
                        {
                            System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                            cmd.CommandText = "UPDATE USERS SET NAME=:FNAME WHERE ID=:ID";
                            cmd.Connection = ConnectionToOracle;
                            cmd.Parameters.AddWithValue("ID", id_b);
                            cmd.Parameters.Add("FNAME", OracleType.VarChar).Value = fullname;
                            ConnectionToOracle.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (checkBox2.Checked)
                    {
                        int id_b1 = Convert.ToInt32(comboBox2.SelectedValue);
                        int id_country = Convert.ToInt32(comboBox3.SelectedValue);
                        using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
                        {
                            System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                            cmd.CommandText = "UPDATE USERS SET ID_CNTR=:ID WHERE ID=:ID_USRS";
                            cmd.Connection = ConnectionToOracle;
                            cmd.Parameters.AddWithValue("ID_USRS", id_b1);
                            cmd.Parameters.Add("ID", OracleType.Int32).Value = id_country;
                            ConnectionToOracle.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Запись обновлена!");
            }


            catch (Exception exp)
            {
                MessageBox.Show("Ошибка в обработке события" + exp.Message);
            }
        }

        private void watch_client_Click(object sender, EventArgs e)
        {
            Form4 fg = new Form4();
            fg.Show();
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                OracleDataAdapter dataAdapter = new OracleDataAdapter("SELECT * FROM USERS", connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                fg.dataGridView1.DataSource = dataSet.Tables["USERS"];
            }
        }
    }
}
