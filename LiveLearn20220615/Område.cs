using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLearn20220615
{
    internal class Område
    {
        public string Navn { get; }
        public int DanskeStemmer { get; set; }

        public int TyskeStemmer { get; set; }

        public Område(string navn)
        {
            Navn = navn;
        }

        public string Resultat()
        {
            if (DanskeStemmer > TyskeStemmer)
            {
                return "dansk";
            } 
            if (TyskeStemmer > DanskeStemmer)
            {
                return "tysk";
            }
            return "stemmelighed";
        }
    }
}
