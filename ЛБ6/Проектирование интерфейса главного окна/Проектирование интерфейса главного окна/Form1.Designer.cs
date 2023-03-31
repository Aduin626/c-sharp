namespace Проектирование_интерфейса_главного_окна
{
    partial class GlavForm
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
            this.buttonZ1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZ1
            // 
            this.buttonZ1.Location = new System.Drawing.Point(131, 114);
            this.buttonZ1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(206, 98);
            this.buttonZ1.TabIndex = 0;
            this.buttonZ1.Text = "Задание 1 ";
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            // 
            // GlavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 816);
            this.Controls.Add(this.buttonZ1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GlavForm";
            this.Text = "Создание текстового редактора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZ1;
    }
}

