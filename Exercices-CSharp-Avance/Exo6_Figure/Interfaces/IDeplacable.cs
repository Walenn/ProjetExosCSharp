using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6_Figure.Interfaces
{
    internal interface IDeplacable
    {


        /// <summary>
        ///  Déplace la figure en (x,y)
        /// </summary>
        /// <param name="x">Cordonnée X de destination</param>
        /// <param name="y">Cordonnée Y de destination</param>
        void Deplacement(double x, double y);
    }
}
