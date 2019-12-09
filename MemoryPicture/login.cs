using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class login : Form
    {

        public string path = @"..\..\database\memorypic.accdb";
        OleDbConnection connection = new OleDbConnection();


        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists f1 = new lists();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passlog.Visible = true;
            usernamelog.Visible = true;
            textBoxpasslog.Visible = true;
            textBoxuserlog.Visible = true;
            btnlogin.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            usernameup.Visible = true;
            nameup.Visible = true;
            passup.Visible = true;
            boxusername.Visible = true;
            textBoxname.Visible = true;
            textBoxpassup.Visible = true;
            sigupbtn.Visible = true;
            button2.Visible = false;
        }


       
    }
 }
