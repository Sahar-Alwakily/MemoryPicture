# MemoryPictureusing System;
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


    public partial class levels : Form
    {

        player pl = new player("d", "s", 100);
        public string path = @"..\..\memorysql.accdb";
        public levels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lp = new Form1();
            lp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string constr = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + path;
            OleDbConnection conn = new OleDbConnection(constr);


            try
            {
                string sql = "select * from course where Name like '"+pl+"'";

                sql = string.Format(sql, pl);
                OleDbDataAdapter sda = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show("done" + ex.Message);
            }
          //  int po = pl.getpoint;
        //    if(pl.)

    }

    private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists f1 = new lists();
            f1.Show();
        }

        private void levels_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
