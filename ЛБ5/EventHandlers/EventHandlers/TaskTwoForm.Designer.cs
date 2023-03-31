namespace EventHandlers
{
    partial class TaskTwoForm
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
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSizeTile = new System.Windows.Forms.Label();
            this.labelCountTile = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.comboBoxTileSize = new System.Windows.Forms.ComboBox();
            this.comboBoxTileCount = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(57, 44);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(113, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер поверхности";
            // 
            // labelParams
            // 
            this.labelParams.AutoSize = true;
            this.labelParams.Location = new System.Drawing.Point(334, 44);
            this.labelParams.Name = "labelParams";
            this.labelParams.Size = new System.Drawing.Size(104, 13);
            this.labelParams.TabIndex = 1;
            this.labelParams.Text = "Параметры плитки";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(43, 91);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(46, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Ширина\r\n";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(43, 124);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(45, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Высота";
            // 
            // labelSizeTile
            // 
            this.labelSizeTile.AutoSize = true;
            this.labelSizeTile.Location = new System.Drawing.Point(334, 91);
            this.labelSizeTile.Name = "labelSizeTile";
            this.labelSizeTile.Size = new System.Drawing.Size(46, 13);
            this.labelSizeTile.TabIndex = 4;
            this.labelSizeTile.Text = "Размер";
            // 
            // labelCountTile
            // 
            this.labelCountTile.AutoSize = true;
            this.labelCountTile.Location = new System.Drawing.Point(334, 124);
            this.labelCountTile.Name = "labelCountTile";
            this.labelCountTile.Size = new System.Drawing.Size(91, 13);
            this.labelCountTile.TabIndex = 5;
            this.labelCountTile.Text = "Штук в упаковке";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(107, 84);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(63, 20);
            this.textBoxWidth.TabIndex = 6;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_keyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(107, 124);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(63, 20);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_keyPress);
            // 
            // comboBoxTileSize
            // 
            this.comboBoxTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTileSize.FormattingEnabled = true;
            this.comboBoxTileSize.Location = new System.Drawing.Point(452, 83);
            this.comboBoxTileSize.Name = "comboBoxTileSize";
            this.comboBoxTileSize.Size = new System.Drawing.Size(55, 21);
            this.comboBoxTileSize.TabIndex = 8;
            // 
            // comboBoxTileCount
            // 
            this.comboBoxTileCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTileCount.FormattingEnabled = true;
            this.comboBoxTileCount.Location = new System.Drawing.Point(452, 123);
            this.comboBoxTileCount.Name = "comboBoxTileCount";
            this.comboBoxTileCount.Size = new System.Drawing.Size(55, 21);
            this.comboBoxTileCount.TabIndex = 9;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(43, 196);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(116, 13);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Количество упаковок";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(220, 196);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(63, 20);
            this.textBoxResult.TabIndex = 11;
            this.textBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_keyPress);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(337, 196);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 12;
            this.buttonResult.Text = "Рассчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(337, 251);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 13;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(432, 251);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // TaskTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxTileCount);
            this.Controls.Add(this.comboBoxTileSize);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelCountTile);
            this.Controls.Add(this.labelSizeTile);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelParams);
            this.Controls.Add(this.labelSize);
            this.Name = "TaskTwoForm";
            this.Text = "TaskTwoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskTwoForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskTwoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelParams;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSizeTile;
        private System.Windows.Forms.Label labelCountTile;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.ComboBox comboBoxTileSize;
        private System.Windows.Forms.ComboBox comboBoxTileCount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
    }
}