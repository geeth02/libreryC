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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            register r1 = new register();
            r1.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
             Editemember e1 = new Editemember();
            e1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addnewBooks adnew= new addnewBooks();
            adnew.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtid.Text;
                string query_search = "SELECT*from booksdb where bookName='" + search + "'";
                SqlCommand cmd = new SqlCommand(query_search, con3);
                con3.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtavb.Text= r[4].ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while searching" + ex);
            }
            finally
            {
                con3.Close();
            }
        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            borrowBook adnew = new borrowBook();
            adnew.Show();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            returnBooks rbook = new returnBooks();
            rbook.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteMembers dmembers = new deleteMembers();
            dmembers.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtavb.Clear();
            txtid.Clear();
        }

        private void registerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewBooks adnb = new addnewBooks();
            adnb.Show();
        }

        private void editMemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r1 = new register();
            r1.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowBook bb = new borrowBook();
            bb.Show();
        }

        private void returnBooksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            returnBooks rtnb = new returnBooks();
            rtnb.Show();
        }

        private void editeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editemember em = new Editemember();
            em.Show();
        }

        private void deleteMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteMembers dm = new deleteMembers();
            dm.Show();
        }
    }
}
