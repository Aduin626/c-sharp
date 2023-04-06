namespace Работа_с_базами_данных_MySQL
{
    partial class AddSupply
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
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.textBoxinputCountProduct = new System.Windows.Forms.TextBox();
            this.dateTimePickerinputDate = new System.Windows.Forms.DateTimePicker();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddSupply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление поставки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите товар из списка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата поставки";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(61, 157);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(174, 24);
            this.comboBoxProduct.TabIndex = 4;
            // 
            // textBoxinputCountProduct
            // 
            this.textBoxinputCountProduct.Location = new System.Drawing.Point(311, 157);
            this.textBoxinputCountProduct.Name = "textBoxinputCountProduct";
            this.textBoxinputCountProduct.Size = new System.Drawing.Size(182, 22);
            this.textBoxinputCountProduct.TabIndex = 5;
            // 
            // dateTimePickerinputDate
            // 
            this.dateTimePickerinputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerinputDate.Location = new System.Drawing.Point(540, 155);
            this.dateTimePickerinputDate.Name = "dateTimePickerinputDate";
            this.dateTimePickerinputDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerinputDate.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(462, 310);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(143, 61);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddSupply
            // 
            this.buttonAddSupply.Location = new System.Drawing.Point(146, 310);
            this.buttonAddSupply.Name = "buttonAddSupply";
            this.buttonAddSupply.Size = new System.Drawing.Size(146, 61);
            this.buttonAddSupply.TabIndex = 8;
            this.buttonAddSupply.Text = "Добавить поставку";
            this.buttonAddSupply.UseVisualStyleBackColor = true;
            this.buttonAddSupply.Click += new System.EventHandler(this.buttonAddSupply_Click);
            // 
            // AddSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddSupply);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dateTimePickerinputDate);
            this.Controls.Add(this.textBoxinputCountProduct);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSupply";
            this.Text = "AddSupply";
            this.Load += new System.EventHandler(this.AddSupply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox textBoxinputCountProduct;
        private System.Windows.Forms.DateTimePicker dateTimePickerinputDate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddSupply;
    }
}