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
    public partial class Editemember : Form
    {
        public Editemember()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = int.Parse(txtid.Text);
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string address = txtadd.Text;
                string email = txtemail.Text;
                int pnumber = int.Parse(txtphnumber.Text);
                string bday = txtbirthday.Text;
                string gender = null;
                if (radiomale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string query_updatesql = "update memberdb set memberID='" + mid + "',fristName='" + fname + "',lastName='" + lname + "',address='" + address + "',email='" + email + "',pnumber='" + pnumber + "',biryhday='" + bday + "',gender='" + gender + "'WHERE memberID='" + mid + "'";
                SqlCommand cmnd = new SqlCommand(query_updatesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                
                MessageBox.Show("successfull");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while insert" + ex);
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

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void btnserchm_Click(object sender, EventArgs e)
        {
            try
            {
                int search = int.Parse(txtsmember.Text);
                string query_search = "SELECT*from memberdb where memberID='" + search + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtid.Text = r[0].ToString();
                    txtfname.Text = r[1].ToString();
                    txtlname.Text = r[2].ToString();
                    txtadd.Text = r[3].ToString();
                    txtemail.Text = r[4].ToString();
                    txtphnumber.Text = r[5].ToString();
                    txtbirthday.Text = r[6].ToString();
                    string gen = r[7].ToString();
                    if (gen == "male")
                    {
                        radiofemale.Checked = true;
                    }
                    else if (gen == "female")
                    {
                        radiofemale.Checked = true;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while searching" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtadd.Clear();
            txtbirthday.Clear();
            txtemail.Clear();
            txtfname.Clear();
            txtid.Clear();
            txtlname.Clear();
            txtphnumber.Clear();
            txtsmember.Clear();
        }
        
    }
}
