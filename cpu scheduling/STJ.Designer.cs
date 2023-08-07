namespace cpu_scheduling
{
    partial class STJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.res_turn = new System.Windows.Forms.Label();
            this.lab_turn = new System.Windows.Forms.Label();
            this.lab_wating = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_GC = new System.Windows.Forms.Button();
            this.lab_pan4 = new System.Windows.Forms.Label();
            this.lab_end4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lab_pan3 = new System.Windows.Forms.Label();
            this.lab_end3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_pan2 = new System.Windows.Forms.Label();
            this.res_wating = new System.Windows.Forms.Label();
            this.lab_end2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_end1 = new System.Windows.Forms.Label();
            this.lb_pan1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_burst4 = new System.Windows.Forms.TextBox();
            this.txt_burst3 = new System.Windows.Forms.TextBox();
            this.txt_burst2 = new System.Windows.Forms.TextBox();
            this.txt_burst1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // res_turn
            // 
            this.res_turn.AutoSize = true;
            this.res_turn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_turn.ForeColor = System.Drawing.Color.Black;
            this.res_turn.Location = new System.Drawing.Point(299, 578);
            this.res_turn.Name = "res_turn";
            this.res_turn.Size = new System.Drawing.Size(23, 24);
            this.res_turn.TabIndex = 55;
            this.res_turn.Text = "0";
            // 
            // lab_turn
            // 
            this.lab_turn.AutoSize = true;
            this.lab_turn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_turn.ForeColor = System.Drawing.Color.Black;
            this.lab_turn.Location = new System.Drawing.Point(30, 578);
            this.lab_turn.Name = "lab_turn";
            this.lab_turn.Size = new System.Drawing.Size(263, 24);
            this.lab_turn.TabIndex = 53;
            this.lab_turn.Text = "AVG Turn Around Time =";
            // 
            // lab_wating
            // 
            this.lab_wating.AutoSize = true;
            this.lab_wating.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_wating.ForeColor = System.Drawing.Color.Black;
            this.lab_wating.Location = new System.Drawing.Point(30, 503);
            this.lab_wating.Name = "lab_wating";
            this.lab_wating.Size = new System.Drawing.Size(209, 24);
            this.lab_wating.TabIndex = 52;
            this.lab_wating.Text = "AVG Wating Time =";
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cal.Location = new System.Drawing.Point(471, 380);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Padding = new System.Windows.Forms.Padding(2);
            this.btn_cal.Size = new System.Drawing.Size(223, 70);
            this.btn_cal.TabIndex = 51;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_GC
            // 
            this.btn_GC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_GC.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GC.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_GC.Location = new System.Drawing.Point(42, 380);
            this.btn_GC.Name = "btn_GC";
            this.btn_GC.Padding = new System.Windows.Forms.Padding(2);
            this.btn_GC.Size = new System.Drawing.Size(223, 70);
            this.btn_GC.TabIndex = 50;
            this.btn_GC.Text = "Draw Gant Chart";
            this.btn_GC.UseVisualStyleBackColor = false;
            this.btn_GC.Click += new System.EventHandler(this.btn_GC_Click);
            // 
            // lab_pan4
            // 
            this.lab_pan4.AutoSize = true;
            this.lab_pan4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pan4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_pan4.Location = new System.Drawing.Point(67, 8);
            this.lab_pan4.Name = "lab_pan4";
            this.lab_pan4.Size = new System.Drawing.Size(30, 34);
            this.lab_pan4.TabIndex = 0;
            this.lab_pan4.Text = "4";
            // 
            // lab_end4
            // 
            this.lab_end4.AutoSize = true;
            this.lab_end4.BackColor = System.Drawing.Color.White;
            this.lab_end4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_end4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_end4.Location = new System.Drawing.Point(709, 319);
            this.lab_end4.Name = "lab_end4";
            this.lab_end4.Size = new System.Drawing.Size(30, 34);
            this.lab_end4.TabIndex = 49;
            this.lab_end4.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.lab_pan4);
            this.panel5.Location = new System.Drawing.Point(551, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 52);
            this.panel5.TabIndex = 48;
            // 
            // lab_pan3
            // 
            this.lab_pan3.AutoSize = true;
            this.lab_pan3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pan3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_pan3.Location = new System.Drawing.Point(67, 8);
            this.lab_pan3.Name = "lab_pan3";
            this.lab_pan3.Size = new System.Drawing.Size(30, 34);
            this.lab_pan3.TabIndex = 0;
            this.lab_pan3.Text = "3";
            // 
            // lab_end3
            // 
            this.lab_end3.AutoSize = true;
            this.lab_end3.BackColor = System.Drawing.Color.White;
            this.lab_end3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_end3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_end3.Location = new System.Drawing.Point(537, 319);
            this.lab_end3.Name = "lab_end3";
            this.lab_end3.Size = new System.Drawing.Size(30, 34);
            this.lab_end3.TabIndex = 47;
            this.lab_end3.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.lab_pan3);
            this.panel4.Location = new System.Drawing.Point(379, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 52);
            this.panel4.TabIndex = 46;
            // 
            // lb_pan2
            // 
            this.lb_pan2.AutoSize = true;
            this.lb_pan2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pan2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_pan2.Location = new System.Drawing.Point(67, 8);
            this.lb_pan2.Name = "lb_pan2";
            this.lb_pan2.Size = new System.Drawing.Size(30, 34);
            this.lb_pan2.TabIndex = 0;
            this.lb_pan2.Text = "2";
            // 
            // res_wating
            // 
            this.res_wating.AutoSize = true;
            this.res_wating.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_wating.ForeColor = System.Drawing.Color.Black;
            this.res_wating.Location = new System.Drawing.Point(245, 503);
            this.res_wating.Name = "res_wating";
            this.res_wating.Size = new System.Drawing.Size(23, 24);
            this.res_wating.TabIndex = 54;
            this.res_wating.Text = "0";
            // 
            // lab_end2
            // 
            this.lab_end2.AutoSize = true;
            this.lab_end2.BackColor = System.Drawing.Color.White;
            this.lab_end2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_end2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_end2.Location = new System.Drawing.Point(364, 319);
            this.lab_end2.Name = "lab_end2";
            this.lab_end2.Size = new System.Drawing.Size(30, 34);
            this.lab_end2.TabIndex = 45;
            this.lab_end2.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lb_pan2);
            this.panel3.Location = new System.Drawing.Point(206, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 52);
            this.panel3.TabIndex = 44;
            // 
            // lab_end1
            // 
            this.lab_end1.AutoSize = true;
            this.lab_end1.BackColor = System.Drawing.Color.White;
            this.lab_end1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_end1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_end1.Location = new System.Drawing.Point(193, 319);
            this.lab_end1.Name = "lab_end1";
            this.lab_end1.Size = new System.Drawing.Size(30, 34);
            this.lab_end1.TabIndex = 43;
            this.lab_end1.Text = "0";
            // 
            // lb_pan1
            // 
            this.lb_pan1.AutoSize = true;
            this.lb_pan1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pan1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_pan1.Location = new System.Drawing.Point(67, 8);
            this.lb_pan1.Name = "lb_pan1";
            this.lb_pan1.Size = new System.Drawing.Size(30, 34);
            this.lb_pan1.TabIndex = 0;
            this.lb_pan1.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(26, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 34);
            this.label5.TabIndex = 31;
            this.label5.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lb_pan1);
            this.panel2.Location = new System.Drawing.Point(34, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 52);
            this.panel2.TabIndex = 42;
            // 
            // txt_burst4
            // 
            this.txt_burst4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_burst4.Location = new System.Drawing.Point(560, 180);
            this.txt_burst4.Name = "txt_burst4";
            this.txt_burst4.Size = new System.Drawing.Size(134, 35);
            this.txt_burst4.TabIndex = 41;
            // 
            // txt_burst3
            // 
            this.txt_burst3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_burst3.Location = new System.Drawing.Point(388, 180);
            this.txt_burst3.Name = "txt_burst3";
            this.txt_burst3.Size = new System.Drawing.Size(134, 35);
            this.txt_burst3.TabIndex = 40;
            // 
            // txt_burst2
            // 
            this.txt_burst2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_burst2.Location = new System.Drawing.Point(209, 180);
            this.txt_burst2.Name = "txt_burst2";
            this.txt_burst2.Size = new System.Drawing.Size(134, 35);
            this.txt_burst2.TabIndex = 39;
            // 
            // txt_burst1
            // 
            this.txt_burst1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_burst1.Location = new System.Drawing.Point(45, 180);
            this.txt_burst1.Name = "txt_burst1";
            this.txt_burst1.Size = new System.Drawing.Size(134, 35);
            this.txt_burst1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Burst Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "STJ";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(12, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Padding = new System.Windows.Forms.Padding(2);
            this.btn_back.Size = new System.Drawing.Size(119, 70);
            this.btn_back.TabIndex = 56;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // STJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 727);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.res_turn);
            this.Controls.Add(this.lab_turn);
            this.Controls.Add(this.lab_wating);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_GC);
            this.Controls.Add(this.lab_end4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lab_end3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.res_wating);
            this.Controls.Add(this.lab_end2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lab_end1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_burst4);
            this.Controls.Add(this.txt_burst3);
            this.Controls.Add(this.txt_burst2);
            this.Controls.Add(this.txt_burst1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "STJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STJ";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label res_turn;
        private System.Windows.Forms.Label lab_turn;
        private System.Windows.Forms.Label lab_wating;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_GC;
        private System.Windows.Forms.Label lab_pan4;
        private System.Windows.Forms.Label lab_end4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lab_pan3;
        private System.Windows.Forms.Label lab_end3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_pan2;
        private System.Windows.Forms.Label res_wating;
        private System.Windows.Forms.Label lab_end2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lab_end1;
        private System.Windows.Forms.Label lb_pan1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_burst4;
        private System.Windows.Forms.TextBox txt_burst3;
        private System.Windows.Forms.TextBox txt_burst2;
        private System.Windows.Forms.TextBox txt_burst1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}