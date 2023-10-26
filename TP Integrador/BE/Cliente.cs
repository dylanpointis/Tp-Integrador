using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente: Usuario
    {


            
        public int id_Cliente { get; set; } 

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Cliente(int id_cliente, string nombre, string apellido, string NombreUsuario, string Clave): base(NombreUsuario, Clave)
        {
            id_Cliente= id_cliente;
            Nombre= nombre;
            Apellido= apellido;
        }
    }
}
