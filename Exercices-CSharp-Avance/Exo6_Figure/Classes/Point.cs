using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6_Figure.Classes
{
    internal class Point
    {

        public double PosX { get; set; }

        public double PosY { get; set; }


        public Point(double posX, double posY)
        {
            PosX = posX;
            PosY = posY;         
        }

        public override String ToString()
        {
            return $"{PosX};{PosY}";
        }
    }
}
