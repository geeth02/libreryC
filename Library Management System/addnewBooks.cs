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
    public partial class addnewBooks : Form
    {
        public addnewBooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Geeth\documents\visual studio 2013\Projects\Library Management System\Library Management System\librarydb.mdf;Integrated Security=True");
        private void addnewBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarydbDataSet.Booksdb' table. You can move, or remove it, as needed.
            this.booksdbTableAdapter.Fill(this.librarydbDataSet.Booksdb);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int bnum = int.Parse(txtbnum.Text);
                string bname = txtbname.Text;
                string auther = txtauther.Text;
                int price = int.Parse(txtprice.Text);
                int count = int.Parse(txtcount.Text);
                
                string query_insert = "INSERT INTO booksdb VALUES('" + bnum + "','" + bname + "','" + auther + "','" + price + "','" + count + "')";
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while Add" + ex);
            }
            finally
            {
                con.Close();
            }
            txtbnum.Clear();
            txtbname.Clear();
            txtauther.Clear();
            txtprice.Clear();
            txtcount.Clear();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int bnum = int.Parse(txtbnum.Text);
                string bname = txtbname.Text;
                string auther = txtauther.Text;
                int price = int.Parse(txtprice.Text);
                int count = int.Parse(txtcount.Text);

                string query_updatesql = "update booksdb set bookNumber='" + bnum + "',bookname='" + bname + "',autherName='" + auther + "',price='" + price + "',count='" + count + "'WHERE bookNumber='" + bnum + "'";
                SqlCommand cmnd = new SqlCommand(query_updatesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("successfull");
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

        private void btnbs_Click(object sender, EventArgs e)
        {
            try
            {
                int search = int.Parse(txtbsearch.Text);
                string query_search = "SELECT*from Booksdb where bookNumber='" + search + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtbnum.Text = r[0].ToString();
                    txtbname.Text = r[1].ToString();
                    txtauther.Text = r[2].ToString();
                    txtprice.Text = r[3].ToString();
                    txtcount.Text = r[4].ToString();

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int bnum = int.Parse(txtbnum.Text);
                string bname = txtbname.Text;
                string auther = txtauther.Text;
                int price = int.Parse(txtprice.Text);
                int count = int.Parse(txtcount.Text);

                string deletesql = "delete Booksdb where bookNumber='" + bnum + "'";
                SqlCommand cmnd = new SqlCommand(deletesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("successfull");

                
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtauther.Clear();
            txtbname.Clear();
            txtbnum.Clear();
            txtbsearch.Clear();
            txtcount.Clear();
            txtprice.Clear();
        }
    }
}
