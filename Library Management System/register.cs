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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
       

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = int.Parse(txtid.Text);
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string address = txtadd.Text;
                string email=txtemail.Text;
                int pnumber = int.Parse(txtphnumber.Text);
                string bday = txtbirthday.Text;
                string gender=null;
                if(radiomale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string query_insert="INSERT INTO memberdb VALUES('"+mid+"','"+fname+"','"+lname+"','"+address+"','"+email+"','"+pnumber+"','"+bday+"','"+gender+"')";
                SqlCommand cmnd=new SqlCommand(query_insert,con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("successfull");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error while insert"+ex);
            }
            finally
            {
                con.Close();
            }
            txtid.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtadd.Clear();
            txtemail.Clear();
            txtphnumber.Clear();
            txtbirthday.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
