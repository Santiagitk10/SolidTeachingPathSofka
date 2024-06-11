using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public class DescuentoMontoFijo : IDescuento
    {
        private readonly double MontoFijo;

        public DescuentoMontoFijo(double montoFijo)
        {
            this.MontoFijo = montoFijo;
        }

        public double AplicarDescuento(double precio)
        {
            return precio - MontoFijo;
        }
    }
}