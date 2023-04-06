namespace Работа_с_базами_данных_MySQL
{
    partial class AddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxinputUser = new System.Windows.Forms.TextBox();
            this.textBoxinputName = new System.Windows.Forms.TextBox();
            this.textBoxinputEmail = new System.Windows.Forms.TextBox();
            this.textBoxinputAddress = new System.Windows.Forms.TextBox();
            this.TextBoxinputPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление заказчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(344, 307);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(113, 23);
            this.buttonAddCustomer.TabIndex = 6;
            this.buttonAddCustomer.Text = "Добавить";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(344, 367);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxinputUser
            // 
            this.textBoxinputUser.Location = new System.Drawing.Point(94, 133);
            this.textBoxinputUser.Name = "textBoxinputUser";
            this.textBoxinputUser.Size = new System.Drawing.Size(158, 22);
            this.textBoxinputUser.TabIndex = 8;
            // 
            // textBoxinputName
            // 
            this.textBoxinputName.Location = new System.Drawing.Point(94, 213);
            this.textBoxinputName.Name = "textBoxinputName";
            this.textBoxinputName.Size = new System.Drawing.Size(158, 22);
            this.textBoxinputName.TabIndex = 9;
            // 
            // textBoxinputEmail
            // 
            this.textBoxinputEmail.Location = new System.Drawing.Point(606, 133);
            this.textBoxinputEmail.Name = "textBoxinputEmail";
            this.textBoxinputEmail.Size = new System.Drawing.Size(124, 22);
            this.textBoxinputEmail.TabIndex = 11;
            // 
            // textBoxinputAddress
            // 
            this.textBoxinputAddress.Location = new System.Drawing.Point(606, 213);
            this.textBoxinputAddress.Name = "textBoxinputAddress";
            this.textBoxinputAddress.Size = new System.Drawing.Size(124, 22);
            this.textBoxinputAddress.TabIndex = 12;
            // 
            // TextBoxinputPhone
            // 
            this.TextBoxinputPhone.Location = new System.Drawing.Point(94, 272);
            this.TextBoxinputPhone.Mask = "+7(999)-999-99-99";
            this.TextBoxinputPhone.Name = "TextBoxinputPhone";
            this.TextBoxinputPhone.Size = new System.Drawing.Size(158, 22);
            this.TextBoxinputPhone.TabIndex = 13;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxinputPhone);
            this.Controls.Add(this.textBoxinputAddress);
            this.Controls.Add(this.textBoxinputEmail);
            this.Controls.Add(this.textBoxinputName);
            this.Controls.Add(this.textBoxinputUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxinputUser;
        private System.Windows.Forms.TextBox textBoxinputName;
        private System.Windows.Forms.TextBox textBoxinputEmail;
        private System.Windows.Forms.TextBox textBoxinputAddress;
        private System.Windows.Forms.MaskedTextBox TextBoxinputPhone;
    }
}