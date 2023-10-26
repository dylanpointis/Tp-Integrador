using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUsuarios
    {
        DalConexion dal = new DalConexion();

        public (bool, string) VerificarUsuario(string nombreUsuario, string clave)
        {
            DataTable tabla = dal.TraerTabla("Usuarios");

            DataRow row = tabla.Rows.Find(nombreUsuario);

            if(row == null)
            {
                //no existe usuario
                return (false,null);
            }
            else
            {
                bool esClaveCorrecta = row[1].ToString() == clave;
                string rol = row[2].ToString();
                return (esClaveCorrecta, rol);
            }
        }



    }
}
