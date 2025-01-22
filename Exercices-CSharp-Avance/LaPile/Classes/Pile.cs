using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LaPile.Classes
{
    internal class Pile<T>
    {
        private T[] _elements = Array.Empty<T>();


        public void Empiler(T element)
        {
            //Console.WriteLine($"Empilage de {element}, en position {_elements.Count()}.");

            Array.Resize(ref _elements, _elements.Length + 1);

            _elements[^1] = element;
        }



        public T Depiler()
        {
            if (_elements.Any())
            {
                //Console.WriteLine($"Depilage de {_elements[0]}.");
                T retour = _elements[0];


                for (int i = 0; i < _elements.Length - 1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }


                Array.Resize(ref _elements, _elements.Length-1);
                return retour;
            }
            else
            {
                Console.WriteLine("Erreur: Pile déjà vide.");
                return default;
            }
        }



        public T Recuperer(int i)
        {
            if (i < 0 || i >= _elements.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(i), $"L'index {i} est en dehors des limites de la pile.");
            }

            // Récupérer l'élément à l'index donné
            T elementRemoved = _elements[i];

            #region Array.Copy
            // Créer un nouveau _elements de taille réduite
            T[] newArray = new T[_elements.Length - 1];

            // Copier tous les éléments avant l'index i
            Array.Copy(_elements, 0, newArray, 0, i);

            // Copier tous les éléments après l'index i
            Array.Copy(_elements, i + 1, newArray, i, _elements.Length - i - 1);

            // Mettre à jour le _elements privé avec le _elements modifié
            _elements = newArray;
            #endregion


            _elements = _elements[..i].Concat(_elements[(i + 1)..]).ToArray();

            return elementRemoved;
        }

        public override string ToString()
        {
            string retour = "_________________________";
            foreach (T item in _elements)
            {
                retour += "\n" + item;
            }
            return retour;
        }

    }
}

internal class PileL<T>
{
    public List<T> Elements { get; set; } = new List<T>();


    public void Empiler(T element)
    {
        Console.WriteLine($"Empilage de {element}, en position {Elements.Count()}.");

        Elements.Add(element);
    }



    public T Depiler()
    {
        if (Elements.Count > 0)
        {
            Console.WriteLine($"Depilage de {Elements[0]}.");


            T retour = Elements.Last();

            Elements.RemoveAt(Elements.Count());
            return retour;
        }
        else
        {
            Console.WriteLine("Erreur: Pile déjà vide.");
            return default;
        }
    }

    public T Recuperer(int index)
    {
        if (Elements.Count >= index && index >=  0 )
        {
            Console.WriteLine($"\nRécupération de {Elements[index]}, trouvé en indice {index}.");


            T retour = Elements[index];

            Elements.RemoveAt(index);
            return retour;
        }
        else
        {
            Console.WriteLine("Erreur: Pile déjà vide.");
            return default;
        }
    }

    public override string ToString()
    {
        //string retour = "_________________________";
        //Console.WriteLine("\nMa ptite pile: ");
        //foreach (T item in Elements)
        //{
        //    retour += "\n" + item;
        //}
        //retour += "\n_________________________";
        //return retour;

        return "Pile: " + string.Join(", ", Elements);
    }
}
