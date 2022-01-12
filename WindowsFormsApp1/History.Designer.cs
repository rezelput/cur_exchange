
namespace WindowsFormsApp1
{
    partial class History
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
            this.id_htr = new System.Windows.Forms.ComboBox();
            this.oPERATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsApp1.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.oPERATIONTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.OPERATIONTableAdapter();
            this.type_update = new System.Windows.Forms.ComboBox();
            this.tYPEUPDATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tYPE_UPDATETableAdapter = new WindowsFormsApp1.DataSetTableAdapters.TYPE_UPDATETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.ComboBox();
            this.user_id = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.oPERATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEUPDATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_htr
            // 
            this.id_htr.DataSource = this.oPERATIONBindingSource;
            this.id_htr.DisplayMember = "ID";
            this.id_htr.FormattingEnabled = true;
            this.id_htr.Location = new System.Drawing.Point(31, 93);
            this.id_htr.Name = "id_htr";
            this.id_htr.Size = new System.Drawing.Size(121, 21);
            this.id_htr.TabIndex = 0;
            this.id_htr.ValueMember = "ID";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "идентификатор операции";
            // 
            // oPERATIONTableAdapter
            // 
            this.oPERATIONTableAdapter.ClearBeforeFill = true;
            // 
            // type_update
            // 
            this.type_update.DataSource = this.tYPEUPDATEBindingSource;
            this.type_update.DisplayMember = "NAME";
            this.type_update.FormattingEnabled = true;
            this.type_update.Location = new System.Drawing.Point(31, 152);
            this.type_update.Name = "type_update";
            this.type_update.Size = new System.Drawing.Size(121, 21);
            this.type_update.TabIndex = 2;
            this.type_update.ValueMember = "ID";
            // 
            // tYPEUPDATEBindingSource
            // 
            this.tYPEUPDATEBindingSource.DataMember = "TYPE_UPDATE";
            this.tYPEUPDATEBindingSource.DataSource = this.dataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "тип обновления";
            // 
            // tYPE_UPDATETableAdapter
            // 
            this.tYPE_UPDATETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "сумма операции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "пользователь";
            // 
            // sumBox
            // 
            this.sumBox.DataSource = this.oPERATIONBindingSource;
            this.sumBox.DisplayMember = "SUMM";
            this.sumBox.FormattingEnabled = true;
            this.sumBox.Location = new System.Drawing.Point(192, 93);
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(121, 21);
            this.sumBox.TabIndex = 6;
            this.sumBox.ValueMember = "SUMM";
            // 
            // user_id
            // 
            this.user_id.DataSource = this.oPERATIONBindingSource;
            this.user_id.DisplayMember = "ID_USER";
            this.user_id.FormattingEnabled = true;
            this.user_id.Location = new System.Drawing.Point(192, 151);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(121, 21);
            this.user_id.TabIndex = 7;
            this.user_id.ValueMember = "ID_USER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(229, 1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // HistoryOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 276);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_htr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryOP";
            this.Text = "СОЗДАТЬ ИСТОРИЮ ОПЕРАЦИИ";
            this.Load += new System.EventHandler(this.HistoryOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPERATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEUPDATEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox id_htr;
        private System.Windows.Forms.Label label1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource oPERATIONBindingSource;
        private DataSetTableAdapters.OPERATIONTableAdapter oPERATIONTableAdapter;
        private System.Windows.Forms.ComboBox type_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tYPEUPDATEBindingSource;
        private DataSetTableAdapters.TYPE_UPDATETableAdapter tYPE_UPDATETableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sumBox;
        private System.Windows.Forms.ComboBox user_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}