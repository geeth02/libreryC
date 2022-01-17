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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = "imbs"; //E mail 
            string pw = "123";     //password
            if(txtpw.Text==pw&&txtemail.Text==email)
            {
                MessageBox.Show("Login Successfull","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
                main m1 = new main();//Main Menu
                m1.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Loging not successfull","error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                txtpw.Clear();
                txtemail.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
