namespace Работа_с_файлами
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
            this.tsbCount = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelDiagonal = new System.Windows.Forms.Label();
            this.labelOS = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.labelStorage = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbDiagonal = new System.Windows.Forms.TextBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbMemory = new System.Windows.Forms.TextBox();
            this.tbStorage = new System.Windows.Forms.TextBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tsbNext = new System.Windows.Forms.Button();
            this.tsbPrev = new System.Windows.Forms.Button();
            this.tsbDelete = new System.Windows.Forms.Button();
            this.tsbAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tsbCount
            // 
            this.tsbCount.AutoSize = true;
            this.tsbCount.Location = new System.Drawing.Point(444, 33);
            this.tsbCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbCount.Name = "tsbCount";
            this.tsbCount.Size = new System.Drawing.Size(246, 29);
            this.tsbCount.TabIndex = 4;
            this.tsbCount.Text = "Количество записей";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(49, 153);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(100, 29);
            this.labelModel.TabIndex = 5;
            this.labelModel.Text = "Модель";
            // 
            // labelDiagonal
            // 
            this.labelDiagonal.AutoSize = true;
            this.labelDiagonal.Location = new System.Drawing.Point(49, 208);
            this.labelDiagonal.Name = "labelDiagonal";
            this.labelDiagonal.Size = new System.Drawing.Size(136, 29);
            this.labelDiagonal.TabIndex = 6;
            this.labelDiagonal.Text = "Диагональ";
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Location = new System.Drawing.Point(49, 262);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(282, 29);
            this.labelOS.TabIndex = 7;
            this.labelOS.Text = "Операционная система";
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(49, 317);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(253, 29);
            this.labelMemory.TabIndex = 8;
            this.labelMemory.Text = "Оперативная память";
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Location = new System.Drawing.Point(49, 382);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(236, 29);
            this.labelStorage.TabIndex = 9;
            this.labelStorage.Text = "Встроенная память";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(49, 436);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(137, 29);
            this.labelCPU.TabIndex = 10;
            this.labelCPU.Text = "Процессор";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(392, 148);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(412, 34);
            this.tbModel.TabIndex = 11;
            // 
            // tbDiagonal
            // 
            this.tbDiagonal.Location = new System.Drawing.Point(392, 203);
            this.tbDiagonal.Name = "tbDiagonal";
            this.tbDiagonal.Size = new System.Drawing.Size(412, 34);
            this.tbDiagonal.TabIndex = 12;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(392, 262);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(412, 34);
            this.tbOS.TabIndex = 13;
            // 
            // tbMemory
            // 
            this.tbMemory.Location = new System.Drawing.Point(392, 317);
            this.tbMemory.Name = "tbMemory";
            this.tbMemory.Size = new System.Drawing.Size(412, 34);
            this.tbMemory.TabIndex = 14;
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(392, 383);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.Size = new System.Drawing.Size(412, 34);
            this.tbStorage.TabIndex = 15;
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(392, 433);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(412, 34);
            this.tbCPU.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 68);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 68);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.Image = global::Работа_с_файлами.Properties.Resources.ImageNextButton;
            this.tsbNext.Location = new System.Drawing.Point(315, 0);
            this.tsbNext.Margin = new System.Windows.Forms.Padding(5);
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(119, 94);
            this.tsbNext.TabIndex = 3;
            this.tsbNext.UseVisualStyleBackColor = true;
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbPrev
            // 
            this.tsbPrev.Image = global::Работа_с_файлами.Properties.Resources.ImagePastButton;
            this.tsbPrev.Location = new System.Drawing.Point(203, 0);
            this.tsbPrev.Margin = new System.Windows.Forms.Padding(5);
            this.tsbPrev.Name = "tsbPrev";
            this.tsbPrev.Size = new System.Drawing.Size(119, 94);
            this.tsbPrev.TabIndex = 2;
            this.tsbPrev.UseVisualStyleBackColor = true;
            this.tsbPrev.Click += new System.EventHandler(this.tsbPrev_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Работа_с_файлами.Properties.Resources.ImageDelButton;
            this.tsbDelete.Location = new System.Drawing.Point(100, 0);
            this.tsbDelete.Margin = new System.Windows.Forms.Padding(5);
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(110, 94);
            this.tsbDelete.TabIndex = 1;
            this.tsbDelete.UseVisualStyleBackColor = true;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Работа_с_файлами.Properties.Resources.ImageAddButton;
            this.tsbAdd.Location = new System.Drawing.Point(-5, 0);
            this.tsbAdd.Margin = new System.Windows.Forms.Padding(5);
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(112, 94);
            this.tsbAdd.TabIndex = 0;
            this.tsbAdd.UseVisualStyleBackColor = true;
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // mainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCPU);
            this.Controls.Add(this.tbStorage);
            this.Controls.Add(this.tbMemory);
            this.Controls.Add(this.tbOS);
            this.Controls.Add(this.tbDiagonal);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelStorage);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.labelOS);
            this.Controls.Add(this.labelDiagonal);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.tsbCount);
            this.Controls.Add(this.tsbNext);
            this.Controls.Add(this.tsbPrev);
            this.Controls.Add(this.tsbDelete);
            this.Controls.Add(this.tsbAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainForm2";
            this.Text = "Список планшетов";
            this.Load += new System.EventHandler(this.mainForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbAdd;
        private System.Windows.Forms.Button tsbDelete;
        private System.Windows.Forms.Button tsbPrev;
        private System.Windows.Forms.Button tsbNext;
        private System.Windows.Forms.Label tsbCount;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelDiagonal;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbDiagonal;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tbMemory;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}