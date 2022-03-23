namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hoursMinus = new System.Windows.Forms.Button();
            this.hourPlus = new System.Windows.Forms.Button();
            this.minutesMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.minutesPlus = new System.Windows.Forms.Button();
            this.secondPlus = new System.Windows.Forms.Button();
            this.secondMinus = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the time at the timer until your computer will shut down:";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.BackColor = System.Drawing.Color.Black;
            this.Hours.Font = new System.Drawing.Font("Simplified Arabic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Hours.Location = new System.Drawing.Point(100, 29);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(58, 55);
            this.Hours.TabIndex = 1;
            this.Hours.Text = "00";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.BackColor = System.Drawing.Color.Black;
            this.Minutes.Font = new System.Drawing.Font("Simplified Arabic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minutes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Minutes.Location = new System.Drawing.Point(288, 29);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(58, 55);
            this.Minutes.TabIndex = 1;
            this.Minutes.Text = "00";
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.BackColor = System.Drawing.Color.Black;
            this.Seconds.Font = new System.Drawing.Font("Simplified Arabic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seconds.ForeColor = System.Drawing.Color.White;
            this.Seconds.Location = new System.Drawing.Point(474, 29);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(58, 55);
            this.Seconds.TabIndex = 2;
            this.Seconds.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(100, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(288, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(474, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seconds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(208, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 46);
            this.label8.TabIndex = 7;
            this.label8.Text = " :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(383, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 46);
            this.label7.TabIndex = 8;
            this.label7.Text = " :";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(554, 29);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(94, 29);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(901, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // hoursMinus
            // 
            this.hoursMinus.BackColor = System.Drawing.Color.Black;
            this.hoursMinus.ForeColor = System.Drawing.Color.White;
            this.hoursMinus.Location = new System.Drawing.Point(134, 108);
            this.hoursMinus.Name = "hoursMinus";
            this.hoursMinus.Size = new System.Drawing.Size(30, 30);
            this.hoursMinus.TabIndex = 11;
            this.hoursMinus.Text = "-";
            this.hoursMinus.UseVisualStyleBackColor = false;
            this.hoursMinus.Click += new System.EventHandler(this.hoursMinus_Click);
            // 
            // hourPlus
            // 
            this.hourPlus.BackColor = System.Drawing.Color.Black;
            this.hourPlus.ForeColor = System.Drawing.Color.White;
            this.hourPlus.Location = new System.Drawing.Point(100, 108);
            this.hourPlus.Name = "hourPlus";
            this.hourPlus.Size = new System.Drawing.Size(30, 30);
            this.hourPlus.TabIndex = 12;
            this.hourPlus.Text = "+";
            this.hourPlus.UseVisualStyleBackColor = false;
            this.hourPlus.Click += new System.EventHandler(this.hourPlus_Click);
            // 
            // minutesMinus
            // 
            this.minutesMinus.BackColor = System.Drawing.Color.Black;
            this.minutesMinus.ForeColor = System.Drawing.Color.White;
            this.minutesMinus.Location = new System.Drawing.Point(325, 108);
            this.minutesMinus.Name = "minutesMinus";
            this.minutesMinus.Size = new System.Drawing.Size(30, 30);
            this.minutesMinus.TabIndex = 13;
            this.minutesMinus.Text = "-";
            this.minutesMinus.UseVisualStyleBackColor = false;
            this.minutesMinus.Click += new System.EventHandler(this.minutesMinus_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(288, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 29);
            this.button6.TabIndex = 14;
            this.button6.Text = "Start";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // minutesPlus
            // 
            this.minutesPlus.BackColor = System.Drawing.Color.Black;
            this.minutesPlus.ForeColor = System.Drawing.Color.White;
            this.minutesPlus.Location = new System.Drawing.Point(288, 108);
            this.minutesPlus.Name = "minutesPlus";
            this.minutesPlus.Size = new System.Drawing.Size(30, 30);
            this.minutesPlus.TabIndex = 14;
            this.minutesPlus.Text = "+";
            this.minutesPlus.UseVisualStyleBackColor = false;
            this.minutesPlus.Click += new System.EventHandler(this.minutesPlus_Click);
            // 
            // secondPlus
            // 
            this.secondPlus.BackColor = System.Drawing.Color.Black;
            this.secondPlus.ForeColor = System.Drawing.Color.White;
            this.secondPlus.Location = new System.Drawing.Point(474, 108);
            this.secondPlus.Name = "secondPlus";
            this.secondPlus.Size = new System.Drawing.Size(30, 30);
            this.secondPlus.TabIndex = 15;
            this.secondPlus.Text = "+";
            this.secondPlus.UseVisualStyleBackColor = false;
            this.secondPlus.Click += new System.EventHandler(this.secondPlus_Click);
            // 
            // secondMinus
            // 
            this.secondMinus.BackColor = System.Drawing.Color.Black;
            this.secondMinus.ForeColor = System.Drawing.Color.White;
            this.secondMinus.Location = new System.Drawing.Point(508, 108);
            this.secondMinus.Name = "secondMinus";
            this.secondMinus.Size = new System.Drawing.Size(30, 30);
            this.secondMinus.TabIndex = 16;
            this.secondMinus.Text = "-";
            this.secondMinus.UseVisualStyleBackColor = false;
            this.secondMinus.Click += new System.EventHandler(this.secondMinus_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp4.Properties.Resources._1618595899_45_funart_pro_p_oboi_fon_krutoi_chernii_fon_46__1_;
            this.ClientSize = new System.Drawing.Size(675, 224);
            this.Controls.Add(this.secondMinus);
            this.Controls.Add(this.secondPlus);
            this.Controls.Add(this.minutesPlus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.minutesMinus);
            this.Controls.Add(this.hourPlus);
            this.Controls.Add(this.hoursMinus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Hours;
        private Label Minutes;
        private Label Seconds;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Button Start;
        private Button button2;
        private Button hoursMinus;
        private Button hourPlus;
        private Button minutesMinus;
        private Button button6;
        private Button minutesPlus;
        private Button secondPlus;
        private Button secondMinus;
        private System.Windows.Forms.Timer timer1;
    }
}