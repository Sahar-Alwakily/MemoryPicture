using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class Profile : Form
    {

        public string path = @"..\..\database\memorypic.accdb";

        public Profile()
        {
            InitializeComponent();
        }
        public Profile(String user)
        {
            InitializeComponent();
            nameplayer.Text = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            try
            {


                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path);
                con.Open();
                OleDbCommand cmdoledb = con.CreateCommand();
                cmdoledb.Connection = con;
                string query = "select * from player where username='"+ nameplayer.Text + "'";
                cmdoledb.CommandText = query;
                OleDbDataReader reader = cmdoledb.ExecuteReader();
                while (reader.Read())
                {
                    levels.Text = reader["level"].ToString();
                    lfalse.Text = reader["false"].ToString();
                    lpoints.Text = reader["point"].ToString();

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
