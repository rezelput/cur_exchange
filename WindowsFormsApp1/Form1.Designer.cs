
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
            this.opadd_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.процедураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyst_op = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDtabtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.oPERATIONTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.OPERATIONTableAdapter();
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
            this.dataGridView1.Location = new System.Drawing.Point(334, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 382);
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
            this.clientadd_btn.Name = "clientadd_btn";
            this.clientadd_btn.Size = new System.Drawing.Size(129, 22);
            this.clientadd_btn.Text = "Клиент";
            this.clientadd_btn.Click += new System.EventHandler(this.clientadd_btn_Click);
            // 
            // opadd_btn
            // 
            this.opadd_btn.Name = "opadd_btn";
            this.opadd_btn.Size = new System.Drawing.Size(129, 22);
            this.opadd_btn.Text = "Операция";
            this.opadd_btn.Click += new System.EventHandler(this.opadd_btn_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процедураToolStripMenuItem,
            this.UpdateDtabtn});
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
            this.analyst_op.Size = new System.Drawing.Size(180, 22);
            this.analyst_op.Text = "Анализ операций";
            this.analyst_op.Click += new System.EventHandler(this.analyst_op_Click);
            // 
            // UpdateDtabtn
            // 
            this.UpdateDtabtn.Name = "UpdateDtabtn";
            this.UpdateDtabtn.Size = new System.Drawing.Size(172, 22);
            this.UpdateDtabtn.Text = "Обновить данные";
            this.UpdateDtabtn.Click += new System.EventHandler(this.UpdateDtabtn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

