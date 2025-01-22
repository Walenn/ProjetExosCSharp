using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6_Figure.Classes;

namespace Exo6_Figure.Interfaces
{
    internal static class IHM
    {


        private static List<Figure> _figures = new List<Figure>()
         {
             new Carre(new Point(2,4), 2),
             new Rectangle(new Point(1,2), 10, 2),
             new Triangle(new Point(1,3), 6, 14)
         };

        public static void Start()
        {

            //   Pas vraiment une IHM interractive au final...

            foreach (Figure figure in _figures)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("Déplacement du carré en (1,3):");
            _figures.ElementAt<Figure>(0).Deplacement(1, 3);

            Console.WriteLine(_figures.ElementAt<Figure>(0));

        }
    }
}
