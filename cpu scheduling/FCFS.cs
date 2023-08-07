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
    public partial class FCFS : Form
    {
        int burst1, burst2, burst3, burst4;
        int sum_wating = 0;
        int sum_turn = 0;
        float avg_wating, avg_turn;

        public FCFS()
        {
            InitializeComponent();
            
        }

        private void btn_GC_Click(object sender, EventArgs e)
        {
            if (txt_burst1.Text != "")
            {
                //gant chart name proccess
                lb_pan1.Text = txt_p1.Text;
                lb_pan2.Text = txt_p2.Text;
                lab_pan3.Text = txt_p3.Text;
                lab_pan4.Text = txt_p4.Text;


                burst1 = Convert.ToInt32(txt_burst1.Text);//(3)+0 --> 3
                burst2 = burst1 + Convert.ToInt32(txt_burst2.Text);//3+(4) --> 7
                burst3 = burst2 + Convert.ToInt32(txt_burst3.Text);//3+4+(2) -->9 
                burst4 = burst3 + Convert.ToInt32(txt_burst4.Text);//3+4+2+(3) -->12

                //value of proccess
                lab_end1.Text = burst1 + "";
                lab_end2.Text = burst2 + "";
                lab_end3.Text = burst3 + "";
                lab_end4.Text = burst4 + "";
            }
            else MessageBox.Show("Not Found Value");
    
        }
        private void btn_cal_Click(object sender, EventArgs e)
        {
            int[] bursts = new int[4];
            bursts[0] = burst1;
            bursts[1] = burst2;
            bursts[2] = burst3;
            bursts[3] = burst4;
            for (int i = 0; i < 4; i++)
            {
                sum_turn += bursts[i];
            }
            avg_turn = sum_turn / 4.0f;
            res_turn.Text = avg_turn+"";

            for (int i = 0; i < 3; i++)
            {
                sum_wating += bursts[i];
            }
            avg_wating = sum_wating / 4.0f;
            res_wating.Text = avg_wating + "";

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
