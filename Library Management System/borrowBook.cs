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
    public partial class borrowBook : Form
    {
        public borrowBook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void borrowBook_Load(object sender, EventArgs e)
        {
            txtmid.Enabled = false;
            txtmname.Enabled = false;
            txtbname.Enabled = false;
            txtbnumber.Enabled = false;
            txtbname.Enabled = false;
            txtaddress.Enabled = false;
            txtpnumber.Enabled = false;
            txtemail.Enabled = false;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int search = int.Parse(txtid.Text);
                string query_search = "SELECT*from memberdb where memberId='" + search + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                   txtmid.Text = r[0].ToString();
                   txtmname.Text = r[1].ToString();
                   txtaddress.Text = r[3].ToString();
                   txtpnumber.Text = r[5].ToString();
                   txtemail.Text = r[4].ToString();

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

            try
            {
                int search = int.Parse(txtbnum.Text);
                string query_search = "SELECT*from booksdb where bookNumber='" + search + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtbnumber.Text = r[0].ToString();
                    txtbname.Text = r[1].ToString();
                    txtav.Text = r[4].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = int.Parse(txtmid.Text);
                string mname = txtmname.Text;
                string address = txtaddress.Text;
                int pnumber = int.Parse(txtpnumber.Text);
                string email = txtemail.Text;
                int snumber = int.Parse(txtsnumber.Text);
                int bnumber = int.Parse(txtbnumber.Text);
                string bname = txtbname.Text;
                string query_insert = "INSERT INTO issuedb VALUES('" + mid + "','" + mname + "','" + address + "','" + pnumber + "','" + email + "','" + date.Value.ToString()+ "','" + bnumber + "','" + bname+ "')";
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                cmnd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                con.Close();
            }
            try
            {
            int mid = int.Parse(txtmid.Text);
            string mname = txtmname.Text;
            string address = txtaddress.Text;
            int pnumber = int.Parse(txtpnumber.Text);
            string email = txtemail.Text;
            int snumber = int.Parse(txtsnumber.Text);
            int bnumber = int.Parse(txtbnumber.Text);
            string bname = txtbname.Text;
             string query_insert = "INSERT INTO issuedb1 VALUES('" + mid + "','" + mname + "','" + address + "','" + pnumber + "','" + email + "','" + date.Value.ToString() + "','"+snumber+"','" + bnumber + "','" + bname + "')";
                SqlCommand cmnd1 = new SqlCommand(query_insert, con);
                con.Open();
                cmnd1.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
            int count = int.Parse(txtav.Text);
            int bnum = int.Parse(txtbnum.Text);
            count = count - 1;
            string query_updatesql = "update booksdb set count='" + count + "' WHERE bookNumber='" + bnum + "'";
            SqlCommand cmnd2 = new SqlCommand(query_updatesql, con);
            con.Open();
            cmnd2.ExecuteNonQuery();
            MessageBox.Show("successfull");

        }


        private void button4_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtbname.Clear();
            txtbnum.Clear();
            txtbnumber.Clear();
            txtemail.Clear();
            txtid.Clear();
            txtmid.Clear();
            txtmname.Clear();
            txtpnumber.Clear();
            txtsnumber.Clear();
            txtav.Clear();
            txtbnumber.Clear();
            txtbname.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
