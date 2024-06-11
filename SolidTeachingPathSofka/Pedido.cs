using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public static class Pedido
    {
        public static void GenerarFactura(double precio, IDescuento descuento)
        {
            Console.WriteLine($"TOTAL A PAGAR: {descuento.AplicarDescuento(precio)}");
        }
    }
}