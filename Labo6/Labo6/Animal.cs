using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmitieNamespace;
using ChienNamespace;
using ChatNamespace;

namespace AnimalNamespace
{
    class Animal
    {
        public string nom { get; set; }
        public string MeilleureAmi { get; set; }
        public bool Humeur { get; set; }

        public Animal(string nom)
        {
            this.nom = nom;
            MeilleureAmi = "";
            Humeur = true;

        }

    }

}

