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
    public partial class Form3 : Form
    {

        const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.CURRENCY". При необходимости она может быть перемещена или удалена.
            this.cURRENCYTableAdapter.Fill(this.dataSet.CURRENCY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TYPE_OPERATION". При необходимости она может быть перемещена или удалена.
            this.tYPE_OPERATIONTableAdapter.Fill(this.dataSet.TYPE_OPERATION);


        }

        private void AddOp_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = Convert.ToInt32(id_op.Text);
                int id_type = Convert.ToInt32(typeop_box.SelectedValue);
                DateTime dateyy = Convert.ToDateTime(date.Value);
                string num = opnum.Text;
                string sum = CurOpSum.Text;
                int id_user = Convert.ToInt32(UsBox.SelectedValue);
                int id_cur = Convert.ToInt32(changeCur.SelectedValue);
                using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
                {
                    System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                    cmd.CommandText = "INSERT INTO OPERATION(ID, ID_TYPE, DATE_DDMMYY,ONUMBER,SUMM,ID_USER, ID_CUR  ) VALUES (:id,:id_type,:dateyy, :num,:sum,:id_user, :id_cur)";
                    cmd.Connection = ConnectionToOracle;
                    cmd.Parameters.Add("id", OracleType.Int32).Value = id;
                    cmd.Parameters.Add("id_type", OracleType.Int32).Value = id_type;
                    cmd.Parameters.Add("dateyy", OracleType.DateTime).Value = dateyy;
                    cmd.Parameters.Add("num", OracleType.VarChar).Value = num;
                    cmd.Parameters.Add("sum", OracleType.VarChar).Value = sum;
                    cmd.Parameters.Add("id_user", OracleType.Int32).Value = id_user;
                    cmd.Parameters.Add("id_cur", OracleType.Int32).Value = id_cur;
                    ConnectionToOracle.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка в обработке события" + exp.Message);
            }
        }

        private void CloseFr3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
                
        }

        private void Sum_cur_Click(object sender, EventArgs e)
        {
            CurOpSum.Text = Convert.ToString(Convert.ToInt32(curruncy.Text) * Convert.ToInt32(rus_box.Text));
        }

        private void changeCur_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
            {
                
            }
        }
    }
}
