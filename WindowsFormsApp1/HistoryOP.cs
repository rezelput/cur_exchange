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
    public partial class HistoryOP : Form
    {

        const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
        public HistoryOP()
        {
            InitializeComponent();
        }

        private void HistoryOP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TYPE_UPDATE". При необходимости она может быть перемещена или удалена.
            this.tYPE_UPDATETableAdapter.Fill(this.dataSet.TYPE_UPDATE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.OPERATION". При необходимости она может быть перемещена или удалена.
            this.oPERATIONTableAdapter.Fill(this.dataSet.OPERATION);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
        int id = Convert.ToInt32(id_htr.SelectedValue);
                        int id_ttype = Convert.ToInt32(type_update.SelectedValue);
                        DateTime dateyy = Convert.ToDateTime(dateTimePicker.Value);
                        string summ = Convert.ToString(sumBox.SelectedValue);
                        int mmuser = Convert.ToInt32(user_id.SelectedValue);

                        using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
                        {
                            System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                            cmd.CommandText = "INSERT INTO HISTORY_OPERAT(ID, ID_TT_CH, DATE_DDMM,SUMM,ID_USER ) VALUES (:id,:id_ttype,:dateyy,:summ,:mmuser)";
                            cmd.Connection = ConnectionToOracle;
                            cmd.Parameters.Add("id", OracleType.Int32).Value = id;
                            cmd.Parameters.Add("id_ttype", OracleType.Int32).Value = id_ttype;
                            cmd.Parameters.Add("dateyy", OracleType.DateTime).Value = dateyy;
                            cmd.Parameters.Add("summ", OracleType.VarChar).Value = summ;
                            cmd.Parameters.Add("mmuser", OracleType.Int32).Value = mmuser;
                            ConnectionToOracle.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("История создана");
                            Form4 fr4 = new Form4();
                            fr4.Show();
                            this.Close();
                    
                        }
            
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка в обработке события" + exp.Message);
            }


}
    }
}
