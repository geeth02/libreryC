using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class bookInfo : Form
    {
        public bookInfo()
        {
            InitializeComponent();
        }

        private void bookInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarydbDataSet3.Booksdb' table. You can move, or remove it, as needed.
            this.booksdbTableAdapter.Fill(this.librarydbDataSet3.Booksdb);

        }
    }
}
