
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Grp_Add = new System.Windows.Forms.GroupBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsApp1.DataSet();
            this.addbtn = new System.Windows.Forms.RadioButton();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Grp_Edit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updatebtn = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFr2 = new System.Windows.Forms.ToolStripButton();
            this.cITYTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.CITYTableAdapter();
            this.uSERSTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.USERSTableAdapter();
            this.cOUNTRYTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.COUNTRYTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.name_ff_box = new System.Windows.Forms.TextBox();
            this.watch_client = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grp_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            this.Grp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Add
            // 
            this.Grp_Add.Controls.Add(this.login_box);
            this.Grp_Add.Controls.Add(this.label5);
            this.Grp_Add.Controls.Add(this.textBox3);
            this.Grp_Add.Controls.Add(this.label3);
            this.Grp_Add.Controls.Add(this.textBox2);
            this.Grp_Add.Controls.Add(this.label2);
            this.Grp_Add.Controls.Add(this.label1);
            this.Grp_Add.Controls.Add(this.comboBox1);
            this.Grp_Add.Controls.Add(this.addbtn);
            this.Grp_Add.Location = new System.Drawing.Point(40, 97);
            this.Grp_Add.Name = "Grp_Add";
            this.Grp_Add.Size = new System.Drawing.Size(332, 320);
            this.Grp_Add.TabIndex = 0;
            this.Grp_Add.TabStop = false;
            this.Grp_Add.Text = "Добавить";
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(198, 96);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(97, 20);
            this.login_box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Идентификатор клиента";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя пользователя (полное)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать страну";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cOUNTRYBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID";
            // 
            // cOUNTRYBindingSource
            // 
            this.cOUNTRYBindingSource.DataMember = "COUNTRY";
            this.cOUNTRYBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addbtn
            // 
            this.addbtn.AutoSize = true;
            this.addbtn.Location = new System.Drawing.Point(25, 32);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 17);
            this.addbtn.TabIndex = 0;
            this.addbtn.TabStop = true;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.CheckedChanged += new System.EventHandler(this.addbtn_CheckedChanged);
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.dataSet;
            // 
            // Grp_Edit
            // 
            this.Grp_Edit.Controls.Add(this.checkBox2);
            this.Grp_Edit.Controls.Add(this.checkBox1);
            this.Grp_Edit.Controls.Add(this.label7);
            this.Grp_Edit.Controls.Add(this.comboBox3);
            this.Grp_Edit.Controls.Add(this.label6);
            this.Grp_Edit.Controls.Add(this.name_ff_box);
            this.Grp_Edit.Controls.Add(this.label4);
            this.Grp_Edit.Controls.Add(this.comboBox2);
            this.Grp_Edit.Controls.Add(this.updatebtn);
            this.Grp_Edit.Location = new System.Drawing.Point(407, 97);
            this.Grp_Edit.Name = "Grp_Edit";
            this.Grp_Edit.Size = new System.Drawing.Size(270, 320);
            this.Grp_Edit.TabIndex = 1;
            this.Grp_Edit.TabStop = false;
            this.Grp_Edit.Text = "Изменить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пользователь";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.uSERSBindingSource;
            this.comboBox2.DisplayMember = "LOGIN";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID";
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.dataSet;
            // 
            // updatebtn
            // 
            this.updatebtn.AutoSize = true;
            this.updatebtn.Location = new System.Drawing.Point(28, 32);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(76, 17);
            this.updatebtn.TabIndex = 0;
            this.updatebtn.TabStop = true;
            this.updatebtn.Text = "Изменить";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.CheckedChanged += new System.EventHandler(this.updatebtn_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.watch_client,
            this.CloseFr2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.очиститьФормыToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripSplitButton1.Text = "Данные";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // очиститьФормыToolStripMenuItem
            // 
            this.очиститьФормыToolStripMenuItem.Name = "очиститьФормыToolStripMenuItem";
            this.очиститьФормыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьФормыToolStripMenuItem.Text = "Очистить формы";
            this.очиститьФормыToolStripMenuItem.Click += new System.EventHandler(this.очиститьФормыToolStripMenuItem_Click);
            // 
            // CloseFr2
            // 
            this.CloseFr2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CloseFr2.Image = ((System.Drawing.Image)(resources.GetObject("CloseFr2.Image")));
            this.CloseFr2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseFr2.Name = "CloseFr2";
            this.CloseFr2.Size = new System.Drawing.Size(57, 22);
            this.CloseFr2.Text = "Закрыть";
            this.CloseFr2.Click += new System.EventHandler(this.CloseFr2_Click);
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // cOUNTRYTableAdapter
            // 
            this.cOUNTRYTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Имя пользователя (полное)";
            // 
            // name_ff_box
            // 
            this.name_ff_box.Location = new System.Drawing.Point(28, 158);
            this.name_ff_box.Name = "name_ff_box";
            this.name_ff_box.Size = new System.Drawing.Size(151, 20);
            this.name_ff_box.TabIndex = 10;
            // 
            // watch_client
            // 
            this.watch_client.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.watch_client.Image = ((System.Drawing.Image)(resources.GetObject("watch_client.Image")));
            this.watch_client.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.watch_client.Name = "watch_client";
            this.watch_client.Size = new System.Drawing.Size(68, 22);
            this.watch_client.Text = "Просмотр";
            this.watch_client.Click += new System.EventHandler(this.watch_client_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Выбрать страну";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.cOUNTRYBindingSource;
            this.comboBox3.DisplayMember = "NAME";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(28, 205);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.ValueMember = "ID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(185, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Grp_Edit);
            this.Controls.Add(this.Grp_Add);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДОБАВИТЬ/ИЗМЕНИТЬ \"КЛИЕНТ\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Grp_Add.ResumeLayout(false);
            this.Grp_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            this.Grp_Edit.ResumeLayout(false);
            this.Grp_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Add;
        private System.Windows.Forms.RadioButton addbtn;
        private System.Windows.Forms.ComboBox comboBox1;
       // private DataSet2TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.Label label1;
       // private DataSet3TableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Grp_Edit;
        private System.Windows.Forms.RadioButton updatebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьФормыToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton CloseFr2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private DataSetTableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private DataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.BindingSource cOUNTRYBindingSource;
        private DataSetTableAdapters.COUNTRYTableAdapter cOUNTRYTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_ff_box;
        private System.Windows.Forms.ToolStripButton watch_client;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
    }
}