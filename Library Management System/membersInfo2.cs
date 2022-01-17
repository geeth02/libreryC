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
    public partial class membersInfo2 : Form
    {
        public membersInfo2()
        {
            InitializeComponent();
        }

        private void membersInfo2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarydbDataSet4.Memberdb' table. You can move, or remove it, as needed.
            this.memberdbTableAdapter.Fill(this.librarydbDataSet4.Memberdb);

        }
    }
}
