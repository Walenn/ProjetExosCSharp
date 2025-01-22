using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6_Figure.Interfaces;

namespace Exo6_Figure.Classes
{
    internal  class Figure : IDeplacable
    {
        private Point _origine;

        public Point Origine
        {
            get { return _origine; }
            set { _origine = value; }
        }

        public void Deplacement(double x, double y)
        {
            this.Origine = new Point(x, y);
        }

        public override string ToString()
        {
            return $"Quelle belle figure de coordonnées d'origine [{this.Origine}]";
        }


    }
}
