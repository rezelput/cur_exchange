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
    public partial class Form4 : Form
    {
        const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
        DataTable dt = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();

        private System.Data.OracleClient.OracleConnection conn = null;
        private System.Data.OracleClient.OracleDataAdapter dataAdapter = null;
        private DataTable table = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.HISTORY_OPERAT". При необходимости она может быть перемещена или удалена.
            this.hISTORY_OPERATTableAdapter.Fill(this.dataSet.HISTORY_OPERAT);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                OracleDataAdapter dataAdapter = new OracleDataAdapter("SELECT * FROM HISTORY_OPERAT", connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                OracleDataAdapter dataAdapter = new OracleDataAdapter("SELECT * FROM USERS", connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
            }
        }
    }
}
