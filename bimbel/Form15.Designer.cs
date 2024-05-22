namespace bimbel
{
    partial class Form15
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
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column1 });
            dataGridView1.Location = new Point(28, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 150);
            dataGridView1.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(631, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 94);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 31;
            label2.Text = "Cari";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 77);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(211, 30);
            label1.TabIndex = 1;
            label1.Text = "HISTORI ANGSURAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(423, 21);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 2;
            label3.Text = "Sisa Cicilan";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(552, 20);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 34);
            textBox2.TabIndex = 3;
            textBox2.Text = "Rp";
            // 
            // Column2
            // 
            Column2.HeaderText = "No";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cicilan ke";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Besar Cicilan";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Sisa Cicilan";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Sisa Banyaknya cicilan";
            Column6.Name = "Column6";
            // 
            // Column1
            // 
            Column1.HeaderText = "Lunas?";
            Column1.Name = "Column1";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 311);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form15";
            Text = "Angsuran Ssiwa";
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
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
    }
}