
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDDMMYYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsApp1.DataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientadd_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьредактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.opadd_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.процедураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyst_op = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDtabtn = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histr_op = new System.Windows.Forms.ToolStripMenuItem();
            this.курсВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.oPERATIONTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.OPERATIONTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.изменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDTYPEDataGridViewTextBoxColumn,
            this.dATEDDMMYYDataGridViewTextBoxColumn,
            this.oNUMBERDataGridViewTextBoxColumn,
            this.sUMMDataGridViewTextBoxColumn,
            this.iDUSERDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.oPERATIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDTYPEDataGridViewTextBoxColumn
            // 
            this.iDTYPEDataGridViewTextBoxColumn.DataPropertyName = "ID_TYPE";
            this.iDTYPEDataGridViewTextBoxColumn.HeaderText = "ID_TYPE";
            this.iDTYPEDataGridViewTextBoxColumn.Name = "iDTYPEDataGridViewTextBoxColumn";
            // 
            // dATEDDMMYYDataGridViewTextBoxColumn
            // 
            this.dATEDDMMYYDataGridViewTextBoxColumn.DataPropertyName = "DATE_DDMMYY";
            this.dATEDDMMYYDataGridViewTextBoxColumn.HeaderText = "DATE_DDMMYY";
            this.dATEDDMMYYDataGridViewTextBoxColumn.Name = "dATEDDMMYYDataGridViewTextBoxColumn";
            // 
            // oNUMBERDataGridViewTextBoxColumn
            // 
            this.oNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ONUMBER";
            this.oNUMBERDataGridViewTextBoxColumn.HeaderText = "ONUMBER";
            this.oNUMBERDataGridViewTextBoxColumn.Name = "oNUMBERDataGridViewTextBoxColumn";
            // 
            // sUMMDataGridViewTextBoxColumn
            // 
            this.sUMMDataGridViewTextBoxColumn.DataPropertyName = "SUMM";
            this.sUMMDataGridViewTextBoxColumn.HeaderText = "SUMM";
            this.sUMMDataGridViewTextBoxColumn.Name = "sUMMDataGridViewTextBoxColumn";
            // 
            // iDUSERDataGridViewTextBoxColumn
            // 
            this.iDUSERDataGridViewTextBoxColumn.DataPropertyName = "ID_USER";
            this.iDUSERDataGridViewTextBoxColumn.HeaderText = "ID_USER";
            this.iDUSERDataGridViewTextBoxColumn.Name = "iDUSERDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CUR";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CUR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // oPERATIONBindingSource
            // 
            this.oPERATIONBindingSource.DataMember = "OPERATION";
            this.oPERATIONBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripSplitButton1.Text = "Данные";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientadd_btn,
            this.opadd_btn});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить/Изменить";
            // 
            // clientadd_btn
            // 
            this.clientadd_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьредактироватьToolStripMenuItem,
            this.delete_menu});
            this.clientadd_btn.Name = "clientadd_btn";
            this.clientadd_btn.Size = new System.Drawing.Size(180, 22);
            this.clientadd_btn.Text = "Клиент";
            this.clientadd_btn.Click += new System.EventHandler(this.clientadd_btn_Click);
            // 
            // добавитьредактироватьToolStripMenuItem
            // 
            this.добавитьредактироватьToolStripMenuItem.Name = "добавитьредактироватьToolStripMenuItem";
            this.добавитьредактироватьToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьредактироватьToolStripMenuItem.Text = "Добавить/редактировать";
            this.добавитьредактироватьToolStripMenuItem.Click += new System.EventHandler(this.добавитьредактироватьToolStripMenuItem_Click);
            // 
            // delete_menu
            // 
            this.delete_menu.Name = "delete_menu";
            this.delete_menu.Size = new System.Drawing.Size(211, 22);
            this.delete_menu.Text = "Удалить";
            this.delete_menu.Click += new System.EventHandler(this.delete_menu_Click);
            // 
            // opadd_btn
            // 
            this.opadd_btn.Name = "opadd_btn";
            this.opadd_btn.Size = new System.Drawing.Size(180, 22);
            this.opadd_btn.Text = "Операция";
            this.opadd_btn.Click += new System.EventHandler(this.opadd_btn_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процедураToolStripMenuItem,
            this.UpdateDtabtn,
            this.создатьИсториюToolStripMenuItem,
            this.изменитьПользователяToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButton2.Text = "Сервис";
            // 
            // процедураToolStripMenuItem
            // 
            this.процедураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyst_op});
            this.процедураToolStripMenuItem.Name = "процедураToolStripMenuItem";
            this.процедураToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.процедураToolStripMenuItem.Text = "Отчет";
            // 
            // analyst_op
            // 
            this.analyst_op.Name = "analyst_op";
            this.analyst_op.Size = new System.Drawing.Size(171, 22);
            this.analyst_op.Text = "Анализ операций";
            this.analyst_op.Click += new System.EventHandler(this.analyst_op_Click);
            // 
            // UpdateDtabtn
            // 
            this.UpdateDtabtn.Name = "UpdateDtabtn";
            this.UpdateDtabtn.Size = new System.Drawing.Size(180, 22);
            this.UpdateDtabtn.Text = "Обновить данные";
            this.UpdateDtabtn.Click += new System.EventHandler(this.UpdateDtabtn_Click);
            // 
            // создатьИсториюToolStripMenuItem
            // 
            this.создатьИсториюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histr_op,
            this.курсВалютToolStripMenuItem});
            this.создатьИсториюToolStripMenuItem.Name = "создатьИсториюToolStripMenuItem";
            this.создатьИсториюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьИсториюToolStripMenuItem.Text = "Создать историю";
            // 
            // histr_op
            // 
            this.histr_op.Name = "histr_op";
            this.histr_op.Size = new System.Drawing.Size(136, 22);
            this.histr_op.Text = "Операция";
            this.histr_op.Click += new System.EventHandler(this.histr_op_Click);
            // 
            // курсВалютToolStripMenuItem
            // 
            this.курсВалютToolStripMenuItem.Name = "курсВалютToolStripMenuItem";
            this.курсВалютToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.курсВалютToolStripMenuItem.Text = "курс валют";
            this.курсВалютToolStripMenuItem.Click += new System.EventHandler(this.курсВалютToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Выход";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // oPERATIONTableAdapter
            // 
            this.oPERATIONTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(667, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profile:";
            // 
            // изменитьПользователяToolStripMenuItem
            // 
            this.изменитьПользователяToolStripMenuItem.Name = "изменитьПользователяToolStripMenuItem";
            this.изменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.изменитьПользователяToolStripMenuItem.Text = "Изменить пользователя";
            this.изменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.изменитьПользователяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUR_EXCHANGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientadd_btn;
        private System.Windows.Forms.ToolStripMenuItem opadd_btn;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
       // private DataSet1TableAdapters.OPERATIONTableAdapter oPERATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBEROPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem процедураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyst_op;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource oPERATIONBindingSource;
        private DataSetTableAdapters.OPERATIONTableAdapter oPERATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDDMMYYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem UpdateDtabtn;
        private System.Windows.Forms.ToolStripMenuItem создатьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histr_op;
        private System.Windows.Forms.ToolStripMenuItem курсВалютToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem добавитьредактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem изменитьПользователяToolStripMenuItem;
    }
}

