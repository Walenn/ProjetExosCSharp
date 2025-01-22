using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6_Figure.Interfaces;

namespace Exo6_Figure.Classes;

internal class Triangle : Figure, IDeplacable
{
    private int _base;

    public int Base
    {
        get { return _base; }
        set { _base = value; }
    }

    private int _hauteur;

    public int Hauteur
    {
        get { return _hauteur; }
        set { _hauteur = value; }
    }

    public Point PointA
    {
        get { return Origine; }
    }
    public Point PointB
    {
        get { return new Point(Origine.PosX - Base / 2 , Origine.PosY - Hauteur); }
    }
    public Point PointC
    {
        get { return new Point(Origine.PosX + Base / 2, Origine.PosY - Hauteur); }
    }


    public Triangle(Point origine, int baseTr, int hauteur)
    {
        Base = baseTr;
        Hauteur = hauteur;
        Origine = origine;
    }

    public override string ToString()
    {
        return $"Cordonnées du Triangle ABC (Base = {Base}, Hauteur= {Hauteur}) :"
            + $"\nA= {PointA}"
            + $"\nB= {PointB}"
            + $"\nC= {PointC}";
    }
}
