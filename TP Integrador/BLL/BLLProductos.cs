using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProductos
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Productos");
            return dt;
        }

        public void AltaProducto(Producto prod)
        {
            SqlParameter[] parametros = new SqlParameter[]
           {
                new SqlParameter("@Precio", prod.Precio),
                new SqlParameter("@Descripcion", prod.Descripcion)
           };

            dal.EjecutarProcAlmacenado("AltaProducto", parametros);
        }

        public void BajaProducto(int idProd)
        {
            dal.EjecutarComando($"DELETE FROM Productos where id_producto = {idProd}");
        }
    }
}
