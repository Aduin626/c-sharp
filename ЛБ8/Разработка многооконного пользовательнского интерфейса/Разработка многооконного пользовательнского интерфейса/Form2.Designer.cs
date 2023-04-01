namespace Разработка_многооконного_пользовательнского_интерфейса
{
    partial class main_Form
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 428);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 428);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(124, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 428);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(676, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 97);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(676, 3);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(676, 328);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Изменен";
            this.columnHeader3.Width = 200;
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "main_Form";
            this.Text = "Обзор дерева каталогов и списка файлов";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}