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
    public partial class delete_form : Form
    {
        public delete_form()
        {
            InitializeComponent();
        }

        const string connectionString = "Data Source = localhost:1521/temp_cur; User ID=SADMIN;password=pwd123";

        private void delete_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id_b = Convert.ToInt32(comboBox1.SelectedValue);
                MessageBoxButtons msb = MessageBoxButtons.YesNo;
                String message = "Удалить запись?";
                String caption = "Сообщение удаления данных";
                if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                    this.Close();
                using (System.Data.OracleClient.OracleConnection ConnectionToOracle = new System.Data.OracleClient.OracleConnection(connectionString))
                {
                    System.Data.OracleClient.OracleCommand cmd = new System.Data.OracleClient.OracleCommand();
                    cmd.CommandText = "DELETE FROM USERS WHERE ID=:ID";
                    cmd.Connection = ConnectionToOracle;
                    cmd.Parameters.AddWithValue("ID", id_b);

                    ConnectionToOracle.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Запись удалена");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка в обработке события" + exp.Message);
            }

            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
