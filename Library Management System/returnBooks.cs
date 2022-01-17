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
    public partial class returnBooks : Form
    {
        public returnBooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\return.mdf;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
        SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
        private void btnok1_Click(object sender, EventArgs e)
        {
            try
            {
                int search = int.Parse(txtid.Text);
                string query_search = "SELECT*from issuedb1 where issueNumber='" + search + "'";
                SqlCommand cmd1 = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd1.ExecuteReader();
                while (r.Read())
                {
                    txtmid.Text = r[0].ToString();
                    txtmname.Text = r[1].ToString();
                    txtsnumber.Text = r[6].ToString();
                    txtbnumber.Text = r[7].ToString();
                    txtbname.Text = r[8].ToString();
                    txtidate.Text = r[5].ToString();
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
            int bnum = int.Parse(txtbnumber.Text);
            string query_search1 = "SELECT*from booksdb where bookNumber='" + bnum + "'";
            SqlCommand cmd2 = new SqlCommand(query_search1, con);
            con.Open();
            SqlDataReader a = cmd2.ExecuteReader();
            while (a.Read())
            {
                txtavb.Text = a[4].ToString();

            }
        }

        private void btnok2_Click(object sender, EventArgs e)
        {
            //fine calculate
            int tdays = int.Parse(txttdays.Text);
            int fine;
            if (tdays <= 7)
            {
                fine = 0;
                txtfine.Text = fine.ToString();
            }
            else if (tdays <= 14)
            {
                fine = (tdays - 7) * 10;
                txtfine.Text = fine.ToString();
            }
            else if (tdays <= 21)
            {
                fine = (tdays - 7) * 15;
                txtfine.Text = fine.ToString();
            }
            else if (tdays <= 30)
            {
                fine = (tdays - 7) * 20;
                txtfine.Text = fine.ToString();
            }
            else if (tdays > 30)
            {
                fine = (tdays - 7) * 25;
                txtfine.Text = fine.ToString();
                MessageBox.Show("Canseled your membership","Cansal",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbname.Clear();
            txtbnumber.Clear();
            txtidate.Clear();
            txtfine.Clear();
            txtid.Clear();
            txtmid.Clear();
            txtmname.Clear();
            txtrnumber.Clear();
            txtsnumber.Clear();
            txttdays.Clear();
            txtavb.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            try
            {
                int rnumber = int.Parse(txtrnumber.Text);
                int mid = int.Parse(txtmid.Text);
                int ino = int.Parse(txtsnumber.Text);
                string mname = txtmname.Text;
                int bno = int.Parse(txtbnumber.Text);
                string bname = txtbname.Text;
                string idate = txtidate.Text;
                string query_insert = "INSERT INTO returndb VALUES('" + rnumber + "','" + mid + "','" + ino + "','" + mname + "','" + bno + "','" + idate + "','" + rdate.Value.ToString() +"')";
                SqlCommand cmnd = new SqlCommand(query_insert, con1);
                con1.Open();
                cmnd.ExecuteNonQuery();
                 }
            catch (Exception ex)
            {
                MessageBox.Show("error while Add" + ex);
            }
            finally
            {
                con1.Close();
            }
            try
            {
                int count = int.Parse(txtavb.Text);
                int bnumber = int.Parse(txtbnumber.Text);
                count = count + 1;
                string query_updatesql = "update booksdb set count='" + count + "' WHERE bookNumber='" + bnumber + "'";
                SqlCommand cmnd2 = new SqlCommand(query_updatesql, con);
                con2.Open();
                cmnd2.ExecuteNonQuery();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("error while Add" + ex);
            }
            finally
            {
                con2.Close();
            }
            try
            {
                int inumber = int.Parse(txtsnumber.Text);
                string deletesql = "delete issuedb1 where issueNumber='" + inumber + "'";
                SqlCommand cmnd1 = new SqlCommand(deletesql, con3);
                con3.Open();
                cmnd1.ExecuteNonQuery();
                MessageBox.Show("successfull","Return this book",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                 }
            catch (Exception ex)
            {
                MessageBox.Show("error while Add" + ex);
            }
            finally
            {
                con3.Close();
            }
        }

        private void returnBooks_Load(object sender, EventArgs e)
        {
            txtmid.Enabled = false;
            txtmname.Enabled = false;
            txtsnumber.Enabled = false;
            txtbnumber.Enabled = false;
            txtbname.Enabled = false;
            txtidate.Enabled = false;
            txtfine.Enabled = false;
            txtavb.Enabled = false;
        }

        private void btnbissueinfo_Click(object sender, EventArgs e)
        {
            bookissueInfo bi= new bookissueInfo();
            bi.Show();
        }

        private void btnminfo_Click(object sender, EventArgs e)
        {
            membersInfo2 mi = new membersInfo2();
            mi.Show();
        }

        private void btnbinfo_Click(object sender, EventArgs e)
        {
            bookInfo booki = new bookInfo();
            booki.Show();
        }

        private void btnbookrinfo_Click(object sender, EventArgs e)
        {
            bookReturaInfo bri = new bookReturaInfo();
            bri.Show();
        }
    }
}
