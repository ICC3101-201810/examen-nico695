using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmen
{
    [Serializable()]
    public class Usuario
    {
        private string nombre;
        private int ptje;

        public Usuario(int ptje,string nombre)
        {
            this.Nombre = nombre;
            this.Ptje = ptje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Ptje { get => ptje; set => ptje = value; }
    }
}
