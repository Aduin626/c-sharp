namespace Работа_с_базами_данных_MySQL
{
    partial class CustomerMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonViewAssortiment = new System.Windows.Forms.Button();
            this.buttonViewOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(265, 343);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(219, 78);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню заказчика";
            // 
            // buttonViewAssortiment
            // 
            this.buttonViewAssortiment.Location = new System.Drawing.Point(265, 134);
            this.buttonViewAssortiment.Name = "buttonViewAssortiment";
            this.buttonViewAssortiment.Size = new System.Drawing.Size(219, 51);
            this.buttonViewAssortiment.TabIndex = 2;
            this.buttonViewAssortiment.Text = "Просмотр ассортимента";
            this.buttonViewAssortiment.UseVisualStyleBackColor = true;
            this.buttonViewAssortiment.Click += new System.EventHandler(this.buttonViewAssortiment_Click);
            // 
            // buttonViewOrders
            // 
            this.buttonViewOrders.Location = new System.Drawing.Point(265, 229);
            this.buttonViewOrders.Name = "buttonViewOrders";
            this.buttonViewOrders.Size = new System.Drawing.Size(219, 68);
            this.buttonViewOrders.TabIndex = 3;
            this.buttonViewOrders.Text = "Просмотр заказов";
            this.buttonViewOrders.UseVisualStyleBackColor = true;
            this.buttonViewOrders.Click += new System.EventHandler(this.buttonViewOrders_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewOrders);
            this.Controls.Add(this.buttonViewAssortiment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonViewAssortiment;
        private System.Windows.Forms.Button buttonViewOrders;
    }
}