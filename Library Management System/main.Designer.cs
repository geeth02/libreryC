namespace Library_Management_System
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnborrow = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnmregister = new System.Windows.Forms.Button();
            this.btnemember = new System.Windows.Forms.Button();
            this.btndmember = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnbookinof = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtavb = new System.Windows.Forms.TextBox();
            this.returnBooksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FloralWhite;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMemberToolStripMenuItem,
            this.addNewBookToolStripMenuItem,
            this.returnBooksToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.fileToolStripMenuItem.Text = "Books";
            // 
            // registerMemberToolStripMenuItem
            // 
            this.registerMemberToolStripMenuItem.Name = "registerMemberToolStripMenuItem";
            this.registerMemberToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.registerMemberToolStripMenuItem.Text = "Books Info";
            this.registerMemberToolStripMenuItem.Click += new System.EventHandler(this.registerMemberToolStripMenuItem_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addNewBookToolStripMenuItem.Text = "Borrow Books";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMemberDetailsToolStripMenuItem,
            this.editeBookDetailsToolStripMenuItem,
            this.deleteMembersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.editToolStripMenuItem.Text = "Members";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // editMemberDetailsToolStripMenuItem
            // 
            this.editMemberDetailsToolStripMenuItem.Name = "editMemberDetailsToolStripMenuItem";
            this.editMemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.editMemberDetailsToolStripMenuItem.Text = "Register Members";
            this.editMemberDetailsToolStripMenuItem.Click += new System.EventHandler(this.editMemberDetailsToolStripMenuItem_Click);
            // 
            // editeBookDetailsToolStripMenuItem
            // 
            this.editeBookDetailsToolStripMenuItem.Name = "editeBookDetailsToolStripMenuItem";
            this.editeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.editeBookDetailsToolStripMenuItem.Text = "Edite Member Details";
            this.editeBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.editeBookDetailsToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1118, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1381, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Impact", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(565, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "LIBRARY";
            // 
            // btnborrow
            // 
            this.btnborrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnborrow.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnborrow.Location = new System.Drawing.Point(29, 194);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(262, 107);
            this.btnborrow.TabIndex = 7;
            this.btnborrow.Text = "Borrow Books";
            this.btnborrow.UseVisualStyleBackColor = false;
            this.btnborrow.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreturn.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreturn.Location = new System.Drawing.Point(29, 360);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(262, 107);
            this.btnreturn.TabIndex = 8;
            this.btnreturn.Text = "Return Books";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnmregister
            // 
            this.btnmregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnmregister.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmregister.Location = new System.Drawing.Point(30, 33);
            this.btnmregister.Name = "btnmregister";
            this.btnmregister.Size = new System.Drawing.Size(262, 107);
            this.btnmregister.TabIndex = 10;
            this.btnmregister.Text = "Register Member";
            this.btnmregister.UseVisualStyleBackColor = false;
            this.btnmregister.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnemember
            // 
            this.btnemember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnemember.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnemember.Location = new System.Drawing.Point(30, 194);
            this.btnemember.Name = "btnemember";
            this.btnemember.Size = new System.Drawing.Size(262, 107);
            this.btnemember.TabIndex = 11;
            this.btnemember.Text = "Edite member details";
            this.btnemember.UseVisualStyleBackColor = false;
            this.btnemember.Click += new System.EventHandler(this.button5_Click);
            // 
            // btndmember
            // 
            this.btndmember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndmember.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndmember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndmember.Location = new System.Drawing.Point(41, 360);
            this.btndmember.Name = "btndmember";
            this.btndmember.Size = new System.Drawing.Size(262, 107);
            this.btndmember.TabIndex = 12;
            this.btndmember.Text = "Delete Member";
            this.btndmember.UseVisualStyleBackColor = false;
            this.btndmember.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexit.Location = new System.Drawing.Point(908, 555);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(170, 72);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnbookinof
            // 
            this.btnbookinof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbookinof.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookinof.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnbookinof.Location = new System.Drawing.Point(29, 33);
            this.btnbookinof.Name = "btnbookinof";
            this.btnbookinof.Size = new System.Drawing.Size(262, 107);
            this.btnbookinof.TabIndex = 14;
            this.btnbookinof.Text = "Books Info";
            this.btnbookinof.UseVisualStyleBackColor = false;
            this.btnbookinof.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnborrow);
            this.groupBox1.Controls.Add(this.btnreturn);
            this.groupBox1.Controls.Add(this.btnbookinof);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(108, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 518);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Books";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btndmember);
            this.groupBox2.Controls.Add(this.btnmregister);
            this.groupBox2.Controls.Add(this.btnemember);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(486, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 518);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Members";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.Location = new System.Drawing.Point(1101, 555);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(170, 72);
            this.btnlogout.TabIndex = 18;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsearch.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsearch.Location = new System.Drawing.Point(25, 175);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(153, 44);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Book Name\r\n";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclear.Location = new System.Drawing.Point(210, 175);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(153, 44);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txtavb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(908, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 241);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Books";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(249, 64);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(128, 35);
            this.txtid.TabIndex = 19;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "Avelable Books";
            // 
            // txtavb
            // 
            this.txtavb.Location = new System.Drawing.Point(249, 118);
            this.txtavb.Multiline = true;
            this.txtavb.Name = "txtavb";
            this.txtavb.Size = new System.Drawing.Size(128, 35);
            this.txtavb.TabIndex = 22;
            // 
            // returnBooksToolStripMenuItem1
            // 
            this.returnBooksToolStripMenuItem1.Name = "returnBooksToolStripMenuItem1";
            this.returnBooksToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.returnBooksToolStripMenuItem1.Text = "Return Books";
            this.returnBooksToolStripMenuItem1.Click += new System.EventHandler(this.returnBooksToolStripMenuItem1_Click);
            // 
            // deleteMembersToolStripMenuItem
            // 
            this.deleteMembersToolStripMenuItem.Name = "deleteMembersToolStripMenuItem";
            this.deleteMembersToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.deleteMembersToolStripMenuItem.Text = "Delete Members";
            this.deleteMembersToolStripMenuItem.Click += new System.EventHandler(this.deleteMembersToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMemberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnborrow;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnmregister;
        private System.Windows.Forms.Button btnemember;
        private System.Windows.Forms.Button btndmember;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnbookinof;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtavb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteMembersToolStripMenuItem;
    }
}