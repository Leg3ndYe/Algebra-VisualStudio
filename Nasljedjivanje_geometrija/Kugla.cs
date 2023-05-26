using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrija
{
    class Kugla:Kruznica
    {
        public Kugla() { }
        //public Kugla(double radius)
        //{
        //     Radius = radius;
        //}
        public Kugla (double radius) : base(radius) { }

        new public double Povrsina
        {
            get 
            { /*return 4 * Radius * Radius * 3.14f;*/
                return base.Povrsina * 4; 
            }
        }
        public double Volumen
        {
            get
            {
                return 4 * Math.Pow(Radius, 3) * 3.14f / 3;
            }
        }
    }
}
