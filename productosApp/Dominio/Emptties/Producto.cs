using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Emptties
{
    public class Producto

    {
        public int ID {get; set;}
        public string Nombre { get; set; }
           public string  Descripcion { get; set; }
         public int Existencias { get; set; }
         public decimal Precio { get; set; }
         public DateTime  Caducidad { get; set; }
        public UnidadDeMedid Unidaddemedidas { get; set; }
         

       
    }
}
