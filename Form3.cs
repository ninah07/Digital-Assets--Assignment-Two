using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Build2
{
    public partial class Form3 : Form
    {
        List<Statement> statements = new List<Statement>();
        Statement SelectedStatement;
        int indexValue;
        int xPos = 0;
        List<string> imageLocation = new List<string>();
        int statementNumber = -1;
        int totalStatements = 0;
        int lineAnimation = 0;
        int greenCorrect = 0;
        int yellowCorrect = 0;
        int totalDragged = 0;

        public Form3()
        {
            InitializeComponent();
            SetUpApp();
        }


        private void SetUpApp()
        {
            imageLocation = Directory.GetFiles("statements", "*.png").ToList();
            totalStatements = imageLocation.Count; 

            for (int i = 0; i < totalStatements; i++)
            {
                MakeStatements();
            }
            
            label1.Text = "Statement " + (statementNumber + 1) + " of " + totalStatements;
        }

        private void MakeStatements()
        {
            statementNumber++;
            xPos += 65;
            Statement newStatement = new Statement(imageLocation[statementNumber]);
            newStatement.position.X = xPos;
            newStatement.position.Y = 240;
            statements.Add(newStatement);  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);

            foreach (Statement newStatement in statements)
            {
                if (SelectedStatement == null)
                {
                    if (newStatement.rect.Contains(mousePosition))
                    {
                        greenBin.Visible = false;
                        yellowBin.Visible = false;
                        SelectedStatement = newStatement;
                        newStatement.active = true;
                        indexValue = statements.IndexOf(newStatement);
                        label1.Text = "Statement " + (indexValue + 1) + " of " + totalStatements;
                    }
                }
            }
        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {

            if (SelectedStatement != null)
            {
                SelectedStatement.position.X = e.X - (SelectedStatement.width / 2);
                SelectedStatement.position.Y = e.Y - (SelectedStatement.height / 2);
            }

        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            foreach (Statement tempStatement in statements)
            {
                tempStatement.active = false;

                if (e.X >= greenBin.Location.X && e.X <= (greenBin.Location.X + greenBin.Width))
                {
                    greenBin.Visible = true;
                    lineAnimation = 0;
                    SelectedStatement.width = SelectedStatement.width / 4;
                    SelectedStatement.height = SelectedStatement.height / 4;
                    totalDragged++;

                    if (indexValue == 1 || indexValue == 2 || indexValue == 4)
                    {
                        greenCorrect++;
                    }

                }
                else
                {
                    greenBin.Visible = false;
                }

                if (e.X >= yellowBin.Location.X && e.X <= (yellowBin.Location.X + yellowBin.Width))
                {
                    yellowBin.Visible = true;
                    lineAnimation = 0;
                    SelectedStatement.width = SelectedStatement.width / 4;
                    SelectedStatement.height = SelectedStatement.height / 4;
                    totalDragged++;

                    if (indexValue == 0 || indexValue == 3 || indexValue == 5)
                    {
                        yellowCorrect++;
                    }

                }
                else
                {
                    yellowBin.Visible = false;
                }



            }
                if (greenCorrect == 18 && yellowCorrect == 18)
                {
                    pnlCongrats.Visible = true;
                }
                else if (totalDragged == 36)
                {
                    pnlTryAgain.Visible = true;
                }

                SelectedStatement = null;

        }   

        private void FormTimerEvent(object sender, EventArgs e)
        {
            foreach (Statement statement in statements)
            {
                statement.rect.X = statement.position.X;
                statement.rect.Y = statement.position.Y; 
            }

            if (SelectedStatement != null)
            {
                if (lineAnimation < 3)
                {
                    lineAnimation++; 
                }
            }
            
            this.Invalidate();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            foreach (Statement statement in statements)
            {
                e.Graphics.DrawImage(statement.statementPic, statement.position.X, statement.position.Y, statement.width, statement.height);

                Pen outline;

                if (statement.active)
                {
                    outline = new Pen(Color.LemonChiffon, lineAnimation);
                }
                else
                {
                    outline = new Pen(Color.Transparent, 1);
                }

                e.Graphics.DrawRectangle(outline, statement.rect); 
            }

            if (SelectedStatement != null)
            {
                e.Graphics.DrawImage(SelectedStatement.statementPic, SelectedStatement.position.X, SelectedStatement.position.Y, SelectedStatement.width, SelectedStatement.height);
            }
        }

        private void FormDragOver(object sender, DragEventArgs e)
        {
             
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnBackGame_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = true;
            pnlCongrats.Visible = false;
            pnlTryAgain.Visible = false; 
        }

        private void btnHelpExit_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = false; 
        }
    }
}
