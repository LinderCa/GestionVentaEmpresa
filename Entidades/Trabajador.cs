using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trabajador
    {
        public int Codigo { get; set; }
        public Empresa Empresa { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public double Sueldo { get; set; }

        public string NombreCompleto
        {
            get
            {
                return this.ApellidoPaterno + " " + this.ApellidoMaterno + " " + this.Nombres;
            }
        }

        public string NombreEmpresa
        {
            get
            {
                var emp = "";

                if (this.Empresa != null)
                {
                    emp = this.Empresa.RazonSocial;
                }

                return emp;
            }
        }

    }

}
