namespace zpaq_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZPAQ_Main));
            this.version_label = new System.Windows.Forms.Label();
            this.dest_txt = new System.Windows.Forms.TextBox();
            this.dest_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastmodified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settings_btn = new System.Windows.Forms.Button();
            this.files_add = new System.Windows.Forms.Button();
            this.files_remove = new System.Windows.Forms.Button();
            this.folders_add = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.cmd_output = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.command_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.reportbug = new System.Windows.Forms.LinkLabel();
            this.showFolder = new System.Windows.Forms.Button();
            filesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // filesize
            // 
            filesize.Text = "Size";
            filesize.Width = 55;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(12, 482);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(47, 13);
            this.version_label.TabIndex = 0;
            this.version_label.Text = "V0.0.0.0";
            // 
            // dest_txt
            // 
            this.dest_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dest_txt.Location = new System.Drawing.Point(19, 30);
            this.dest_txt.Name = "dest_txt";
            this.dest_txt.Size = new System.Drawing.Size(510, 20);
            this.dest_txt.TabIndex = 1;
            // 
            // dest_btn
            // 
            this.dest_btn.Image = global::zpaq_GUI.Properties.Resources.browse;
            this.dest_btn.Location = new System.Drawing.Point(535, 25);
            this.dest_btn.Name = "dest_btn";
            this.dest_btn.Size = new System.Drawing.Size(75, 30);
            this.dest_btn.TabIndex = 2;
            this.dest_btn.Text = "Browse";
            this.dest_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dest_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dest_btn.UseVisualStyleBackColor = true;
            this.dest_btn.Click += new System.EventHandler(this.dest_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
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
            this.lastmodified,
            filesize});
            this.listView1.Location = new System.Drawing.Point(19, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 245);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // filename
            // 
            this.filename.Text = "File Name";
            this.filename.Width = 507;
            // 
            // lastmodified
            // 
            this.lastmodified.Text = "Last Modified";
            this.lastmodified.Width = 176;
            // 
            // settings_btn
            // 
            this.settings_btn.Image = global::zpaq_GUI.Properties.Resources.cogwheel;
            this.settings_btn.Location = new System.Drawing.Point(732, 24);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(32, 32);
            this.settings_btn.TabIndex = 5;
            this.settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // files_add
            // 
            this.files_add.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_add.Image = global::zpaq_GUI.Properties.Resources.addfile;
            this.files_add.Location = new System.Drawing.Point(19, 308);
            this.files_add.Name = "files_add";
            this.files_add.Size = new System.Drawing.Size(141, 34);
            this.files_add.TabIndex = 6;
            this.files_add.Text = "Add Files";
            this.files_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.files_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.files_add.UseVisualStyleBackColor = true;
            this.files_add.Click += new System.EventHandler(this.files_add_Click);
            // 
            // files_remove
            // 
            this.files_remove.Enabled = false;
            this.files_remove.Location = new System.Drawing.Point(688, 314);
            this.files_remove.Name = "files_remove";
            this.files_remove.Size = new System.Drawing.Size(74, 23);
            this.files_remove.TabIndex = 7;
            this.files_remove.Text = "Remove";
            this.files_remove.UseVisualStyleBackColor = true;
            this.files_remove.Click += new System.EventHandler(this.files_remove_Click);
            // 
            // folders_add
            // 
            this.folders_add.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folders_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.folders_add.Image = global::zpaq_GUI.Properties.Resources.addfolder;
            this.folders_add.Location = new System.Drawing.Point(166, 308);
            this.folders_add.Name = "folders_add";
            this.folders_add.Size = new System.Drawing.Size(128, 34);
            this.folders_add.TabIndex = 8;
            this.folders_add.Text = "Add Folders";
            this.folders_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.folders_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.folders_add.UseVisualStyleBackColor = true;
            this.folders_add.Click += new System.EventHandler(this.folders_add_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_btn.Location = new System.Drawing.Point(70, 366);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(113, 44);
            this.start_btn.TabIndex = 9;
            this.start_btn.Text = "Start";
            this.start_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_output
            // 
            this.cmd_output.Location = new System.Drawing.Point(229, 346);
            this.cmd_output.Name = "cmd_output";
            this.cmd_output.ReadOnly = true;
            this.cmd_output.Size = new System.Drawing.Size(533, 151);
            this.cmd_output.TabIndex = 10;
            this.cmd_output.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Extract GUI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // command_in
            // 
            this.command_in.Location = new System.Drawing.Point(300, 316);
            this.command_in.Name = "command_in";
            this.command_in.ReadOnly = true;
            this.command_in.Size = new System.Drawing.Size(382, 20);
            this.command_in.TabIndex = 12;
            this.command_in.Click += new System.EventHandler(this.command_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Notice: It may save the folder structure at this time, sorry";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(134, 482);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github Source";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // reportbug
            // 
            this.reportbug.AutoSize = true;
            this.reportbug.Location = new System.Drawing.Point(67, 482);
            this.reportbug.Name = "reportbug";
            this.reportbug.Size = new System.Drawing.Size(61, 13);
            this.reportbug.TabIndex = 15;
            this.reportbug.TabStop = true;
            this.reportbug.Text = "Report Bug";
            this.reportbug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reportbug_LinkClicked);
            // 
            // showFolder
            // 
            this.showFolder.Enabled = false;
            this.showFolder.Location = new System.Drawing.Point(70, 416);
            this.showFolder.Name = "showFolder";
            this.showFolder.Size = new System.Drawing.Size(113, 37);
            this.showFolder.TabIndex = 16;
            this.showFolder.Text = "Open Folder";
            this.showFolder.UseVisualStyleBackColor = true;
            this.showFolder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ZPAQ_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 504);
            this.Controls.Add(this.showFolder);
            this.Controls.Add(this.reportbug);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.command_in);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_output);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.folders_add);
            this.Controls.Add(this.files_remove);
            this.Controls.Add(this.files_add);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dest_btn);
            this.Controls.Add(this.dest_txt);
            this.Controls.Add(this.version_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZPAQ_Main";
            this.Text = "ZPAQ GUI";
            this.Load += new System.EventHandler(this.ZPAQ_Main_Load);
            this.Shown += new System.EventHandler(this.ZPAQ_Main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.TextBox dest_txt;
        private System.Windows.Forms.Button dest_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button files_add;
        private System.Windows.Forms.Button files_remove;
        private System.Windows.Forms.Button folders_add;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.RichTextBox cmd_output;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox command_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel reportbug;
        private System.Windows.Forms.ColumnHeader lastmodified;
        private System.Windows.Forms.Button showFolder;
    }
}

