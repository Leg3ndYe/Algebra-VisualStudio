using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrija
{
    class Kruznica
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0) _radius = 0;
                else _radius = value;
            }
        }
        public double Promjer
        {
            get { return _radius * 2; }
        }

        public double Opseg
        {
            get { return Promjer * 3.14f; }
        }

        public double Povrsina
        {
            get { return Math.Pow(_radius, 2) * 3.14f; }
        }
        public Kruznica() { }

        public Kruznica(double radius)
        {
            this.Radius = radius;
        }
    }
}
