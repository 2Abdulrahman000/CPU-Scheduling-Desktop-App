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
    public partial class STJ : Form
    {
        int sum_turn = 0;
        int sum_wating = 0;
        int[] values = new int[4];
        int burst1, burst2, burst3, burst4;
        float avg_turn, avg_wating;
        public STJ()
        {
            InitializeComponent();
        }


        private void btn_cal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                sum_turn += values[i];
            }
            avg_turn = sum_turn / 4.0f;
            res_turn.Text = avg_turn + " ms";

            for (int i = 0; i < 3; i++)
            {
                sum_wating += values[i];
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

            values[0] = burst1;
            values[1] = burst2;
            values[2] = burst3;
            values[3] = burst4;

            Array.Sort(values);
            values[0] = values[0];
            values[1] += values[0];
            values[2] += values[1];
            values[3] += values[2];

            lab_end1.Text = values[0] + "";
            lab_end2.Text = values[1] + "";
            lab_end3.Text = values[2] + "";
            lab_end4.Text = values[3] + "";
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

    }
}
