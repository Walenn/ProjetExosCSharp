using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6_Figure.Interfaces;

namespace Exo6_Figure.Classes
{
    internal class Carre : Figure, IDeplacable
    {
        public int Cote { get; set; }

        
        public Point PointA
        {
            get { return Origine; }
        }
        public Point PointB => new Point(Origine.PosX + Cote , Origine.PosY); 
        public Point PointC => new Point(Origine.PosX , Origine.PosY + Cote); 
        public Point PointD =>  new Point(Origine.PosX + Cote , Origine.PosY + Cote); 
        

        
        public Carre(Point origine, int cote)
        {
            Cote = cote;
            Origine = origine;
        }

        public override string ToString()
        {
            return $"Cordonnées du carré ABCD (Côté = {Cote}) :"
                +$"\nA= {PointA}"
                +$"\nB= {PointB}"
                +$"\nC={PointC}"
                +$"\nD={PointD}";
        }
    }
}
