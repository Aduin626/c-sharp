namespace Разработка_многооконного_пользовательнского_интерфейса
{
    partial class noteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noteForm));
            this.tsNoteForm = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbFont = new System.Windows.Forms.ToolStripButton();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tsNoteForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsNoteForm
            // 
            this.tsNoteForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsNoteForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete,
            this.tsbFont});
            this.tsNoteForm.Location = new System.Drawing.Point(0, 0);
            this.tsNoteForm.Name = "tsNoteForm";
            this.tsNoteForm.Size = new System.Drawing.Size(800, 27);
            this.tsNoteForm.TabIndex = 0;
            this.tsNoteForm.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(29, 24);
            this.tsbSave.Text = "toolStripButton1";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 24);
            this.tsbDelete.Text = "toolStripButton2";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbFont
            // 
            this.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbFont.Image")));
            this.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(29, 24);
            this.tsbFont.Text = "toolStripButton3";
            this.tsbFont.Click += new System.EventHandler(this.tsbFont_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNote.Location = new System.Drawing.Point(0, 27);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(800, 423);
            this.rtbNote.TabIndex = 1;
            this.rtbNote.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "е Простой текст |*.txt| Rich Text Format |*.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.Filter = "Простой текст |*.txt| Rich Text Format |*.rtf.";
            // 
            // noteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.tsNoteForm);
            this.Name = "noteForm";
            this.Text = "noteForm";
            this.tsNoteForm.ResumeLayout(false);
            this.tsNoteForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNoteForm;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbFont;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}