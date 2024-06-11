using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public class Rectangulo : Forma
    {
        private readonly double ancho;
        private readonly double alto;

        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override double CalcularArea()
        {
            return ancho * alto;
        }
    }
}