//using Oracle.ManagedDataAccess.Client;
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
    public partial class Form1 : Form
    {

        const string SqlConn = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
        DataTable dt = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = new System.Data.OracleClient.OracleConnection("Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123");
            connectionString.Open();
            DataSet ds = new DataSet();
            dataAdapter = new System.Data.OracleClient.OracleDataAdapter("SELECT ID,ID_TYPE,DATE_DDMMYY,ONUMBER,SUMM,ID_USER,ID_CUR FROM OPERATION", connectionString);
            table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.OPERATION". При необходимости она может быть перемещена или удалена.
            //this.oPERATIONTableAdapter.Fill(this.dataSet.OPERATION);
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
            dataGridView1.DataSource = bindingSource1;
            GetData(null);
        }

        private System.Data.OracleClient.OracleConnection connectionString = null;
        private System.Data.OracleClient.OracleDataAdapter dataAdapter = null;
        private DataTable table = null;
        private void GetData(string selectCommand)
        {
            try
            {
                table.Clear();

                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка обработки" + ex);
            }
            
        }

        private void analyst_op_Click(object sender, EventArgs e)
        {
            try
            {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
            //Сообщение
            MessageBox.Show("Отчет создан");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
            
        }

       // public bool BindByName { get; set; }

        private void currency_exch_his_Click(object sender, EventArgs e)
        {
            addhistrop hr1 = new addhistrop();
            hr1.Show();
            
        }

        private void histr_op_Click(object sender, EventArgs e)
        {
            History hpo = new History();
            hpo.Show();
        }

        private void курсВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addhistrop cur = new addhistrop();
            cur.Show();

        }
    }
}
