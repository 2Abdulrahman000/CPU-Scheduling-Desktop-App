using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpu_scheduling
{
    public partial class Form1 : Form
    {
        string txt;
        int ln;
        int counter=0;
        int panel_wd;
        bool hidden;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fcfs_Click(object sender, EventArgs e)
        {
            FCFS form2 = new FCFS();
            form2.Show();
            this.Hide();
        }

        private void btn_bio_Click(object sender, EventArgs e)
        {
            Piorotiy form3 = new Piorotiy();
            form3.Show();
            this.Hide();
        }

        private void btn_rr_Click(object sender, EventArgs e)
        {
            STJ form2 = new STJ();
            form2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > ln) timer1.Stop();
            else
            {
                label1.Text = txt.Substring(0, counter);
            }
            if (label1.Text == txt)
            {
                label1.ForeColor = Color.Teal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            ln = txt.Length;
            label1.Text = "";
            timer1.Start();
            panel_wd = panel1.Width;
            hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCFSArrival form4 = new FCFSArrival();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            STJArrival form5 = new STJArrival();
            form5.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_slider_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel1.Width += 16;
                if (panel1.Width == 227)
                {
                    timer_slider.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width -= 16;
                if (panel1.Width == 0)
                {
                    timer_slider.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btn_slider_Click(object sender, EventArgs e)
        {
        }
    }
}
