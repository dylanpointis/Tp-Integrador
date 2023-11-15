using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLLEnvios
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Envios");
            return dt;
        }

        public DataTable traerTablaSegunCliente(int id)
        {
            DataTable dataTable = dal.traerTablaQuery($"SELECT * FROM Envios WHERE id_pedido IN (SELECT id_pedido FROM Pedidos WHERE id_cliente = {id})");
            return dataTable;
        }


        public void AgregarEnvio(Envios envio) //ID EMPLEADO NULL PORQUE TODAVIA NO FUE PROGRAMADO POR UN EMPLEADO
        {
            dal.EjecutarComando($"INSERT INTO Envios VALUES ({envio.id_pedido}, null, '{envio.estado}','{envio.fecha}','{envio.direccion}','{envio.localidad}','{envio.opcionEnvio}')");
        }
    }
}
