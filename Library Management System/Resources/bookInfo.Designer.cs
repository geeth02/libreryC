namespace Library_Management_System
{
    partial class bookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.librarydbDataSet3 = new Library_Management_System.librarydbDataSet3();
            this.booksdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksdbTableAdapter = new Library_Management_System.librarydbDataSet3TableAdapters.BooksdbTableAdapter();
            this.bookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNumberDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.autherNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksdbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 529);
            this.dataGridView1.TabIndex = 0;
            // 
            // librarydbDataSet3
            // 
            this.librarydbDataSet3.DataSetName = "librarydbDataSet3";
            this.librarydbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksdbBindingSource
            // 
            this.booksdbBindingSource.DataMember = "Booksdb";
            this.booksdbBindingSource.DataSource = this.librarydbDataSet3;
            // 
            // booksdbTableAdapter
            // 
            this.booksdbTableAdapter.ClearBeforeFill = true;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MintCream;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Impact", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.ImageKey = "(none)";
            this.label10.Location = new System.Drawing.Point(657, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 60);
            this.label10.TabIndex = 52;
            this.label10.Text = "LIBRARY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(574, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 64);
            this.label1.TabIndex = 53;
            this.label1.Text = "Books Info";
            // 
            // bookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bookInfo";
            this.Text = "bookInfo";
            this.Load += new System.EventHandler(this.bookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private librarydbDataSet3 librarydbDataSet3;
        private System.Windows.Forms.BindingSource booksdbBindingSource;
        private librarydbDataSet3TableAdapters.BooksdbTableAdapter booksdbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}