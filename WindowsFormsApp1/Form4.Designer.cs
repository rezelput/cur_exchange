
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet = new WindowsFormsApp1.DataSet();
            this.hISTORYOPERATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORY_OPERATTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.HISTORY_OPERATTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTTCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDDMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYOPERATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDTTCHDataGridViewTextBoxColumn,
            this.dATEDDMMDataGridViewTextBoxColumn,
            this.sUMMDataGridViewTextBoxColumn,
            this.iDUSERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hISTORYOPERATBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISTORYOPERATBindingSource
            // 
            this.hISTORYOPERATBindingSource.DataMember = "HISTORY_OPERAT";
            this.hISTORYOPERATBindingSource.DataSource = this.dataSet;
            // 
            // hISTORY_OPERATTableAdapter
            // 
            this.hISTORY_OPERATTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDTTCHDataGridViewTextBoxColumn
            // 
            this.iDTTCHDataGridViewTextBoxColumn.DataPropertyName = "ID_TT_CH";
            this.iDTTCHDataGridViewTextBoxColumn.HeaderText = "ID_TT_CH";
            this.iDTTCHDataGridViewTextBoxColumn.Name = "iDTTCHDataGridViewTextBoxColumn";
            // 
            // dATEDDMMDataGridViewTextBoxColumn
            // 
            this.dATEDDMMDataGridViewTextBoxColumn.DataPropertyName = "DATE_DDMM";
            this.dATEDDMMDataGridViewTextBoxColumn.HeaderText = "DATE_DDMM";
            this.dATEDDMMDataGridViewTextBoxColumn.Name = "dATEDDMMDataGridViewTextBoxColumn";
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
            // close
            // 
            this.close.Location = new System.Drawing.Point(481, 385);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 418);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "ИСТОРИЯ ОПЕРАЦИЙ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYOPERATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource hISTORYOPERATBindingSource;
        private DataSetTableAdapters.HISTORY_OPERATTableAdapter hISTORY_OPERATTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTTCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDDMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button close;
    }
}