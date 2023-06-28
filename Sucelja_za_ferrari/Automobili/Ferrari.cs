using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari.Automobili
{
    public class Ferrari : IAutomobil
    {
        public Ferrari(string vozac, string model) 
        {
            Model = model;
            Vozac = vozac;
        }
        public string Model { get; private set; }

        public string Vozac { get; private set; }

        public string Gorivo()
        {
            return "Trosi ko nespasen!";
        }

        public string Kocnice()
        {
            return "Dobro koci!";
        }

        public override string ToString()
        {
            return $"Model {Model} vozi ga {Vozac}, no gorivo {Gorivo()}, status kocnica je {Kocnice()}.";
        }
    }
}
