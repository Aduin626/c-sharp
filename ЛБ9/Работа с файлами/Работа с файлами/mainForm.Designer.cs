namespace Работа_с_файлами
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbInput.Location = new System.Drawing.Point(36, 36);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 22);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "test.txt";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(33, 95);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(152, 16);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "Информация о файле:";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(36, 114);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(428, 122);
            this.tbInfo.TabIndex = 2;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(33, 222);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(139, 16);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "Содержимое файла:";
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(36, 242);
            this.tbEdit.Multiline = true;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.ReadOnly = true;
            this.tbEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEdit.Size = new System.Drawing.Size(428, 196);
            this.tbEdit.TabIndex = 4;
            this.tbEdit.WordWrap = false;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(505, 114);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(112, 68);
            this.btnGetInfo.TabIndex = 5;
            this.btnGetInfo.Text = "Загрузить информацию";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(516, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 62);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.tbInput);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnSave;
    }
}