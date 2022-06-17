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

        public Område(string navn) //constructor, Området skal indeholde et navn
        {
            Navn = navn;
        }

        public string Resultat() //metoden til at sammenligne danske stemmer vs tyske stemmer
        {
            if (DanskeStemmer > TyskeStemmer)
            {
                return "danske";
            } 
            else if (TyskeStemmer > DanskeStemmer)
            {
                return "tyske";
            }
            return "stemmelighed";
        }

    }
}
