using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public Trabajador Trabajador { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public bool Vigente { get; set; }

        public string NombreTrabajador
        {
            get
            {
                return Trabajador.NombreCompleto;
            }
        }
    }

}
