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
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.HISTORY_OPERAT". При необходимости она может быть перемещена или удалена.
            this.hISTORY_OPERATTableAdapter.Fill(this.dataSet.HISTORY_OPERAT);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
