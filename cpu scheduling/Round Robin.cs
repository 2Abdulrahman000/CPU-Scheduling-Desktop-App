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
    public partial class Round_Robin : Form
    {
        int[] burstvalues = new int[4];
        int burst1, burst2, burst3, burst4;
        int sum_wating = 0;
        int sum_turn = 0;
        float avg_wating, avg_turn;

        private void btn_cal_Click(object sender, EventArgs e)
        {
            sum_wating = 0 + burst1 + burst2 + burst3;
            avg_wating = sum_wating / 4.0f;

            sum_turn = burst1 + burst2 + burst3 + burst4;
            avg_turn = sum_turn / 4.0f;

            res_wating.Text = avg_wating + " ms";
            res_turn.Text = avg_turn + " ms";
        }

        public Round_Robin()
        {
            InitializeComponent();
        }

        private void Round_Robin_Load(object sender, EventArgs e)
        {

        }

        private void btn_GC_Click(object sender, EventArgs e)
        {
            burstvalues[0] = Convert.ToInt32(txt_burst1.Text);
            burstvalues[1] = Convert.ToInt32(txt_burst2.Text);
            burstvalues[2] = Convert.ToInt32(txt_burst3.Text);
            burstvalues[3] = Convert.ToInt32(txt_burst4.Text);
            Array.Sort(burstvalues);

            burst1 = burstvalues[0];
            burst2 = burst1+ burstvalues[1];
            burst3 = burst2 + burstvalues[2];
            burst4 = burst3 + burstvalues[3];

            lab_end1.Text = burst1 + "";
            lab_end2.Text = burst2 + "";
            lab_end3.Text = burst3 + "";
            lab_end4.Text = burst4 + "";
        }
    }
}
