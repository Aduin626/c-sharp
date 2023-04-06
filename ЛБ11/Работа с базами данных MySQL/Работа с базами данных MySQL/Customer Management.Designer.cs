namespace Работа_с_базами_данных_MySQL
{
    partial class Customer_Management
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenAddCustomer = new System.Windows.Forms.Button();
            this.buttonOpenEditCustomer = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBoxinputValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExecQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(619, 465);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление заказчиками ";
            // 
            // buttonOpenAddCustomer
            // 
            this.buttonOpenAddCustomer.Location = new System.Drawing.Point(619, 75);
            this.buttonOpenAddCustomer.Name = "buttonOpenAddCustomer";
            this.buttonOpenAddCustomer.Size = new System.Drawing.Size(152, 51);
            this.buttonOpenAddCustomer.TabIndex = 3;
            this.buttonOpenAddCustomer.Text = "Добавить нового заказчика ";
            this.buttonOpenAddCustomer.UseVisualStyleBackColor = true;
            this.buttonOpenAddCustomer.Click += new System.EventHandler(this.buttonOpenAddCustomer_Click);
            // 
            // buttonOpenEditCustomer
            // 
            this.buttonOpenEditCustomer.Location = new System.Drawing.Point(619, 143);
            this.buttonOpenEditCustomer.Name = "buttonOpenEditCustomer";
            this.buttonOpenEditCustomer.Size = new System.Drawing.Size(152, 51);
            this.buttonOpenEditCustomer.TabIndex = 4;
            this.buttonOpenEditCustomer.Text = "Редактирование заказчика";
            this.buttonOpenEditCustomer.UseVisualStyleBackColor = true;
            this.buttonOpenEditCustomer.Click += new System.EventHandler(this.buttonOpenEditCustomer_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(619, 209);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(152, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(619, 252);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить заказчика";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Пользователь",
            "Имя",
            "Телефон",
            "Почта",
            "Адрес"});
            this.comboBox.Location = new System.Drawing.Point(623, 314);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(148, 24);
            this.comboBox.TabIndex = 7;
            // 
            // textBoxinputValue
            // 
            this.textBoxinputValue.Location = new System.Drawing.Point(619, 372);
            this.textBoxinputValue.Name = "textBoxinputValue";
            this.textBoxinputValue.Size = new System.Drawing.Size(152, 22);
            this.textBoxinputValue.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите поле для отбора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите значение поля";
            // 
            // buttonExecQuery
            // 
            this.buttonExecQuery.Location = new System.Drawing.Point(619, 410);
            this.buttonExecQuery.Name = "buttonExecQuery";
            this.buttonExecQuery.Size = new System.Drawing.Size(152, 23);
            this.buttonExecQuery.TabIndex = 11;
            this.buttonExecQuery.Text = "Выполнить отбор";
            this.buttonExecQuery.UseVisualStyleBackColor = true;
            this.buttonExecQuery.Click += new System.EventHandler(this.buttonExecQuery_Click);
            // 
            // Customer_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.buttonExecQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxinputValue);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonOpenEditCustomer);
            this.Controls.Add(this.buttonOpenAddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Management";
            this.Text = "Customer_Management";
            this.Load += new System.EventHandler(this.Customer_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenAddCustomer;
        private System.Windows.Forms.Button buttonOpenEditCustomer;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBoxinputValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExecQuery;
    }
}