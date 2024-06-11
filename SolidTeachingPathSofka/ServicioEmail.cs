using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public class ServicioEmail : IServicioNotificacion
    {
        public string Enviar(string mensaje)
        {
            return $"Correo Electrónico: {mensaje}";
        }
    }
}