using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Empresa
  {

    public int Codigo { get; set; }
    public string RazonSocial { get; set; }
    public string RUC { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Dirección { get; set; }
    public bool Vigente { get; set; }


  }
}
