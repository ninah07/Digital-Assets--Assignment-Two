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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close(); 
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.StartPosition = FormStartPosition.Manual;
            f4.Location = this.Location;
            f4.Show();
            this.Hide();
        }
    }
}
