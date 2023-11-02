using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

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
    }
}
