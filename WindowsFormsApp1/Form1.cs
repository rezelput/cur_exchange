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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.OPERATION". При необходимости она может быть перемещена или удалена.
            this.oPERATIONTableAdapter.Fill(this.dataSet.OPERATION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.OPERATION". При необходимости она может быть перемещена или удалена.
            //this.oPERATIONTableAdapter.Fill(this.dataSet1.OPERATION);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        

        private void oPERATIONBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientadd_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void opadd_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void UpdateDtabtn_Click(object sender, EventArgs e)
        {
            GetData(null);
        }

        const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
        DataTable dt = new DataTable();

        private void GetData(string selectCommand)
        {
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                DataSet ds = new DataSet();
                System.Data.OracleClient.OracleDataAdapter dataAdapter = new System.Data.OracleClient.OracleDataAdapter("SELECT * FROM OPERATION", connectionString);

                ConnectionToOracle.Open();
                dataAdapter.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                ConnectionToOracle.Close();
            }
        }
    }
}
