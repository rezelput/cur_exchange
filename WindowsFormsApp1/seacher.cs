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
    public partial class seacher : Form
    {
        public seacher()
        {
            InitializeComponent();
        }

        Form1 ff = new Form1();


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ff.dataGridView1.RowCount; i++)
            {
                ff.dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < ff.dataGridView1.ColumnCount; j++)
                    if (ff.dataGridView1.Rows[i].Cells[j].Value != null)
                        if (ff.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ff.dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
