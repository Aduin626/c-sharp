namespace Работа_с_базами_данных_MySQL
{
    partial class AdminMenu
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListUser = new System.Windows.Forms.Button();
            this.buttonCustomerManagement = new System.Windows.Forms.Button();
            this.buttonWarehousemanagement = new System.Windows.Forms.Button();
            this.buttonViewSales = new System.Windows.Forms.Button();
            this.buttonViewAssortiment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(253, 462);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(266, 48);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(182, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню администратора ";
            // 
            // buttonListUser
            // 
            this.buttonListUser.Location = new System.Drawing.Point(253, 93);
            this.buttonListUser.Name = "buttonListUser";
            this.buttonListUser.Size = new System.Drawing.Size(266, 48);
            this.buttonListUser.TabIndex = 2;
            this.buttonListUser.Text = "Список пользователей";
            this.buttonListUser.UseVisualStyleBackColor = true;
            this.buttonListUser.Click += new System.EventHandler(this.buttonListUser_Click);
            // 
            // buttonCustomerManagement
            // 
            this.buttonCustomerManagement.Location = new System.Drawing.Point(253, 161);
            this.buttonCustomerManagement.Name = "buttonCustomerManagement";
            this.buttonCustomerManagement.Size = new System.Drawing.Size(266, 55);
            this.buttonCustomerManagement.TabIndex = 3;
            this.buttonCustomerManagement.Text = "Управление заказчиками";
            this.buttonCustomerManagement.UseVisualStyleBackColor = true;
            this.buttonCustomerManagement.Click += new System.EventHandler(this.buttonCustomerManagement_Click);
            // 
            // buttonWarehousemanagement
            // 
            this.buttonWarehousemanagement.Location = new System.Drawing.Point(253, 237);
            this.buttonWarehousemanagement.Name = "buttonWarehousemanagement";
            this.buttonWarehousemanagement.Size = new System.Drawing.Size(266, 49);
            this.buttonWarehousemanagement.TabIndex = 4;
            this.buttonWarehousemanagement.Text = "Управление складом";
            this.buttonWarehousemanagement.UseVisualStyleBackColor = true;
            this.buttonWarehousemanagement.Click += new System.EventHandler(this.buttonWarehousemanagement_Click);
            // 
            // buttonViewSales
            // 
            this.buttonViewSales.Location = new System.Drawing.Point(253, 305);
            this.buttonViewSales.Name = "buttonViewSales";
            this.buttonViewSales.Size = new System.Drawing.Size(266, 37);
            this.buttonViewSales.TabIndex = 5;
            this.buttonViewSales.Text = "Просмотр продаж";
            this.buttonViewSales.UseVisualStyleBackColor = true;
            this.buttonViewSales.Click += new System.EventHandler(this.buttonViewSales_Click);
            // 
            // buttonViewAssortiment
            // 
            this.buttonViewAssortiment.Location = new System.Drawing.Point(253, 377);
            this.buttonViewAssortiment.Name = "buttonViewAssortiment";
            this.buttonViewAssortiment.Size = new System.Drawing.Size(266, 52);
            this.buttonViewAssortiment.TabIndex = 6;
            this.buttonViewAssortiment.Text = "Просмотр ассортимента";
            this.buttonViewAssortiment.UseVisualStyleBackColor = true;
            this.buttonViewAssortiment.Click += new System.EventHandler(this.buttonViewAssortiment_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.buttonViewAssortiment);
            this.Controls.Add(this.buttonViewSales);
            this.Controls.Add(this.buttonWarehousemanagement);
            this.Controls.Add(this.buttonCustomerManagement);
            this.Controls.Add(this.buttonListUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListUser;
        private System.Windows.Forms.Button buttonCustomerManagement;
        private System.Windows.Forms.Button buttonWarehousemanagement;
        private System.Windows.Forms.Button buttonViewSales;
        private System.Windows.Forms.Button buttonViewAssortiment;
    }
}