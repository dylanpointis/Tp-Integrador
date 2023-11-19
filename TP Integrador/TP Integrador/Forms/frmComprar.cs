using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Microsoft.VisualBasic;

namespace TP_Integrador
{
    public partial class frmComprar : Form
    {
        Usuario usuarioRecibido;

        public frmComprar(Usuario user)
        {
            usuarioRecibido = user;
            InitializeComponent();
        }

        private BLLPedidos bllPedidos = new BLLPedidos();
        private BLLProductos bllProductos = new BLLProductos();
        private List<Item> listaCarrito = new List<Item>();

        private void frmComprar_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(grillaProductos.CurrentRow.Cells[0].Value);
                decimal precio = Convert.ToDecimal(grillaProductos.CurrentRow.Cells[1].Value);
                int cantStock = Convert.ToInt32(grillaProductos.CurrentRow.Cells[2].Value);

                int cantComprada = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad a comprar"));

                if (cantComprada <= cantStock)
                {
                    Item item = new Item(idProducto, cantComprada);
                    item.precio = precio;

                    listaCarrito.Add(item);

                    lblTotal.Text = ObtenerTotal().ToString(); 
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada supera al STOCK disponible");
                }
            }
            catch { MessageBox.Show("Asegurese de seleccionar los productos deseados en la grilla Productos"); }
            
        }

        private decimal ObtenerTotal()
        {
            decimal total = 0;
            foreach (Item item in listaCarrito)
            {
                total += item.total;
            }
            return total;
        }

        //NO SIRVEEEEEEEEEEEEEEEE
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(grillaCarrito.CurrentRow.Cells[0].Value);
                Item carritoAEliminar = listaCarrito.FirstOrDefault(c => c.idProducto == idProducto);

                if (carritoAEliminar != null)
                {
                    listaCarrito.Remove(carritoAEliminar);
                }
                ActualizarGrilla();
            }
            catch(Exception ex) { }
        }


        private void ActualizarGrilla()
        {
            grillaProductos.DataSource = null;
            grillaProductos.DataSource = bllProductos.traerTabla();

            grillaCarrito.DataSource = null;
            grillaCarrito.DataSource = listaCarrito;
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (listaCarrito.Count > 0)
            {
                if(cmbMetodoPago.Text != "")
                {
                    Pedidos pedido = new Pedidos(usuarioRecibido.IDUser, DateTime.Now.ToString("dd-MM-yyyy HH:mm"), cmbMetodoPago.Text, ObtenerTotal());
                    if (cmbMetodoPago.Text == "Transferencia")
                    {
                        frmPagarTransferencia frm = new frmPagarTransferencia(pedido);
                        frm.Show();
                    }
                    if(cmbMetodoPago.Text == "Tarjeta")
                    {
                        frmPagarTarjeta frm = new frmPagarTarjeta(pedido, listaCarrito);
                        frm.Show();
                    }

                    listaCarrito.Clear();//Limpia la lista una vez realizada la compra
                    ActualizarGrilla();
                }
                else { MessageBox.Show("Seleccione un método de pago"); }

            }
            else { MessageBox.Show("Agregue productos al carrito para comprar"); }
        }


        /*
         Pedidos pedido = new Pedidos(usuarioRecibido.IDUser, DateTime.Now.ToString("yyyy-dd-mm HH:mm"), cmbMetodoPago.Text, ObtenerTotal());

                    //Inserta un nuevo pedido y guarda el ID de la primary key auto incrementable
                    int idPedido = bll.AgregarPedido(pedido);

                    foreach (Item item in listaCarrito)
                    {
                        bll.AgregarItem(idPedido, item);
                    }

                    listaCarrito.Clear(); //Limpia la lista una vez realizada la compra
                    ActualizarGrilla();

                    MessageBox.Show("Compra exitosa");
         **/
    }
}
