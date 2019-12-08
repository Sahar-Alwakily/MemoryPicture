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
    public partial class listpoint : Form
    {
        public string path = @"..\..\memorysql.accdb";

        public listpoint()
        {
            InitializeComponent();
        }

        private void listpoint_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;




            QueryAllPoints();
        }

        private void QueryAllPoints()
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + path;

            OleDbConnection conn = new OleDbConnection(constr);



            try
            {

                conn.Open();
                string sql = "select * from accunt";
                OleDbDataAdapter sda = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "name";
                dataGridView1.Columns[2].HeaderText = "point";

                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = Color.PaleTurquoise;
                dataGridView1.MultiSelect = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lists lp = new lists();
            lp.Show();
        }
    }
}
