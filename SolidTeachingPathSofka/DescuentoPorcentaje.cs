using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public class DescuentoPorcentaje : IDescuento
    {
        public readonly double Porcentaje;

        public DescuentoPorcentaje(double porcentaje)
        {
            Porcentaje = porcentaje;
        }

        public double AplicarDescuento(double precio)
        {
            return precio * (1 - Porcentaje / 100);
        }
    }
}