using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public class Notificador
    {
        private IServicioNotificacion servicioNotificacion;

        public Notificador(IServicioNotificacion servicioNotificacion)
        {
            this.servicioNotificacion = servicioNotificacion;
        }

        public void EnviarNotificacion()
        {
            Console.WriteLine(servicioNotificacion.Enviar("Hola Mundo!"));
        }
    }
}