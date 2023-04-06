namespace Работа_с_базами_данных_MySQL
{
    partial class CheckOut
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
            this.comBoxProducts = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonAddCheckOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(197, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // comBoxProducts
            // 
            this.comBoxProducts.FormattingEnabled = true;
            this.comBoxProducts.Location = new System.Drawing.Point(270, 149);
            this.comBoxProducts.Name = "comBoxProducts";
            this.comBoxProducts.Size = new System.Drawing.Size(230, 24);
            this.comBoxProducts.TabIndex = 3;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(270, 263);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(230, 22);
            this.textBoxCount.TabIndex = 4;
            // 
            // buttonAddCheckOut
            // 
            this.buttonAddCheckOut.Location = new System.Drawing.Point(50, 333);
            this.buttonAddCheckOut.Name = "buttonAddCheckOut";
            this.buttonAddCheckOut.Size = new System.Drawing.Size(230, 52);
            this.buttonAddCheckOut.TabIndex = 5;
            this.buttonAddCheckOut.Text = "Оформить заказ";
            this.buttonAddCheckOut.UseVisualStyleBackColor = true;
            this.buttonAddCheckOut.Click += new System.EventHandler(this.buttonAddCheckOut_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(506, 333);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(230, 52);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddCheckOut);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comBoxProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxProducts;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonAddCheckOut;
        private System.Windows.Forms.Button buttonExit;
    }
}