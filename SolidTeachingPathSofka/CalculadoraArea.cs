using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public static class CalculadoraArea
    {
        public static double CalcularAreaTotal(Forma[] formas)
        {
            double areaTotal = 0;

            foreach (Forma forma in formas)
            {
                areaTotal += forma.CalcularArea();
            }

            return areaTotal;
        }
    }
}