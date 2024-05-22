namespace bimbel
{
    partial class Form7
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
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(503, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(466, 93);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 6;
            label2.Text = "Cari";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 77);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 1;
            label1.Text = "DATA SISWA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(30, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(609, 150);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "NIS";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Alamat";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tanggal Lahir";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Jenis Kelmain";
            Column5.Name = "Column5";
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(30, 299);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 9;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hirasawa_Yui_Header;
            pictureBox1.Location = new Point(30, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 305);
            label3.Name = "label3";
            label3.Size = new Size(28, 17);
            label3.TabIndex = 11;
            label3.Text = "NIS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(308, 427);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 12;
            label4.Text = "Jenis Kelmain";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(308, 396);
            label5.Name = "label5";
            label5.Size = new Size(86, 17);
            label5.TabIndex = 13;
            label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(308, 365);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 14;
            label6.Text = "Alamat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(308, 335);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 15;
            label7.Text = "Nama";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(412, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(412, 334);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(412, 364);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 23);
            textBox5.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(412, 426);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(412, 393);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(136, 465);
            button4.Name = "button4";
            button4.Size = new Size(85, 29);
            button4.TabIndex = 25;
            button4.Text = "Ubah";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(237, 465);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 24;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(343, 465);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 23;
            button2.Text = "Tambah";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Tan;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(34, 465);
            button5.Name = "button5";
            button5.Size = new Size(85, 29);
            button5.TabIndex = 22;
            button5.Text = "Simpan";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(675, 506);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "Data Siswa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
    }
}