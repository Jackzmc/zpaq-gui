namespace zpaq_GUI
{
    partial class ExtractGUI
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
            System.Windows.Forms.ColumnHeader filesize;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveloc_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.source_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.extract_btn = new System.Windows.Forms.Button();
            this.filelist = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_output = new System.Windows.Forms.RichTextBox();
            filesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // filesize
            // 
            filesize.Text = "Size";
            filesize.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 20);
            this.textBox1.TabIndex = 1;
            // 
            // saveloc_btn
            // 
            this.saveloc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveloc_btn.Location = new System.Drawing.Point(566, 26);
            this.saveloc_btn.Name = "saveloc_btn";
            this.saveloc_btn.Size = new System.Drawing.Size(75, 21);
            this.saveloc_btn.TabIndex = 2;
            this.saveloc_btn.Text = "Browse";
            this.saveloc_btn.UseVisualStyleBackColor = true;
            this.saveloc_btn.Click += new System.EventHandler(this.saveloc_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source ";
            // 
            // source_btn
            // 
            this.source_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.source_btn.Location = new System.Drawing.Point(566, 73);
            this.source_btn.Name = "source_btn";
            this.source_btn.Size = new System.Drawing.Size(75, 23);
            this.source_btn.TabIndex = 5;
            this.source_btn.Text = "Choose";
            this.source_btn.UseVisualStyleBackColor = true;
            this.source_btn.Click += new System.EventHandler(this.source_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(545, 20);
            this.textBox2.TabIndex = 4;
            // 
            // extract_btn
            // 
            this.extract_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extract_btn.Location = new System.Drawing.Point(16, 105);
            this.extract_btn.Name = "extract_btn";
            this.extract_btn.Size = new System.Drawing.Size(75, 37);
            this.extract_btn.TabIndex = 6;
            this.extract_btn.Text = "Extract";
            this.extract_btn.UseVisualStyleBackColor = true;
            this.extract_btn.Click += new System.EventHandler(this.extract_btn_Click);
            // 
            // filelist
            // 
            this.filelist.AllowDrop = true;
            this.filelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            filesize});
            this.filelist.Location = new System.Drawing.Point(12, 170);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(629, 176);
            this.filelist.TabIndex = 8;
            this.filelist.UseCompatibleStateImageBehavior = false;
            this.filelist.View = System.Windows.Forms.View.Details;
            // 
            // filename
            // 
            this.filename.Text = "File Name";
            this.filename.Width = 530;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Files (WIP)";
            // 
            // cmd_output
            // 
            this.cmd_output.Location = new System.Drawing.Point(97, 105);
            this.cmd_output.Name = "cmd_output";
            this.cmd_output.Size = new System.Drawing.Size(544, 59);
            this.cmd_output.TabIndex = 10;
            this.cmd_output.Text = "";
            // 
            // ExtractGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 358);
            this.Controls.Add(this.cmd_output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filelist);
            this.Controls.Add(this.extract_btn);
            this.Controls.Add(this.source_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveloc_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtractGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZPAQ GUI Extractor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtractGUI_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveloc_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button source_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button extract_btn;
        private System.Windows.Forms.ListView filelist;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox cmd_output;
    }
}