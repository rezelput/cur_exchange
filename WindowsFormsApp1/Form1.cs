﻿using System;
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

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oPERATIONBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}