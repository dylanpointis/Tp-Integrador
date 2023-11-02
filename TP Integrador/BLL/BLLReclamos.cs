using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using BE;
namespace BLL
{
    public class BLLReclamos
    {

        DalConexion dal = new DalConexion();

        public DataTable TraerTabla()
        {
            DataTable tabla = dal.TraerTabla("Reclamos");
            return tabla;

        }
        public void AgregarReclamos(int id, Reclamos REC)
        {
            dal.EjecutarComando($"INSERT INTO Reclamos VALUES ({id},'{REC.Categoria}','{REC.Descripcion}')");
        }

        public void EliminarReclamo(int id)
        {
            dal.EjecutarComando($"DELETE FROM Reclamos WHERE id_reclamo = {id}");
        }
    }
}
