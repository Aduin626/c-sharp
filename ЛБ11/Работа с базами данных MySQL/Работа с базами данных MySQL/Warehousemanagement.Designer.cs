namespace Работа_с_базами_данных_MySQL
{
    partial class Warehousemanagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCountProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetailsProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonResetSort = new System.Windows.Forms.Button();
            this.buttonWriteOff = new System.Windows.Forms.Button();
            this.buttonAddSupply = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCountProducts
            // 
            this.dataGridViewCountProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCountProducts.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCountProducts.Location = new System.Drawing.Point(23, 134);
            this.dataGridViewCountProducts.Name = "dataGridViewCountProducts";
            this.dataGridViewCountProducts.RowHeadersWidth = 51;
            this.dataGridViewCountProducts.RowTemplate.Height = 24;
            this.dataGridViewCountProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountProducts.Size = new System.Drawing.Size(408, 434);
            this.dataGridViewCountProducts.TabIndex = 0;
            this.dataGridViewCountProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountProducts_CellClick);
            // 
            // dataGridViewDetailsProduct
            // 
            this.dataGridViewDetailsProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetailsProduct.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDetailsProduct.Location = new System.Drawing.Point(482, 135);
            this.dataGridViewDetailsProduct.Name = "dataGridViewDetailsProduct";
            this.dataGridViewDetailsProduct.RowHeadersWidth = 51;
            this.dataGridViewDetailsProduct.RowTemplate.Height = 24;
            this.dataGridViewDetailsProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetailsProduct.Size = new System.Drawing.Size(408, 433);
            this.dataGridViewDetailsProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поставки товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Товары на складе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список товаров на складе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(973, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сортировка по категории товара";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(978, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonResetSort
            // 
            this.buttonResetSort.Location = new System.Drawing.Point(978, 276);
            this.buttonResetSort.Name = "buttonResetSort";
            this.buttonResetSort.Size = new System.Drawing.Size(221, 23);
            this.buttonResetSort.TabIndex = 7;
            this.buttonResetSort.Text = "Сбросить сортировку";
            this.buttonResetSort.UseVisualStyleBackColor = true;
            this.buttonResetSort.Click += new System.EventHandler(this.buttonResetSort_Click);
            // 
            // buttonWriteOff
            // 
            this.buttonWriteOff.Location = new System.Drawing.Point(978, 340);
            this.buttonWriteOff.Name = "buttonWriteOff";
            this.buttonWriteOff.Size = new System.Drawing.Size(221, 23);
            this.buttonWriteOff.TabIndex = 8;
            this.buttonWriteOff.Text = "Списание просрочки";
            this.buttonWriteOff.UseVisualStyleBackColor = true;
            this.buttonWriteOff.Click += new System.EventHandler(this.buttonWriteOff_Click);
            // 
            // buttonAddSupply
            // 
            this.buttonAddSupply.Location = new System.Drawing.Point(978, 394);
            this.buttonAddSupply.Name = "buttonAddSupply";
            this.buttonAddSupply.Size = new System.Drawing.Size(221, 23);
            this.buttonAddSupply.TabIndex = 9;
            this.buttonAddSupply.Text = "Добавить новую поставку";
            this.buttonAddSupply.UseVisualStyleBackColor = true;
            this.buttonAddSupply.Click += new System.EventHandler(this.buttonAddSupply_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(976, 506);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(221, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Warehousemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 590);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddSupply);
            this.Controls.Add(this.buttonWriteOff);
            this.Controls.Add(this.buttonResetSort);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDetailsProduct);
            this.Controls.Add(this.dataGridViewCountProducts);
            this.Name = "Warehousemanagement";
            this.Text = "Warehousemanagement";
            this.Load += new System.EventHandler(this.Warehousemanagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountProducts;
        private System.Windows.Forms.DataGridView dataGridViewDetailsProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonResetSort;
        private System.Windows.Forms.Button buttonWriteOff;
        private System.Windows.Forms.Button buttonAddSupply;
        private System.Windows.Forms.Button buttonExit;
    }
}