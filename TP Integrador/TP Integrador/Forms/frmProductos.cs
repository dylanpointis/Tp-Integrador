using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador.Forms
{
    public partial class frmProductos : Form
    {
        Usuario usuario;
        public frmProductos(Usuario usuarioRecibido)
        {
            usuario = usuarioRecibido;
            InitializeComponent();
        }

        BLLProductos bllProductos = new BLLProductos();
        private void frmProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            grillaProductos.Columns[3].Width = 200;
        }

        public void ActualizarGrilla()
        {
            grillaProductos.DataSource = bllProductos.traerTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(numPrecio.Value > 0 && txtDescripcion.Text != "")
            {
                Producto prod = new Producto(Convert.ToDouble(numPrecio.Value), 0, txtDescripcion.Text);
                bllProductos.AltaProducto(prod);
                ActualizarGrilla();
            }          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProd = Convert.ToInt32(grillaProductos.CurrentRow.Cells[0].Value);
                bllProductos.BajaProducto(idProd);
            }catch(Exception ex) { MessageBox.Show("Seleccione un producto en la grilla para Eliminar"); }
        }
    }
}
