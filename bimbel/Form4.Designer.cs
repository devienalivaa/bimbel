namespace bimbel
{
    partial class Form4
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 33);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 0;
            label1.Text = "MASTER DATA";
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(52, 124);
            button1.Name = "button1";
            button1.Size = new Size(215, 35);
            button1.TabIndex = 1;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(52, 188);
            button2.Name = "button2";
            button2.Size = new Size(215, 35);
            button2.TabIndex = 2;
            button2.Text = "Guru";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(52, 252);
            button3.Name = "button3";
            button3.Size = new Size(215, 35);
            button3.TabIndex = 3;
            button3.Text = "Siswa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(52, 314);
            button4.Name = "button4";
            button4.Size = new Size(215, 35);
            button4.TabIndex = 4;
            button4.Text = "Kelas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Tan;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(52, 375);
            button5.Name = "button5";
            button5.Size = new Size(215, 35);
            button5.TabIndex = 5;
            button5.Text = "Paket Bimbel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(325, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Master Data";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}