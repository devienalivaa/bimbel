namespace bimbel
{
    partial class Form16
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
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column1 });
            dataGridView1.Location = new Point(28, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 150);
            dataGridView1.TabIndex = 37;
            // 
            // Column2
            // 
            Column2.HeaderText = "No";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tanggal";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Hari";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Guru";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Kelas";
            Column6.Name = "Column6";
            // 
            // Column1
            // 
            Column1.HeaderText = "Mata Pelajaran";
            Column1.Name = "Column1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(515, 97);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 35;
            label2.Text = "Cari";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 77);
            panel1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(213, 30);
            label1.TabIndex = 1;
            label1.Text = "JADWAL PELAJARAN";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(552, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 38;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 310);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form16";
            Text = "Jadwal Siswa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}