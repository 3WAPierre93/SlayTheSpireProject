using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpireProject
{
    sealed class Joueur
    {
        string name;
        int PdV;
        int Energie;
        int PointsArmure;


        public Carte[] main;

        //Constructeur

        public Joueur()
        {
            Console.WriteLine("Entre ton nom de ???");
            name = Console.ReadLine();
        }
    }
}



