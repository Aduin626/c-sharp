namespace Работа_с_обработчиками_событий
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxSeconds = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(79, 59);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(369, 16);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Установите желаемое время и нажмите кнопку \"Cтарт\"";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(27, 209);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(40, 16);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Часы";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(192, 208);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(58, 16);
            this.labelMinutes.TabIndex = 2;
            this.labelMinutes.Text = "Минуты";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(385, 209);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(64, 16);
            this.labelSeconds.TabIndex = 3;
            this.labelSeconds.Text = "Секунды";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(70, 382);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 16);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Осталось:";
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(73, 206);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHours.TabIndex = 5;
            this.comboBoxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxHours_KeyPress);
            this.comboBoxHours.Leave += new System.EventHandler(this.comboBoxHours_Leave);
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Location = new System.Drawing.Point(256, 206);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMinutes.TabIndex = 6;
            this.comboBoxMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxHours_KeyPress);
            this.comboBoxMinutes.Leave += new System.EventHandler(this.comboBoxHours_Leave);
            // 
            // comboBoxSeconds
            // 
            this.comboBoxSeconds.FormattingEnabled = true;
            this.comboBoxSeconds.Location = new System.Drawing.Point(455, 205);
            this.comboBoxSeconds.Name = "comboBoxSeconds";
            this.comboBoxSeconds.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeconds.TabIndex = 7;
            this.comboBoxSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxHours_KeyPress);
            this.comboBoxSeconds.Leave += new System.EventHandler(this.comboBoxHours_Leave);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(230, 273);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(218, 58);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxSeconds);
            this.Controls.Add(this.comboBoxMinutes);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelInfo);
            this.Name = "mainForm";
            this.Text = "Таймер обратного отсчета";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.ComboBox comboBoxSeconds;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}