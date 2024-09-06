using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sesion
    {
        public static Usuario Usuario;
        public static bool CerrarSesion { get; set; }
        public static string rutaGuardar = @"D:\";
    }
}
