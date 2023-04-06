namespace Работа_с_базами_данных_MySQL
{
    partial class ListUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonotbor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpenAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Не выбрано",
            "Администратор ",
            "Заказчик"});
            this.comboBox1.Location = new System.Drawing.Point(568, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonotbor
            // 
            this.buttonotbor.Location = new System.Drawing.Point(568, 213);
            this.buttonotbor.Name = "buttonotbor";
            this.buttonotbor.Size = new System.Drawing.Size(133, 49);
            this.buttonotbor.TabIndex = 2;
            this.buttonotbor.Text = "Отбор";
            this.buttonotbor.UseVisualStyleBackColor = true;
            this.buttonotbor.Click += new System.EventHandler(this.buttonotbor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список пользователей";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(567, 366);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(182, 50);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOpenAddUser
            // 
            this.buttonOpenAddUser.Location = new System.Drawing.Point(567, 300);
            this.buttonOpenAddUser.Name = "buttonOpenAddUser";
            this.buttonOpenAddUser.Size = new System.Drawing.Size(182, 48);
            this.buttonOpenAddUser.TabIndex = 5;
            this.buttonOpenAddUser.Text = "Создать нового пользователя";
            this.buttonOpenAddUser.UseVisualStyleBackColor = true;
            this.buttonOpenAddUser.Click += new System.EventHandler(this.buttonOpenAddUser_Click);
            // 
            // ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenAddUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonotbor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListUser";
            this.Text = "ListUser";
            this.Load += new System.EventHandler(this.ListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonotbor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOpenAddUser;
    }
}