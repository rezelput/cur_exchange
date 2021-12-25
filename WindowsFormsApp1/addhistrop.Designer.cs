
namespace WindowsFormsApp1
{
    partial class addhistrop
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
            this.id_op = new System.Windows.Forms.ComboBox();
            this.oPERATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsApp1.DataSet();
            this.oPERATIONTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.OPERATIONTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oPERATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_op
            // 
            this.id_op.DataSource = this.oPERATIONBindingSource;
            this.id_op.DisplayMember = "ID";
            this.id_op.FormattingEnabled = true;
            this.id_op.Location = new System.Drawing.Point(62, 25);
            this.id_op.Name = "id_op";
            this.id_op.Size = new System.Drawing.Size(121, 21);
            this.id_op.TabIndex = 0;
            this.id_op.ValueMember = "ID";
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
            // oPERATIONTableAdapter
            // 
            this.oPERATIONTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addhistrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 99);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_op);
            this.Name = "addhistrop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addhistrop";
            this.Load += new System.EventHandler(this.addhistrop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPERATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox id_op;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource oPERATIONBindingSource;
        private DataSetTableAdapters.OPERATIONTableAdapter oPERATIONTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}