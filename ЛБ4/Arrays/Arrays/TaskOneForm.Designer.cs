namespace Arrays
{
    partial class TaskOneForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.initArray = new System.Windows.Forms.Button();
            this.calcSumPositive = new System.Windows.Forms.Button();
            this.calcCountNeg = new System.Windows.Forms.Button();
            this.resSumPositive = new System.Windows.Forms.Label();
            this.resCountNegative = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.resNum = new System.Windows.Forms.Label();
            this.calcNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(47, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(193, 304);
            this.listBox.TabIndex = 0;
            // 
            // initArray
            // 
            this.initArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initArray.Location = new System.Drawing.Point(276, 33);
            this.initArray.Name = "initArray";
            this.initArray.Size = new System.Drawing.Size(163, 49);
            this.initArray.TabIndex = 1;
            this.initArray.Text = "Определить массив";
            this.initArray.UseVisualStyleBackColor = true;
            this.initArray.Click += new System.EventHandler(this.initArray_Click);
            // 
            // calcSumPositive
            // 
            this.calcSumPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcSumPositive.Location = new System.Drawing.Point(276, 121);
            this.calcSumPositive.Name = "calcSumPositive";
            this.calcSumPositive.Size = new System.Drawing.Size(163, 49);
            this.calcSumPositive.TabIndex = 2;
            this.calcSumPositive.Text = "Сумма положит. чисел";
            this.calcSumPositive.UseVisualStyleBackColor = true;
            this.calcSumPositive.Click += new System.EventHandler(this.calcSumPositive_Click);
            // 
            // calcCountNeg
            // 
            this.calcCountNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcCountNeg.Location = new System.Drawing.Point(276, 215);
            this.calcCountNeg.Name = "calcCountNeg";
            this.calcCountNeg.Size = new System.Drawing.Size(163, 49);
            this.calcCountNeg.TabIndex = 3;
            this.calcCountNeg.Text = "Кол-во отриц. элементов";
            this.calcCountNeg.UseVisualStyleBackColor = true;
            this.calcCountNeg.Click += new System.EventHandler(this.calcCountNeg_Click);
            // 
            // resSumPositive
            // 
            this.resSumPositive.AutoSize = true;
            this.resSumPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resSumPositive.Location = new System.Drawing.Point(482, 121);
            this.resSumPositive.Name = "resSumPositive";
            this.resSumPositive.Size = new System.Drawing.Size(0, 20);
            this.resSumPositive.TabIndex = 4;
            // 
            // resCountNegative
            // 
            this.resCountNegative.AutoSize = true;
            this.resCountNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resCountNegative.Location = new System.Drawing.Point(482, 215);
            this.resCountNegative.Name = "resCountNegative";
            this.resCountNegative.Size = new System.Drawing.Size(0, 20);
            this.resCountNegative.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите число";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(276, 373);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 26);
            this.input.TabIndex = 7;
            // 
            // resNum
            // 
            this.resNum.AutoSize = true;
            this.resNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resNum.Location = new System.Drawing.Point(472, 373);
            this.resNum.Name = "resNum";
            this.resNum.Size = new System.Drawing.Size(0, 20);
            this.resNum.TabIndex = 8;
            // 
            // calcNum
            // 
            this.calcNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcNum.Location = new System.Drawing.Point(276, 288);
            this.calcNum.Name = "calcNum";
            this.calcNum.Size = new System.Drawing.Size(163, 49);
            this.calcNum.TabIndex = 9;
            this.calcNum.Text = "Кол-во меньш. больш. равных элем";
            this.calcNum.UseVisualStyleBackColor = true;
            this.calcNum.Click += new System.EventHandler(this.calcNum_Click);
            // 
            // TaskOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 496);
            this.Controls.Add(this.calcNum);
            this.Controls.Add(this.resNum);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resCountNegative);
            this.Controls.Add(this.resSumPositive);
            this.Controls.Add(this.calcCountNeg);
            this.Controls.Add(this.calcSumPositive);
            this.Controls.Add(this.initArray);
            this.Controls.Add(this.listBox);
            this.Name = "TaskOneForm";
            this.Text = "TaskOneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button initArray;
        private System.Windows.Forms.Button calcSumPositive;
        private System.Windows.Forms.Button calcCountNeg;
        private System.Windows.Forms.Label resSumPositive;
        private System.Windows.Forms.Label resCountNegative;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label resNum;
        private System.Windows.Forms.Button calcNum;
    }
}