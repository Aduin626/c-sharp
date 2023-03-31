namespace Arrays
{
    partial class TaskOnePartTwoForm
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
            this.initArray = new System.Windows.Forms.Button();
            this.searchElems = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // initArray
            // 
            this.initArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initArray.Location = new System.Drawing.Point(53, 50);
            this.initArray.Name = "initArray";
            this.initArray.Size = new System.Drawing.Size(161, 57);
            this.initArray.TabIndex = 0;
            this.initArray.Text = "Сформировать массив";
            this.initArray.UseVisualStyleBackColor = true;
            this.initArray.Click += new System.EventHandler(this.initArray_Click);
            // 
            // searchElems
            // 
            this.searchElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchElems.Location = new System.Drawing.Point(259, 50);
            this.searchElems.Name = "searchElems";
            this.searchElems.Size = new System.Drawing.Size(200, 57);
            this.searchElems.TabIndex = 1;
            this.searchElems.Text = "Поиск минимальных элементов по строкам";
            this.searchElems.UseVisualStyleBackColor = true;
            this.searchElems.Click += new System.EventHandler(this.searchElems_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(53, 155);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(502, 243);
            this.dataGridView.TabIndex = 2;
            // 
            // TaskOnePartTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchElems);
            this.Controls.Add(this.initArray);
            this.Name = "TaskOnePartTwoForm";
            this.Text = "TaskOnePartTwoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initArray;
        private System.Windows.Forms.Button searchElems;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}