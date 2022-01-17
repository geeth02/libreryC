using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class deleteMembers : Form
    {
        public deleteMembers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
       
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = int.Parse(txtmid.Text);
                string deletesql = "delete Memberdb where memberId ='" + mid + "'";
                SqlCommand cmnd1 = new SqlCommand(deletesql, con);
                con.Open();
                cmnd1.ExecuteNonQuery();
                MessageBox.Show("successfull","Delete this member",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while Add" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
