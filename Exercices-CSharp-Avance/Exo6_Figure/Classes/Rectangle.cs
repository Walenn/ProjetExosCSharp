using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6_Figure.Interfaces;

namespace Exo6_Figure.Classes;

    internal class Rectangle : Figure, IDeplacable
    {


    public int Longueur { get; set; }
    public int Largeur { get; set; }

    public Point PointA => Origine; 
    
    public Point PointB => new Point(Origine.PosX + Longueur, Origine.PosY); 
    
    public Point PointC => new Point(Origine.PosX, Origine.PosY + Largeur); 
    
    public Point PointD => new Point(Origine.PosX + Longueur, Origine.PosY + Largeur); 
    

    public Rectangle(Point origine, int longueur, int largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
            Origine = origine;
        }
    

    public override string ToString()
    {
        return $"Cordonnées du rectangle ABCD (Longueur = {Longueur}, Largeur= {Largeur}) :"
                + $"\nA= {PointA}"
                + $"\nB= {PointB}"
                + $"\nC={PointC}"
                + $"\nD={PointD}";
    }
}

