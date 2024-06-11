using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTeachingPathSofka
{
    public class Radio : IAjustable, IEncendible
    {
        public int Volumen { get; private set; }
        public bool EstaEncendido { get; private set; }

        public void AjustarVolumen(int ajuste)
        {
            Volumen += ajuste < 0 ? 0 : Volumen += ajuste;
        }

        public void Apagar()
        {
            EstaEncendido = false;
        }

        public void Encender()
        {
            EstaEncendido = true;
        }
    }
}