namespace WindowsFormsApp1
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
            this.listOfPlayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOT = new System.Windows.Forms.Label();
            this.labelDO = new System.Windows.Forms.Label();
            this.textBoxOT = new System.Windows.Forms.TextBox();
            this.textBoxDO = new System.Windows.Forms.TextBox();
            this.btnDiapazon = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfPlayers
            // 
            this.listOfPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfPlayers.HideSelection = false;
            this.listOfPlayers.Location = new System.Drawing.Point(49, 190);
            this.listOfPlayers.Margin = new System.Windows.Forms.Padding(5);
            this.listOfPlayers.Name = "listOfPlayers";
            this.listOfPlayers.Size = new System.Drawing.Size(613, 506);
            this.listOfPlayers.TabIndex = 0;
            this.listOfPlayers.UseCompatibleStateImageBehavior = false;
            this.listOfPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество очков";
            this.columnHeader3.Width = 268;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(37, 153);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 34);
            this.txtName.TabIndex = 2;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(37, 265);
            this.txtScore.Margin = new System.Windows.Forms.Padding(5);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(258, 34);
            this.txtScore.TabIndex = 3;
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 365);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(44, 132);
            this.lblList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(199, 29);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "Список игроков ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 102);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 29);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Имя";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(52, 214);
            this.lblScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(220, 29);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Количество очков";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Location = new System.Drawing.Point(654, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 476);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // labelOT
            // 
            this.labelOT.AutoSize = true;
            this.labelOT.Location = new System.Drawing.Point(356, 753);
            this.labelOT.Name = "labelOT";
            this.labelOT.Size = new System.Drawing.Size(44, 29);
            this.labelOT.TabIndex = 9;
            this.labelOT.Text = "От";
            // 
            // labelDO
            // 
            this.labelDO.AutoSize = true;
            this.labelDO.Location = new System.Drawing.Point(615, 750);
            this.labelDO.Name = "labelDO";
            this.labelDO.Size = new System.Drawing.Size(47, 29);
            this.labelDO.TabIndex = 10;
            this.labelDO.Text = "До";
            // 
            // textBoxOT
            // 
            this.textBoxOT.Location = new System.Drawing.Point(393, 753);
            this.textBoxOT.Name = "textBoxOT";
            this.textBoxOT.Size = new System.Drawing.Size(216, 34);
            this.textBoxOT.TabIndex = 11;
            // 
            // textBoxDO
            // 
            this.textBoxDO.Location = new System.Drawing.Point(677, 750);
            this.textBoxDO.Name = "textBoxDO";
            this.textBoxDO.Size = new System.Drawing.Size(163, 34);
            this.textBoxDO.TabIndex = 12;
            // 
            // btnDiapazon
            // 
            this.btnDiapazon.Location = new System.Drawing.Point(75, 717);
            this.btnDiapazon.Name = "btnDiapazon";
            this.btnDiapazon.Size = new System.Drawing.Size(227, 87);
            this.btnDiapazon.TabIndex = 13;
            this.btnDiapazon.Text = "Вывод игроков по диапазону";
            this.btnDiapazon.UseVisualStyleBackColor = true;
            this.btnDiapazon.Click += new System.EventHandler(this.btnDiapazon_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Время";
            this.columnHeader4.Width = 103;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.btnDiapazon);
            this.Controls.Add(this.textBoxDO);
            this.Controls.Add(this.textBoxOT);
            this.Controls.Add(this.labelDO);
            this.Controls.Add(this.labelOT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.listOfPlayers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainForm";
            this.Text = "Результаты прохождения игры";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listOfPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOT;
        private System.Windows.Forms.Label labelDO;
        private System.Windows.Forms.TextBox textBoxOT;
        private System.Windows.Forms.TextBox textBoxDO;
        private System.Windows.Forms.Button btnDiapazon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}