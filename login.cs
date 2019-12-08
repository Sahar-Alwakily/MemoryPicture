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

        public string path = @"..\..\memorysql.accdb";
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

        private void sigupbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path);
            OleDbCommand cmdoledb = new OleDbCommand();
            con.Open();
            try{
                OleDbCommand cmd = new OleDbCommand("INSERT INTO accunt (username,password,name) VALUES ('" + boxusername.Text.ToString() + "','" + textBoxpassup.ToString() + "','" + textBoxname.ToString() + "')", con);

                // OleDbCommand cmd = new OleDbCommand("INSERT INTO accunt(username,password,name) values(@username,@password,@name)", con);
                //  cmd.Parameters.AddWithValue("@username", boxusername.Text);
                // cmd.Parameters.AddWithValue("@password", textBoxpassup.Text);
                //  cmd.Parameters.AddWithValue("@name", textBoxname.Text);


                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("not login up" + ex);
            }
            











            /* string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
             connection.ConnectionString = constr;
             // OleDbConnection conn = new OleDbConnection(constr);
             try
             {

                 connection.Open();
                 OleDbCommand commed = new OleDbCommand(constr);
                 commed.Connection = connection;
                // OleDbCommand cmd = new OleDbCommand("INSERT INTO Members(username,password,name) values('" + boxusername.Text + "','" + textBoxpassup.Text + "','" + textBoxname.Text + "')", con);

                 commed.CommandText = "INSERT INTO accunt(username,password,name)VALUES('" + boxusername.Text.ToString() + "','" + textBoxpassup.Text.ToString() + "','" + textBoxname.Text.ToString() + "')";
                 commed.ExecuteNonQuery();
                 MessageBox.Show("Done :)");
               //  string sql = "select * from accunt";
               //OleDbDataAdapter sda = new OleDbDataAdapter(sql, conn);
               //   DataSet ds = new DataSet();
               //sda.Fill(ds);

             }
             catch(Exception ex)
             {
                 MessageBox.Show("not login up"+ex);
             }*/
        }
    }
}