using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        private Point TopLeft { get; set; }
        private Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            bool insideByX = point.CoordinateX >= this.TopLeft.CoordinateX 
                && point.CoordinateX <= this.BottomRight.CoordinateX;

            bool insideByY = point.CoordinateY >= this.TopLeft.CoordinateY 
                && point.CoordinateY <= this.BottomRight.CoordinateY;

            return insideByX & insideByY;
        }
    }
}
