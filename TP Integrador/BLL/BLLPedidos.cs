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
    public class BLLPedidos
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTablaProductos()
        {
            DataTable dt = dal.TraerTabla("Productos");
            return dt;
        }

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Pedidos");
            return dt;
        }

        public int AgregarPedido(Pedidos pedido)
        {
            //Ejecuta el comando INSERT y devuelve el ID autoincrementable con SELECT SCOPE_IDENTITY();
            int Id = dal.EjecutarComandoYTraerID($"INSERT INTO Pedidos (id_cliente, Fecha, MetodoPago, Total) VALUES ({pedido.id_cliente}, '{pedido.Fecha}', '{pedido.MetodoPago}', {pedido.Total}); SELECT SCOPE_IDENTITY();");
            return Id;
        }

        public void AgregarItem(int idPedido,Item item)
        {
            dal.EjecutarComando($"INSERT INTO Pedido_Producto VALUES ({idPedido}, {item.idProducto}, {item.cantidad})");
        }
    }
}
