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
    public partial class Form4 : Form
    {
        PictureBox[] pictures = new PictureBox[3];
        List<String> blocks = new List<string>();
        int correctPoints; 

        public Form4()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].SizeMode = PictureBoxSizeMode.Zoom;
                pictures[i].AllowDrop = true;
                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);
                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);

                tblCodeArea.Controls.Add(pictures[i]);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox codeBlock = sender as PictureBox;
            DataObject dragImage = new DataObject();

            dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);
            dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);
            DoDragDrop(dragImage, DragDropEffects.Copy);
        }

        private void pictures_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictures_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            picture.Tag = e.Data.GetData(DataFormats.Text);

            lblList.Text = "";
            blocks.Clear();


            for (int i = 0; i < 3; i++)
            {
                blocks.Add(String.Format("{0}", pictures[i].Tag));

                // This logic runs when the amount of blocks filled are three 
                if (blocks.Count == 3)
                {
                    // This is declaring the blocks as strings
                    string block1 = blocks[0];
                    string block2 = blocks[1];
                    string block3 = blocks[2];


                    if (block1 != "" && block2 != "" && block3 != "")
                    {
                        // If the fruit is not in its allocated block, a try again message will print, otherwise
                        // print well done.
                        if (block1 != "Apple" || block2 != "Orange" || block3 != "Pear")
                        {
                            lblList.Text += "Try Again";
                        }
                        else
                        {
                            lblList.Text += "Well Done!";
                            pnlRepeat.Visible = true;
                        }
                    }
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void tblCodeArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnApple3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnApple3.Checked)
            {
                label1.Text = "Great!";
                correctPoints++;
            }
            else
            { 
                label1.Text = "Try Again"; 
            }
        }

        private void btnOrange4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnOrange3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOrange3.Checked)
            {
                label2.Text = "Amazing!";
                correctPoints++;
            }
            else
            {
                label2.Text = "Try Again";
            }
        }

        private void btnPear2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPear2.Checked)
            {
                label3.Text = "Epic!";
                correctPoints++;
            }
            else
            {
                label3.Text = "Try Again";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (correctPoints >= 3)
            {
                pnlEnd.Visible = true;
                pnlRepeat.Visible = false; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnHelpExit_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = false; 
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = true;
            pnlEnd.Visible = false; 
        }
    }
}
