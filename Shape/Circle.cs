﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
   public class Circle:IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;        
        }
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public void Draw()
        {
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;
            for (double y = radius; y >= -radius; --y)
            { 
                for(double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut) Console.Write("*");
                    else Console.Write(" ");

                }
                Console.WriteLine();
            }
        }

    }
}
