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
    public partial class STJArrival : Form
    {
        int sum_turn = 0;
        int sum_wating = 0;
        int[] values = new int[8];
        int[] arrival_values = new int[4];
        int burst1, burst2, burst3, burst4;
        int arrival1, arrival2, arrival3, arrival4;
        float avg_turn, avg_wating;
        public STJArrival()
        {
            InitializeComponent();
        }

        private void btn_GC_Click(object sender, EventArgs e)
        {
            burst1 = Convert.ToInt32(txt_burst1.Text);
            burst2 = Convert.ToInt32(txt_burst2.Text);
            burst3 = Convert.ToInt32(txt_burst3.Text);
            burst4 = Convert.ToInt32(txt_burst4.Text);

            arrival1 = Convert.ToInt32(txt_arrival1.Text);
            arrival2 = Convert.ToInt32(txt_arrival2.Text);
            arrival3 = Convert.ToInt32(txt_arrival3.Text);
            arrival4 = Convert.ToInt32(txt_arrival4.Text);

            values[0] = arrival1; values[1] = burst1;
            values[2] = arrival2; values[3] = burst2;
            values[4] = arrival3; values[5] = burst3;
            values[6] = arrival4; values[7] = burst4;

            int[] burstsoted = new int[3];
            int[] timesorted = new int[4];
            timesorted[0] = arrival1;
            timesorted[1] = arrival2;
            timesorted[2] = arrival3;
            timesorted[3] = arrival4;
            Array.Sort(timesorted);
            for (int j = 0; j <= 6; j = j + 2)
            {
                if (values[j] == timesorted[0])
                {
                    arrival_values[0] = values[j + 1];
                    if(arrival_values[0]==values[1])//burst1
                    {
                        burstsoted[0] = values[3];//3  5  7
                        burstsoted[1] = values[5];
                        burstsoted[2] = values[7];
                    }
                    else if (arrival_values[0] == values[3])//burst 2
                    {
                        burstsoted[0] = values[1];//1 5 7
                        burstsoted[1] = values[5];
                        burstsoted[2] = values[7];
                    }
                    else if (arrival_values[0] == values[5])
                    {
                        burstsoted[0] = values[1];
                        burstsoted[1] = values[3];
                        burstsoted[2] = values[7];
                    }
                    else if (arrival_values[0] == values[7])
                    {
                        burstsoted[0] = values[1];
                        burstsoted[1] = values[3];
                        burstsoted[2] = values[5];
                    }
                }
            }
            Array.Sort(burstsoted);
            arrival_values[1] = burstsoted[0];
            arrival_values[2] = burstsoted[1];
            arrival_values[3] = burstsoted[2];

            arrival_values[0]  = arrival_values[0];
            arrival_values[1] += arrival_values[0];
            arrival_values[2] += arrival_values[1];
            arrival_values[3] += arrival_values[2];

            lab_end1.Text = arrival_values[0] + "";
            lab_end2.Text = arrival_values[1] + "";
            lab_end3.Text = arrival_values[2] + "";
            lab_end4.Text = arrival_values[3] + "";
        }
        private void btn_cal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                sum_turn += arrival_values[i];
            }
            avg_turn = sum_turn / 4.0f;
            res_turn.Text = avg_turn + " ms";

            for (int i = 0; i < 3; i++)
            {
                sum_wating += arrival_values[i];
            }
            avg_wating = sum_wating / 4.0f;
            res_wating.Text = avg_wating + " ms";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }


    }
}
