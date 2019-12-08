using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class lists : Form
    {
        public lists()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button8.Visible = true;
            label1.Visible = true;




        }

        private void lists_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            listpoint lp = new listpoint();
            lp.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpGame lp = new HelpGame();
            lp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            levels lp = new levels();
            lp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lp = new login();
            lp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
