namespace cpu_scheduling
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_fcfs = new System.Windows.Forms.Button();
            this.btn_bio = new System.Windows.Forms.Button();
            this.btn_rr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_stjarrival = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer_slider = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fcfs
            // 
            this.btn_fcfs.BackColor = System.Drawing.Color.Teal;
            this.btn_fcfs.FlatAppearance.BorderSize = 0;
            this.btn_fcfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fcfs.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fcfs.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_fcfs.Location = new System.Drawing.Point(-13, 33);
            this.btn_fcfs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fcfs.Name = "btn_fcfs";
            this.btn_fcfs.Size = new System.Drawing.Size(260, 67);
            this.btn_fcfs.TabIndex = 0;
            this.btn_fcfs.Text = "FCS";
            this.btn_fcfs.UseVisualStyleBackColor = false;
            this.btn_fcfs.Click += new System.EventHandler(this.btn_fcfs_Click);
            // 
            // btn_bio
            // 
            this.btn_bio.BackColor = System.Drawing.Color.Teal;
            this.btn_bio.FlatAppearance.BorderSize = 0;
            this.btn_bio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bio.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bio.Location = new System.Drawing.Point(-24, 430);
            this.btn_bio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bio.Name = "btn_bio";
            this.btn_bio.Size = new System.Drawing.Size(260, 67);
            this.btn_bio.TabIndex = 1;
            this.btn_bio.Text = "piority";
            this.btn_bio.UseVisualStyleBackColor = false;
            this.btn_bio.Click += new System.EventHandler(this.btn_bio_Click);
            // 
            // btn_rr
            // 
            this.btn_rr.BackColor = System.Drawing.Color.Teal;
            this.btn_rr.FlatAppearance.BorderSize = 0;
            this.btn_rr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rr.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rr.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rr.Location = new System.Drawing.Point(-12, 231);
            this.btn_rr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rr.Name = "btn_rr";
            this.btn_rr.Size = new System.Drawing.Size(248, 67);
            this.btn_rr.TabIndex = 2;
            this.btn_rr.Text = "STJ";
            this.btn_rr.UseVisualStyleBackColor = false;
            this.btn_rr.Click += new System.EventHandler(this.btn_rr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(-12, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "FCFS With Arrival ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 134);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPU Scheduling";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_stjarrival
            // 
            this.btn_stjarrival.BackColor = System.Drawing.Color.Teal;
            this.btn_stjarrival.FlatAppearance.BorderSize = 0;
            this.btn_stjarrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stjarrival.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stjarrival.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_stjarrival.Location = new System.Drawing.Point(-12, 337);
            this.btn_stjarrival.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stjarrival.Name = "btn_stjarrival";
            this.btn_stjarrival.Size = new System.Drawing.Size(248, 67);
            this.btn_stjarrival.TabIndex = 5;
            this.btn_stjarrival.Text = "STJ With Arrival ";
            this.btn_stjarrival.UseVisualStyleBackColor = false;
            this.btn_stjarrival.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_fcfs);
            this.panel1.Controls.Add(this.btn_rr);
            this.panel1.Controls.Add(this.btn_stjarrival);
            this.panel1.Controls.Add(this.btn_bio);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 577);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(317, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 2);
            this.panel2.TabIndex = 6;
            // 
            // timer_slider
            // 
            this.timer_slider.Tick += new System.EventHandler(this.timer_slider_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1261, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fcfs;
        private System.Windows.Forms.Button btn_bio;
        private System.Windows.Forms.Button btn_rr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_stjarrival;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer_slider;
    }
}

