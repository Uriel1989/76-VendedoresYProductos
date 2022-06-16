using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendedoresYProductos
{
    class Vendedor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public List<Meses> Mes { get; set; }

        public Vendedor()
        {
            this.Mes = new List<Meses>();
        }


    }
}
