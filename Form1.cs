using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.StartPosition = FormStartPosition.Manual;
            f5.Location = this.Location;
            f5.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.StartPosition = FormStartPosition.Manual;
            f6.Location = this.Location;
            f6.Show();
            this.Hide();
        }
    }
}
