using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public void Draw()
        {
            DrawLine(width, '*', '*');
            for (int i = 1; i < height - 1; i++)
            {
                DrawLine(width, '*', ' ');
            }
            DrawLine(width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
            Console.WriteLine();
        }

    }
}
