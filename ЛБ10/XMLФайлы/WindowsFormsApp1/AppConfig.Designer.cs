namespace WindowsFormsApp1
{
    partial class AppConfig
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
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbMinimized = new System.Windows.Forms.CheckBox();
            this.chbMaximized = new System.Windows.Forms.CheckBox();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFontChange = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "Рамка отсутствует",
            "Фиксированная однострочная граница",
            "Фиксированная трехмерная граница",
            "В стиле диалоговых окон",
            "Изменяемая граница",
            "Не изменяемая граница окна настроек",
            "Изменяемая граница окна настроек"});
            this.cmbBorderStyle.Location = new System.Drawing.Point(306, 71);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(263, 24);
            this.cmbBorderStyle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стиль рамки";
            // 
            // chbMinimized
            // 
            this.chbMinimized.AutoSize = true;
            this.chbMinimized.Location = new System.Drawing.Point(352, 154);
            this.chbMinimized.Name = "chbMinimized";
            this.chbMinimized.Size = new System.Drawing.Size(92, 20);
            this.chbMinimized.TabIndex = 2;
            this.chbMinimized.Text = "Свернуть";
            this.chbMinimized.UseVisualStyleBackColor = true;
            this.chbMinimized.CheckedChanged += new System.EventHandler(this.chbMinimized_CheckedChanged);
            // 
            // chbMaximized
            // 
            this.chbMaximized.AutoSize = true;
            this.chbMaximized.Location = new System.Drawing.Point(352, 199);
            this.chbMaximized.Name = "chbMaximized";
            this.chbMaximized.Size = new System.Drawing.Size(121, 20);
            this.chbMaximized.TabIndex = 3;
            this.chbMaximized.Text = "Восстановить";
            this.chbMaximized.UseVisualStyleBackColor = true;
            this.chbMaximized.CheckedChanged += new System.EventHandler(this.chbMaximized_CheckedChanged);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(349, 247);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(84, 16);
            this.lblBackColor.TabIndex = 4;
            this.lblBackColor.Text = "lblBackColor";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(352, 300);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(96, 27);
            this.btnChangeColor.TabIndex = 5;
            this.btnChangeColor.Text = "Изменить";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кнопки строки заголовка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет фона";
            // 
            // btnFontChange
            // 
            this.btnFontChange.Location = new System.Drawing.Point(85, 300);
            this.btnFontChange.Name = "btnFontChange";
            this.btnFontChange.Size = new System.Drawing.Size(176, 38);
            this.btnFontChange.TabIndex = 9;
            this.btnFontChange.Text = "Изменить шрифт";
            this.btnFontChange.UseVisualStyleBackColor = true;
            this.btnFontChange.Click += new System.EventHandler(this.btnFontChange_Click);
            // 
            // AppConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::WindowsFormsApp1.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFontChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.chbMaximized);
            this.Controls.Add(this.chbMinimized);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBorderStyle);
            this.DataBindings.Add(new System.Windows.Forms.Binding("MaximizeBox", global::WindowsFormsApp1.Properties.Settings.Default, "Maximized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MinimizeBox", global::WindowsFormsApp1.Properties.Settings.Default, "Minimized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::WindowsFormsApp1.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("FormBorderStyle", global::WindowsFormsApp1.Properties.Settings.Default, "BorderStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = global::WindowsFormsApp1.Properties.Settings.Default.BorderStyle;
            this.MaximizeBox = global::WindowsFormsApp1.Properties.Settings.Default.Maximized;
            this.MinimizeBox = global::WindowsFormsApp1.Properties.Settings.Default.Minimized;
            this.Name = "AppConfig";
            this.Text = "Установка приложений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppConfig_FormClosing);
            this.Load += new System.EventHandler(this.AppConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBorderStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbMinimized;
        private System.Windows.Forms.CheckBox chbMaximized;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFontChange;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}