using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Kunde
    {
        //instans
        private string _navn;
        private string _tlf;

        //properties

        public string Navn

        {
            get { return _navn; }
        
            set { _navn = value; } 
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        //Constuctor

        public Kunde(string navn, string tlf)
        {
            _navn = navn;
            _tlf = tlf;
        }

        //ToString

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
