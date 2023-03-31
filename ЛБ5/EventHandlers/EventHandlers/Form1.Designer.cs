namespace EventHandlers
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
            this.taskOne = new System.Windows.Forms.Button();
            this.taskTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskOne
            // 
            this.taskOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskOne.Location = new System.Drawing.Point(104, 79);
            this.taskOne.Name = "taskOne";
            this.taskOne.Size = new System.Drawing.Size(103, 36);
            this.taskOne.TabIndex = 0;
            this.taskOne.Text = "Задание 1";
            this.taskOne.UseVisualStyleBackColor = true;
            this.taskOne.Click += new System.EventHandler(this.taskOne_Click);
            // 
            // taskTwo
            // 
            this.taskTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTwo.Location = new System.Drawing.Point(104, 157);
            this.taskTwo.Name = "taskTwo";
            this.taskTwo.Size = new System.Drawing.Size(103, 36);
            this.taskTwo.TabIndex = 1;
            this.taskTwo.Text = "Задание 2";
            this.taskTwo.UseVisualStyleBackColor = true;
            this.taskTwo.Click += new System.EventHandler(this.taskTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 291);
            this.Controls.Add(this.taskTwo);
            this.Controls.Add(this.taskOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskOne;
        private System.Windows.Forms.Button taskTwo;
    }
}

