namespace Arrays
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskOne = new System.Windows.Forms.Button();
            this.independentTaskOneTwo = new System.Windows.Forms.Button();
            this.TaskOnePart2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IndependentTaskTwoOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskOne
            // 
            this.TaskOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskOne.Location = new System.Drawing.Point(92, 100);
            this.TaskOne.Name = "TaskOne";
            this.TaskOne.Size = new System.Drawing.Size(320, 33);
            this.TaskOne.TabIndex = 0;
            this.TaskOne.Text = "Задание 1";
            this.TaskOne.UseVisualStyleBackColor = true;
            this.TaskOne.Click += new System.EventHandler(this.TaskOne_Click);
            // 
            // independentTaskOneTwo
            // 
            this.independentTaskOneTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.independentTaskOneTwo.Location = new System.Drawing.Point(92, 170);
            this.independentTaskOneTwo.Name = "independentTaskOneTwo";
            this.independentTaskOneTwo.Size = new System.Drawing.Size(320, 33);
            this.independentTaskOneTwo.TabIndex = 2;
            this.independentTaskOneTwo.Text = "Самостоятельная задание № 1.2";
            this.independentTaskOneTwo.UseVisualStyleBackColor = true;
            this.independentTaskOneTwo.Click += new System.EventHandler(this.independentTaskOneTwo_Click);
            // 
            // TaskOnePart2
            // 
            this.TaskOnePart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskOnePart2.Location = new System.Drawing.Point(92, 305);
            this.TaskOnePart2.Name = "TaskOnePart2";
            this.TaskOnePart2.Size = new System.Drawing.Size(320, 33);
            this.TaskOnePart2.TabIndex = 3;
            this.TaskOnePart2.Text = "Задание 1";
            this.TaskOnePart2.UseVisualStyleBackColor = true;
            this.TaskOnePart2.Click += new System.EventHandler(this.TaskOnePart2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Работа с двумерными массивами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Работа с одномерными массивами";
            // 
            // IndependentTaskTwoOne
            // 
            this.IndependentTaskTwoOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndependentTaskTwoOne.Location = new System.Drawing.Point(93, 382);
            this.IndependentTaskTwoOne.Name = "IndependentTaskTwoOne";
            this.IndependentTaskTwoOne.Size = new System.Drawing.Size(320, 33);
            this.IndependentTaskTwoOne.TabIndex = 6;
            this.IndependentTaskTwoOne.Text = "Самостоятельная работа № 2.1";
            this.IndependentTaskTwoOne.UseVisualStyleBackColor = true;
            this.IndependentTaskTwoOne.Click += new System.EventHandler(this.IndependentTaskTwoOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 638);
            this.Controls.Add(this.IndependentTaskTwoOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskOnePart2);
            this.Controls.Add(this.independentTaskOneTwo);
            this.Controls.Add(this.TaskOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TaskOne;
        private System.Windows.Forms.Button independentTaskOneTwo;
        private System.Windows.Forms.Button TaskOnePart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IndependentTaskTwoOne;
    }
}

