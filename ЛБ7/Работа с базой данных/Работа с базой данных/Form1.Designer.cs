namespace Работа_с_базой_данных
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.savettn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1400, 816);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.clearbtn);
            this.tabPage1.Controls.Add(this.deletebtb);
            this.tabPage1.Controls.Add(this.updateb);
            this.tabPage1.Controls.Add(this.savettn);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.nametxt);
            this.tabPage1.Controls.Add(this.adtxt);
            this.tabPage1.Controls.Add(this.idtxt);
            this.tabPage1.Controls.Add(this.labelTel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.labelID);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1392, 774);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 296);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(565, 340);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(221, 41);
            this.clearbtn.TabIndex = 12;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // deletebtb
            // 
            this.deletebtb.Location = new System.Drawing.Point(565, 268);
            this.deletebtb.Name = "deletebtb";
            this.deletebtb.Size = new System.Drawing.Size(221, 53);
            this.deletebtb.TabIndex = 11;
            this.deletebtb.Text = "Delete";
            this.deletebtb.UseVisualStyleBackColor = true;
            this.deletebtb.Click += new System.EventHandler(this.deletebtb_Click);
            // 
            // updateb
            // 
            this.updateb.Location = new System.Drawing.Point(565, 206);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(221, 42);
            this.updateb.TabIndex = 10;
            this.updateb.Text = "Update";
            this.updateb.UseVisualStyleBackColor = true;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // savettn
            // 
            this.savettn.Location = new System.Drawing.Point(565, 154);
            this.savettn.Name = "savettn";
            this.savettn.Size = new System.Drawing.Size(221, 37);
            this.savettn.TabIndex = 9;
            this.savettn.Text = "Save";
            this.savettn.UseVisualStyleBackColor = true;
            this.savettn.Click += new System.EventHandler(this.savettn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(507, 42);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 34);
            this.textBox4.TabIndex = 8;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(170, 120);
            this.nametxt.Margin = new System.Windows.Forms.Padding(5);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(188, 34);
            this.nametxt.TabIndex = 7;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(170, 195);
            this.adtxt.Margin = new System.Windows.Forms.Padding(5);
            this.adtxt.Multiline = true;
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(188, 126);
            this.adtxt.TabIndex = 6;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(170, 42);
            this.idtxt.Margin = new System.Windows.Forms.Padding(5);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(188, 34);
            this.idtxt.TabIndex = 5;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(418, 47);
            this.labelTel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 29);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 120);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 29);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(24, 47);
            this.labelID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 29);
            this.labelID.TabIndex = 1;
            this.labelID.Text = " ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1392, 774);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "Работа с базой данных";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtb;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button savettn;
    }
}

