using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
namespace Indexer
{
    public class MyPoint
    {
        public Dictionary<string, Point> Points;
        private Rectangle Rectangle;
        public MyPoint(Rectangle rectangle)
        {
            this.Rectangle = rectangle;
        }

        public Point this[string key]
        {
            get { return Points[key]; }
            set
            {
                if (!Points.ContainsKey(key))
                {
                    if ((value.X >= Rectangle.X && value.X <= Rectangle.X + Rectangle.Width) && (value.Y >= Rectangle.Y && value.Y <= Rectangle.Y + Rectangle.Height))
                    {
                        Points[key] = value;
                    }
                    else
                    {
                        Console.WriteLine("The points isn't inside the rectangle");
                    }
                }
                else
                {
                    throw new ArgumentException("Point is not within rectangle bounds");
                }
            }
        }
    }
}
