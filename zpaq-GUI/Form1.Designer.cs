﻿namespace zpaq_GUI
{
    partial class ZPAQ_Main
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "1",
            "2",
            "3"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.dest_txt = new System.Windows.Forms.TextBox();
            this.dest_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settings_btn = new System.Windows.Forms.Button();
            this.files_add = new System.Windows.Forms.Button();
            this.files_remove = new System.Windows.Forms.Button();
            this.folders_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(12, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by Jackz. ";
            // 
            // dest_txt
            // 
            this.dest_txt.Location = new System.Drawing.Point(15, 29);
            this.dest_txt.Name = "dest_txt";
            this.dest_txt.Size = new System.Drawing.Size(570, 20);
            this.dest_txt.TabIndex = 1;
            // 
            // dest_btn
            // 
            this.dest_btn.Location = new System.Drawing.Point(588, 27);
            this.dest_btn.Name = "dest_btn";
            this.dest_btn.Size = new System.Drawing.Size(75, 23);
            this.dest_btn.TabIndex = 2;
            this.dest_btn.Text = "Browse";
            this.dest_btn.UseVisualStyleBackColor = true;
            this.dest_btn.Click += new System.EventHandler(this.dest_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Location";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            filesize});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(15, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(648, 245);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // filename
            // 
            this.filename.Text = "File Name";
            this.filename.Width = 549;
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(32, 395);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 23);
            this.settings_btn.TabIndex = 5;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // files_add
            // 
            this.files_add.Location = new System.Drawing.Point(15, 307);
            this.files_add.Name = "files_add";
            this.files_add.Size = new System.Drawing.Size(75, 23);
            this.files_add.TabIndex = 6;
            this.files_add.Text = "Add Files";
            this.files_add.UseVisualStyleBackColor = true;
            this.files_add.Click += new System.EventHandler(this.files_add_Click);
            // 
            // files_remove
            // 
            this.files_remove.Location = new System.Drawing.Point(555, 307);
            this.files_remove.Name = "files_remove";
            this.files_remove.Size = new System.Drawing.Size(108, 23);
            this.files_remove.TabIndex = 7;
            this.files_remove.Text = "Remove Selected";
            this.files_remove.UseVisualStyleBackColor = true;
            this.files_remove.Click += new System.EventHandler(this.files_remove_Click);
            // 
            // folders_add
            // 
            this.folders_add.Location = new System.Drawing.Point(96, 307);
            this.folders_add.Name = "folders_add";
            this.folders_add.Size = new System.Drawing.Size(75, 23);
            this.folders_add.TabIndex = 8;
            this.folders_add.Text = "Add Folders";
            this.folders_add.UseVisualStyleBackColor = true;
            this.folders_add.Click += new System.EventHandler(this.folders_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_output
            // 
            this.cmd_output.Location = new System.Drawing.Point(134, 345);
            this.cmd_output.Name = "cmd_output";
            this.cmd_output.ReadOnly = true;
            this.cmd_output.Size = new System.Drawing.Size(533, 151);
            this.cmd_output.TabIndex = 10;
            this.cmd_output.Text = "";
            // 
            // ZPAQ_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 506);
            this.Controls.Add(this.cmd_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.folders_add);
            this.Controls.Add(this.files_remove);
            this.Controls.Add(this.files_add);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dest_btn);
            this.Controls.Add(this.dest_txt);
            this.Controls.Add(this.label1);
            this.Name = "ZPAQ_Main";
            this.Text = "ZPAQ GUI";
            this.Load += new System.EventHandler(this.ZPAQ_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dest_txt;
        private System.Windows.Forms.Button dest_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button files_add;
        private System.Windows.Forms.Button files_remove;
        private System.Windows.Forms.Button folders_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox cmd_output;
    }
}

