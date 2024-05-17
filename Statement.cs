using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build2
{
    internal class Statement
    {

        public Image statementPic; //assign variables of image to statementPic
        public int width;
        public int height;
        public Point position = new Point();
        public bool active = false;
        public Rectangle rect; 

        public Statement(string imageLocation) // string loads images in when class is created
        {
            statementPic = Image.FromFile(imageLocation);
            width = 100;
            height = 35;
            rect = new Rectangle(position.X, position.Y, width, height);
        }
    }
}
