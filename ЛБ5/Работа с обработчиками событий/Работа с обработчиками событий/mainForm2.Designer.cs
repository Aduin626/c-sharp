namespace Работа_с_обработчиками_событий
{
    partial class mainForm2
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
            this.labelSize = new System.Windows.Forms.Label();
            this.labelParams = new System.Windows.Forms.Label();
            this.labelWight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSIzeTile = new System.Windows.Forms.Label();
            this.labelCountTile = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxTileSize = new System.Windows.Forms.ComboBox();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(66, 74);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(144, 16);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер поверхности";
            // 
            // labelParams
            // 
            this.labelParams.AutoSize = true;
            this.labelParams.Location = new System.Drawing.Point(376, 74);
            this.labelParams.Name = "labelParams";
            this.labelParams.Size = new System.Drawing.Size(131, 16);
            this.labelParams.TabIndex = 1;
            this.labelParams.Text = "Параметры плитки";
            // 
            // labelWight
            // 
            this.labelWight.AutoSize = true;
            this.labelWight.Location = new System.Drawing.Point(66, 127);
            this.labelWight.Name = "labelWight";
            this.labelWight.Size = new System.Drawing.Size(58, 16);
            this.labelWight.TabIndex = 2;
            this.labelWight.Text = "Ширина";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(66, 170);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(55, 16);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Высота";
            // 
            // labelSIzeTile
            // 
            this.labelSIzeTile.AutoSize = true;
            this.labelSIzeTile.Location = new System.Drawing.Point(332, 127);
            this.labelSIzeTile.Name = "labelSIzeTile";
            this.labelSIzeTile.Size = new System.Drawing.Size(57, 16);
            this.labelSIzeTile.TabIndex = 4;
            this.labelSIzeTile.Text = "Размер";
            // 
            // labelCountTile
            // 
            this.labelCountTile.AutoSize = true;
            this.labelCountTile.Location = new System.Drawing.Point(332, 170);
            this.labelCountTile.Name = "labelCountTile";
            this.labelCountTile.Size = new System.Drawing.Size(116, 16);
            this.labelCountTile.TabIndex = 5;
            this.labelCountTile.Text = "Штук в упаковке";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(66, 269);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(150, 16);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Количество упаковок";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(139, 121);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidth.TabIndex = 7;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(139, 167);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 8;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(235, 263);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult.TabIndex = 9;
            // 
            // comboBoxTileSize
            // 
            this.comboBoxTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTileSize.FormattingEnabled = true;
            this.comboBoxTileSize.Location = new System.Drawing.Point(454, 127);
            this.comboBoxTileSize.Name = "comboBoxTileSize";
            this.comboBoxTileSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTileSize.TabIndex = 10;
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(454, 162);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCount.TabIndex = 11;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(434, 252);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 33);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Рассчитать ";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(347, 316);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(101, 30);
            this.buttonHelp.TabIndex = 13;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(476, 316);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 30);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // mainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.comboBoxTileSize);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCountTile);
            this.Controls.Add(this.labelSIzeTile);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWight);
            this.Controls.Add(this.labelParams);
            this.Controls.Add(this.labelSize);
            this.Name = "mainForm2";
            this.Text = "Калькулятор для расчета кол-ва плитки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm2_FormClosing);
            this.Load += new System.EventHandler(this.mainForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelParams;
        private System.Windows.Forms.Label labelWight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSIzeTile;
        private System.Windows.Forms.Label labelCountTile;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxTileSize;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
    }
}