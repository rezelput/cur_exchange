
namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddOp = new System.Windows.Forms.ToolStripButton();
            this.CloseFr3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsBox = new System.Windows.Forms.ComboBox();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsApp1.DataSet();
            this.changeCur = new System.Windows.Forms.ComboBox();
            this.cURRENCYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.opnum = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeop_box = new System.Windows.Forms.ComboBox();
            this.tYPEOPERATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.id_op = new System.Windows.Forms.TextBox();
            this.cURRENCYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPE_OPERATIONTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.TYPE_OPERATIONTableAdapter();
            this.cURRENCYTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.CURRENCYTableAdapter();
            this.uSERSTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.USERSTableAdapter();
            this.CurOpSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sum_cur = new System.Windows.Forms.Button();
            this.curruncy = new System.Windows.Forms.Label();
            this.rus_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currency = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEOPERATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOp,
            this.CloseFr3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddOp
            // 
            this.AddOp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddOp.Image = ((System.Drawing.Image)(resources.GetObject("AddOp.Image")));
            this.AddOp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddOp.Name = "AddOp";
            this.AddOp.Size = new System.Drawing.Size(54, 22);
            this.AddOp.Text = "Создать";
            this.AddOp.Click += new System.EventHandler(this.AddOp_Click);
            // 
            // CloseFr3
            // 
            this.CloseFr3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseFr3.Image = ((System.Drawing.Image)(resources.GetObject("CloseFr3.Image")));
            this.CloseFr3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseFr3.Name = "CloseFr3";
            this.CloseFr3.Size = new System.Drawing.Size(23, 22);
            this.CloseFr3.Text = "toolStripButton1";
            this.CloseFr3.Click += new System.EventHandler(this.CloseFr3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.UsBox);
            this.groupBox1.Controls.Add(this.changeCur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.opnum);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.typeop_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id_op);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить данные операции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Выбрать клиента ";
            // 
            // UsBox
            // 
            this.UsBox.DataSource = this.uSERSBindingSource;
            this.UsBox.DisplayMember = "LOGIN";
            this.UsBox.FormattingEnabled = true;
            this.UsBox.Location = new System.Drawing.Point(31, 290);
            this.UsBox.Name = "UsBox";
            this.UsBox.Size = new System.Drawing.Size(121, 21);
            this.UsBox.TabIndex = 6;
            this.UsBox.ValueMember = "ID";
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // changeCur
            // 
            this.changeCur.DataSource = this.cURRENCYBindingSource1;
            this.changeCur.DisplayMember = "NAME";
            this.changeCur.FormattingEnabled = true;
            this.changeCur.Location = new System.Drawing.Point(31, 239);
            this.changeCur.Name = "changeCur";
            this.changeCur.Size = new System.Drawing.Size(121, 21);
            this.changeCur.TabIndex = 5;
            this.changeCur.ValueMember = "ID";
            this.changeCur.SelectedIndexChanged += new System.EventHandler(this.changeCur_SelectedIndexChanged);
            // 
            // cURRENCYBindingSource1
            // 
            this.cURRENCYBindingSource1.DataMember = "CURRENCY";
            this.cURRENCYBindingSource1.DataSource = this.dataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер операции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Выбрать Валюту";
            // 
            // opnum
            // 
            this.opnum.Location = new System.Drawing.Point(31, 181);
            this.opnum.Name = "opnum";
            this.opnum.Size = new System.Drawing.Size(138, 20);
            this.opnum.TabIndex = 5;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(31, 120);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(204, 20);
            this.date.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата операции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип операции";
            // 
            // typeop_box
            // 
            this.typeop_box.DataSource = this.tYPEOPERATIONBindingSource;
            this.typeop_box.DisplayMember = "NAME";
            this.typeop_box.FormattingEnabled = true;
            this.typeop_box.Location = new System.Drawing.Point(111, 59);
            this.typeop_box.Name = "typeop_box";
            this.typeop_box.Size = new System.Drawing.Size(121, 21);
            this.typeop_box.TabIndex = 2;
            this.typeop_box.ValueMember = "ID";
            // 
            // tYPEOPERATIONBindingSource
            // 
            this.tYPEOPERATIONBindingSource.DataMember = "TYPE_OPERATION";
            this.tYPEOPERATIONBindingSource.DataSource = this.dataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // id_op
            // 
            this.id_op.Location = new System.Drawing.Point(31, 59);
            this.id_op.Name = "id_op";
            this.id_op.Size = new System.Drawing.Size(57, 20);
            this.id_op.TabIndex = 0;
            // 
            // cURRENCYBindingSource
            // 
            this.cURRENCYBindingSource.DataMember = "CURRENCY";
            this.cURRENCYBindingSource.DataSource = this.dataSet;
            // 
            // tYPE_OPERATIONTableAdapter
            // 
            this.tYPE_OPERATIONTableAdapter.ClearBeforeFill = true;
            // 
            // cURRENCYTableAdapter
            // 
            this.cURRENCYTableAdapter.ClearBeforeFill = true;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // CurOpSum
            // 
            this.CurOpSum.Location = new System.Drawing.Point(23, 47);
            this.CurOpSum.Name = "CurOpSum";
            this.CurOpSum.Size = new System.Drawing.Size(100, 20);
            this.CurOpSum.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Сумма";
            // 
            // Sum_cur
            // 
            this.Sum_cur.Location = new System.Drawing.Point(173, 145);
            this.Sum_cur.Name = "Sum_cur";
            this.Sum_cur.Size = new System.Drawing.Size(89, 31);
            this.Sum_cur.TabIndex = 9;
            this.Sum_cur.Text = "Рассчитать";
            this.Sum_cur.UseVisualStyleBackColor = true;
            this.Sum_cur.Click += new System.EventHandler(this.Sum_cur_Click);
            // 
            // curruncy
            // 
            this.curruncy.AutoSize = true;
            this.curruncy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curruncy.Location = new System.Drawing.Point(306, 51);
            this.curruncy.Name = "curruncy";
            this.curruncy.Size = new System.Drawing.Size(106, 13);
            this.curruncy.TabIndex = 10;
            this.curruncy.Text = "Курс валюты, (1:1) :";
            this.curruncy.Click += new System.EventHandler(this.label8_Click);
            // 
            // rus_box
            // 
            this.rus_box.Location = new System.Drawing.Point(23, 100);
            this.rus_box.Name = "rus_box";
            this.rus_box.Size = new System.Drawing.Size(62, 20);
            this.rus_box.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "В рубл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sum_cur);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CurOpSum);
            this.groupBox2.Controls.Add(this.rus_box);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(309, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 184);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сумма операции";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(418, 48);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(98, 20);
            this.currency.TabIndex = 15;
            this.currency.TextChanged += new System.EventHandler(this.currency_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 397);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.curruncy);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДОБАВИТЬ ОПЕРАЦИЮ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEOPERATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typeop_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton AddOp;
        private System.Windows.Forms.ToolStripButton CloseFr3;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tYPEOPERATIONBindingSource;
        private DataSetTableAdapters.TYPE_OPERATIONTableAdapter tYPE_OPERATIONTableAdapter;
        private System.Windows.Forms.BindingSource cURRENCYBindingSource;
        private DataSetTableAdapters.CURRENCYTableAdapter cURRENCYTableAdapter;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private DataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CurOpSum;
        private System.Windows.Forms.Button Sum_cur;
        private System.Windows.Forms.Label curruncy;
        private System.Windows.Forms.TextBox rus_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource cURRENCYBindingSource1;
        private System.Windows.Forms.TextBox currency;
        public System.Windows.Forms.TextBox id_op;
        public System.Windows.Forms.ComboBox changeCur;

        //private DataSet5TableAdapters.CURRENCYTableAdapter cURRENCYTableAdapter;
        //private DataSet4TableAdapters.TYPE_OPTableAdapter tYPE_OPTableAdapter;
        // private DataSet5 dataSet5;
    }
}