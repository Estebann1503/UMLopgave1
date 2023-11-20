using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        //Instansfelter
        private int _nr;
        private string _navn;
        private string _ingredienser;
        private double _pris;

        //properties

        public int Nr
        {
            get { return _nr; }
            set { _nr = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Ingredienser
        {
            get { return _ingredienser; }
            set { _ingredienser = value; }
        }

        public double Pris
        { 
            get { return _pris; }
            set { _pris = value; }
        }

        //Kontruktør

        public Pizza()
        {
            _nr = 0;
            _navn = "";
            _ingredienser = "";
            _pris = 0;
        }

        public Pizza(int nr, string navn, string ingredienser, double pris)
        {
            Nr = nr;
            Navn = navn;
            Ingredienser = ingredienser;
            Pris = pris;
        }

        //Tostring

        public override string ToString()
        {
            return $"{{{nameof(Nr)}={Nr.ToString()}, {nameof(Navn)}={Navn}, {nameof(Ingredienser)}={Ingredienser}, {nameof(Pris)}={Pris.ToString()}}}";
        }
  
    }
}
