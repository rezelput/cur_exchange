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
    public partial class Form4 : Form
    {

        DataTable dt = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();

        private System.Data.OracleClient.OracleConnection connectionString = null;
        private System.Data.OracleClient.OracleDataAdapter dataAdapter = null;
        private DataTable table = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData(null);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                try
                {
                    table.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка обработки" + ex);
                }
                
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки" + ex);
            }

        }
    }
}
