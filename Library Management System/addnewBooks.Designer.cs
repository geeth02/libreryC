namespace Library_Management_System
{
    partial class addnewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnewBooks));
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtauther = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtbnum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarydbDataSet = new Library_Management_System.librarydbDataSet();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnubdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbs = new System.Windows.Forms.Button();
            this.btndetele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.booksdbTableAdapter = new Library_Management_System.librarydbDataSetTableAdapters.BooksdbTableAdapter();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MintCream;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Impact", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.ImageKey = "(none)";
            this.label10.Location = new System.Drawing.Point(657, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 60);
            this.label10.TabIndex = 25;
            this.label10.Text = "LIBRARY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(574, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 64);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add New Book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Auther Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "Book Number";
            // 
            // txtcount
            // 
            this.txtcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtcount.Location = new System.Drawing.Point(204, 232);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(321, 22);
            this.txtcount.TabIndex = 32;
            // 
            // txtauther
            // 
            this.txtauther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtauther.Location = new System.Drawing.Point(204, 141);
            this.txtauther.Name = "txtauther";
            this.txtauther.Size = new System.Drawing.Size(321, 22);
            this.txtauther.TabIndex = 33;
            // 
            // txtbname
            // 
            this.txtbname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtbname.Location = new System.Drawing.Point(204, 94);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(321, 22);
            this.txtbname.TabIndex = 34;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtprice.Location = new System.Drawing.Point(204, 188);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(321, 22);
            this.txtprice.TabIndex = 35;
            // 
            // txtbnum
            // 
            this.txtbnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtbnum.Location = new System.Drawing.Point(204, 46);
            this.txtbnum.Name = "txtbnum";
            this.txtbnum.Size = new System.Drawing.Size(321, 22);
            this.txtbnum.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNumberDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.autherNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksdbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 581);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 240);
            this.dataGridView1.TabIndex = 37;
            // 
            // bookNumberDataGridViewTextBoxColumn
            // 
            this.bookNumberDataGridViewTextBoxColumn.DataPropertyName = "bookNumber";
            this.bookNumberDataGridViewTextBoxColumn.HeaderText = "bookNumber";
            this.bookNumberDataGridViewTextBoxColumn.Name = "bookNumberDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "bookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // autherNameDataGridViewTextBoxColumn
            // 
            this.autherNameDataGridViewTextBoxColumn.DataPropertyName = "autherName";
            this.autherNameDataGridViewTextBoxColumn.HeaderText = "autherName";
            this.autherNameDataGridViewTextBoxColumn.Name = "autherNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // booksdbBindingSource
            // 
            this.booksdbBindingSource.DataMember = "Booksdb";
            this.booksdbBindingSource.DataSource = this.librarydbDataSet;
            // 
            // librarydbDataSet
            // 
            this.librarydbDataSet.DataSetName = "librarydbDataSet";
            this.librarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd.Location = new System.Drawing.Point(715, 258);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(143, 51);
            this.btnadd.TabIndex = 39;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnexit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexit.Location = new System.Drawing.Point(715, 453);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(143, 51);
            this.btnexit.TabIndex = 38;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnubdate
            // 
            this.btnubdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnubdate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnubdate.Location = new System.Drawing.Point(715, 317);
            this.btnubdate.Name = "btnubdate";
            this.btnubdate.Size = new System.Drawing.Size(143, 51);
            this.btnubdate.TabIndex = 40;
            this.btnubdate.Text = "Update";
            this.btnubdate.UseVisualStyleBackColor = false;
            this.btnubdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.txtbsearch);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnbs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(919, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 297);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Books";
            // 
            // txtbsearch
            // 
            this.txtbsearch.Location = new System.Drawing.Point(75, 117);
            this.txtbsearch.Multiline = true;
            this.txtbsearch.Name = "txtbsearch";
            this.txtbsearch.Size = new System.Drawing.Size(296, 40);
            this.txtbsearch.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(130, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "Enter Book Id";
            // 
            // btnbs
            // 
            this.btnbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbs.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnbs.Location = new System.Drawing.Point(46, 188);
            this.btnbs.Name = "btnbs";
            this.btnbs.Size = new System.Drawing.Size(153, 44);
            this.btnbs.TabIndex = 9;
            this.btnbs.Text = "Search";
            this.btnbs.UseVisualStyleBackColor = false;
            this.btnbs.Click += new System.EventHandler(this.btnbs_Click);
            // 
            // btndetele
            // 
            this.btndetele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndetele.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndetele.Location = new System.Drawing.Point(715, 381);
            this.btndetele.Name = "btndetele";
            this.btndetele.Size = new System.Drawing.Size(143, 51);
            this.btndetele.TabIndex = 42;
            this.btndetele.Text = "Delete";
            this.btndetele.UseVisualStyleBackColor = false;
            this.btndetele.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.txtbnum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtcount);
            this.groupBox2.Controls.Add(this.txtbname);
            this.groupBox2.Controls.Add(this.txtauther);
            this.groupBox2.Location = new System.Drawing.Point(85, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 289);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(562, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 46);
            this.button4.TabIndex = 58;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(220, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 46);
            this.button5.TabIndex = 59;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // booksdbTableAdapter
            // 
            this.booksdbTableAdapter.ClearBeforeFill = true;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclear.Location = new System.Drawing.Point(235, 188);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(153, 44);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // addnewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1432, 833);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btndetele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnubdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Name = "addnewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Info";
            this.Load += new System.EventHandler(this.addnewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtauther;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtbnum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private librarydbDataSet librarydbDataSet;
        private System.Windows.Forms.BindingSource booksdbBindingSource;
        private librarydbDataSetTableAdapters.BooksdbTableAdapter booksdbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnubdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnbs;
        private System.Windows.Forms.Button btndetele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnclear;
    }
}