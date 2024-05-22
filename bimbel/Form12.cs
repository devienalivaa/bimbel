using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bimbel
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.ShowDialog();
        }
    }
}
