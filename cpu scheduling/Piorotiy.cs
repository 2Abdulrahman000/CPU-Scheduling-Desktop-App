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
    public partial class Piorotiy : Form
    {
        int sum_turn = 0;
        int sum_wating = 0;
        int[]values = new int[8];
        int[] pir_values = new int[4];
        int burst1, burst2, burst3, burst4;
        int pir1, pir2, pir3, pir4;
        float avg_turn, avg_wating;
       
        public Piorotiy()
        {
            InitializeComponent();
        }


        private void btn_cal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                sum_turn += pir_values[i];
            }
            avg_turn = sum_turn / 4.0f;
            res_turn.Text = avg_turn + " ms";

            for (int i = 0; i < 3; i++)
            {
                sum_wating += pir_values[i];
            }
            avg_wating = sum_wating / 4.0f;
            res_wating.Text = avg_wating + " ms";
        }
        private void btn_GC_Click(object sender, EventArgs e)
        {
            burst1 = Convert.ToInt32(txt_burst1.Text);
            burst2 = Convert.ToInt32(txt_burst2.Text);
            burst3 = Convert.ToInt32(txt_burst3.Text);
            burst4 = Convert.ToInt32(txt_burst4.Text);

            pir1 = Convert.ToInt32(txt_pirority1.Text);
            pir2 = Convert.ToInt32(txt_pirority2.Text);
            pir3 = Convert.ToInt32(txt_pirority3.Text);
            pir4 = Convert.ToInt32(txt_pirority4.Text);

            values[0] = pir1; values[1] = burst1;
            values[2] = pir2; values[3] = burst2;
            values[4] = pir3; values[5] = burst3;
            values[6] = pir4; values[7] = burst4;

            int[] sortedarray = new int[4];
            sortedarray[0] = values[0];
            sortedarray[1] = values[2];
            sortedarray[2] = values[4];
            sortedarray[3] = values[6];
            Array.Sort(sortedarray);
            for (int j = 0 ; j<=6 ; j=j+2)
              {
                    //if (values[j] == 1) pir_values[0] = values[j + 1];
                    //else if (values[j] == 2) pir_values[1] = values[j + 1];
                    //else if (values[j] == 3) pir_values[2] = values[j + 1];
                    //else if (values[j] == 4) pir_values[3] = values[j + 1];
                for(int i=0;i<4;i++)
                {
                    if(values[j]==sortedarray[i]) pir_values[i] = values[j + 1];
                }
              }
            pir_values[0] = pir_values[0];
            pir_values[1] += pir_values[0];
            pir_values[2] += pir_values[1];
            pir_values[3] += pir_values[2];

            lab_end1.Text = pir_values[0] + "";
            lab_end2.Text = pir_values[1] + "";
            lab_end3.Text = pir_values[2] + "";
            lab_end4.Text = pir_values[3] + "";
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

    }
}
