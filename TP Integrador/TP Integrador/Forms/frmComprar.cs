﻿using System;
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
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();

        public frmComprar()
        {
            InitializeComponent();
        }

        private BLLPedidos bllPedidos = new BLLPedidos();
        private BLLProductos bllProductos = new BLLProductos();
        private BLLDescuentos bllDescuentos = new BLLDescuentos();
        private List<Item> listaCarrito = new List<Item>();

        private void frmComprar_Load(object sender, EventArgs e)
        {
            grillaCarrito.ColumnCount = 4;
            grillaCarrito.Columns[0].Name = "id producto";
            grillaCarrito.Columns[1].Name = "Cantidad";
            grillaCarrito.Columns[2].Name = "Precio";
            grillaCarrito.Columns[3].Name = "Total";

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

                    ActualizarLabelTotal();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada supera al STOCK disponible");
                }
            }
            catch { MessageBox.Show("Asegurese de seleccionar los productos deseados en la grilla Productos, y de que la cantidad ingresada sea un número"); }
            
        }

        private void ActualizarLabelTotal()
        {
            lblTotal.Text = "Total: " + ObtenerTotal().ToString();
            lblTotalConDescuento.Text = "Total con descuentos: " + ObtenerTotalConDescuento().ToString();
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


        private decimal ObtenerTotalConDescuento()
        {
            decimal total = 0;
            foreach (Item item in listaCarrito)
            {
                int descuento = bllDescuentos.ConsultarDescuento(item.idProducto);
                if (descuento > 0)
                {
                    total += (item.total * descuento) / 100;
                }
                else { total += item.total; }
            }
            return total;
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(grillaCarrito.CurrentRow.Cells[0].Value);
                Item itemAEliminar = listaCarrito.FirstOrDefault(item => item.idProducto == idProducto);

                if (itemAEliminar != null)
                {
                    listaCarrito.Remove(itemAEliminar);
                }
                ActualizarLabelTotal();
                ActualizarGrilla();
            }
            catch(Exception ex) { }
        }


        private void ActualizarGrilla()
        {
            grillaProductos.DataSource = null;
            grillaProductos.DataSource = bllProductos.traerTabla();

            grillaCarrito.Rows.Clear();
            if (listaCarrito.Count() > 0)
            {
                foreach (Item item in listaCarrito)
                {
                    grillaCarrito.Rows.Add(new string[] { item.idProducto.ToString(), item.cantidad.ToString(), item.precio.ToString(), item.total.ToString() });
                }
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (listaCarrito.Count > 0)
            {
                if(cmbMetodoPago.Text != "")
                {
                    Pedidos pedido = new Pedidos(user.IDUser, DateTime.Now.ToString("dd-MM-yyyy HH:mm"), cmbMetodoPago.Text, ObtenerTotalConDescuento());
                    if (cmbMetodoPago.Text == "Transferencia")
                    {
                        frmPagarTransferencia frm = new frmPagarTransferencia(pedido, listaCarrito);
                        frm.Show();
                    }
                    if(cmbMetodoPago.Text == "Tarjeta")
                    {
                        frmPagarTarjeta frm = new frmPagarTarjeta(pedido, listaCarrito);
                        frm.Show();
                    }
                    ActualizarGrilla();

                    //listaCarrito.Clear();//Limpia la lista una vez realizada la compra

                }
                else { MessageBox.Show("Seleccione un método de pago"); }

            }
            else { MessageBox.Show("Agregue productos al carrito para comprar"); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "")
            {
                grillaProductos.DataSource = bllProductos.BuscarDescripcionProducto(txtBuscar.Text);
            }
            else { MessageBox.Show("Ingrese la descripcion del producto que quiere buscar"); }
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
