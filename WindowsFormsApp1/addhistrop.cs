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
    public partial class addhistrop : Form
    {
        public addhistrop()
        {
            InitializeComponent();
        }

        private void addhistrop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.OPERATION". При необходимости она может быть перемещена или удалена.
            this.oPERATIONTableAdapter.Fill(this.dataSet.OPERATION);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";
            try
            {
                using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
                {
                    int v_id = Convert.ToInt32(id_op.SelectedValue);
                    // Создать объект Command для вызова процедуры .
                    System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                    cmd.Connection = ConnectionToOracle;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SADMIN.temp_cur.CREATEHISTORYCURRENCY";

                    // Видом Command является StoredProcedure


                    // Добавить параметр @V_IDOP и настроить его значение = 100.
                    //cmd.Parameters.Add("@V_IDOP", Oracle.ManagedDataAccess.Client.OracleDbType.Int32).Value = v_id;
                    cmd.Parameters.AddWithValue("@V_IDOP", OracleType.Int32).Value = v_id;

                    //регистрация параметра
                    cmd.Parameters["@V_IDOP"].Direction = ParameterDirection.Output;
                    
                    
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("История обновлена");
                }
            }
            catch (System.Data.OracleClient.OracleException eorcl)
            {
                MessageBox.Show("Ошибка в обработке события" + eorcl.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка в обработке события" + exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
