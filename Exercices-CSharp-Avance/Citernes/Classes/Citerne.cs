using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citernes.Classes; 

internal class Citerne
{
    private int _poidsVide;
    public int PoidsVide { get => _poidsVide; private set => _poidsVide = value; }

    public int _capaciteTotale { get; set; }
    public int CapaciteTotale { get => _capaciteTotale; private set => _capaciteTotale = value; }

    private int _niveauRemplissage;
    public int NiveauRemplissage
        {
        get => _niveauRemplissage;
        set
        { 
            // on soustrait l'ancien salaire du salarié au total
            VolumeTotal -= _niveauRemplissage ;
        // on change le salaire du salarié
            _niveauRemplissage = value;
        // on réaugmente le total des salaires par la nouvelle valeur
            VolumeTotal += _niveauRemplissage ;
        }
    }

    public int TotalWeight => PoidsVide + NiveauRemplissage;

    public static int VolumeTotal { get; private set; } = 0;


    public Citerne(int niveauRemplissage, int poidsVide, int capaciteTotale)
    {
        PoidsVide = poidsVide;
        CapaciteTotale = capaciteTotale;
        NiveauRemplissage = niveauRemplissage;
    }


    public int remplir (int quantiteEau)
    {
        if (quantiteEau + NiveauRemplissage > _capaciteTotale)
        {
            int quantiteAjoutee = quantiteEau + NiveauRemplissage - _capaciteTotale;
            NiveauRemplissage = _capaciteTotale;
            return quantiteAjoutee;
        }
        else
        {
            NiveauRemplissage += quantiteEau;
            return 0;
        }
    }



    public int vider(int quantiteEau)
    {
        if (quantiteEau > NiveauRemplissage)
        {
            int quantiteDispo = NiveauRemplissage;
            NiveauRemplissage = 0;
            return quantiteDispo;
        }
        else
        {
            NiveauRemplissage -= quantiteEau;
            return 0;
        }
    }
}
