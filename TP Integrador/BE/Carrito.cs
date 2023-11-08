using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Carrito
    {
        public int idProducto { get; set; }
        public int cantidad { get; set; }

        public decimal precio { get; set; }

        public decimal total
        {
            get { return precio * cantidad; }
        }

        public Carrito(int idProducto, int cantidad)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
}
