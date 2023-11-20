using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Ordre
    {
        //Leveringsgebyr - konstant
        private const double _levering = 40.0;

        //Instansfelter

        private Pizza _pizza;
        private Kunde _kunde;

        public bool ØnskerLevering { get; set; } = false;

        //Poperties

        public Pizza pizza 
        { 
            get { return _pizza; }
            set { _pizza = value; }
        }
        public Kunde Kunde 
        { 
            get { return _kunde; } 
            set { _kunde = value; } 
        }

        //Konstuktør

        public Ordre()
        {
            _pizza = null;
            _kunde = null;
        }

        public Ordre(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }

        //Metoder

        public void TilføjLevering()
        { 
            ØnskerLevering = true;
        }

        public double CalculateTotalPrice()
        {
            double PrisMedMoms = pizza.Pris * 1.25;
            if(ØnskerLevering)
            {
                PrisMedMoms += _levering;
                   
            }
            return PrisMedMoms;
        }

        //Tostring


        public override string ToString()
        {
            return $"{{{nameof(pizza)}={pizza}, {nameof(Kunde)}={Kunde}}}";
        }
    }
}
