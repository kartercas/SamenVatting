using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    class ClassBasic
    {
        //de woorden declareren
        public string voorNaam, naam;

        //de constructor
        //Hier word opgevraagt welk declaraties ge nodig hebt
        //Dus  we voornaam & naam kunnen in geven op game1
        public ClassBasic(string voornaam, string naam)
        {
            voorNaam = voornaam;
            //de this word gebruikt om het duidelijk te maken dat het deze is
            this.naam = naam;
        }

        //member method
        public void Ik()
        {
            Console.WriteLine("Hoi, ik ben " + voorNaam + naam);
            Console.ReadLine();
        }
    }
}
