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
using TP_Integrador.Forms;

namespace TP_Integrador
{
    public partial class frmInicio : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();


        public frmInicio()
        {
            InitializeComponent();
        }

        Form formActivo = new Form();

        private void AbrirForm(Form form) //FUNCION PARA ABRIR FORMS DENTRO DEL MDIPARENT
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = form;
            formActivo.MdiParent = this;
            formActivo.Dock = DockStyle.Fill;
            formActivo.ControlBox = false;
            formActivo.FormBorderStyle = FormBorderStyle.None;
            formActivo.Text = "";
            

            formActivo.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e) //OCULTAR BOTONES SEGUN ROL
        {
            label1.Text = $"Bienvenido {user.Rol} {user.NombreUsuario}";
            if (user.Rol == "Empleado")
            {
                btnComprar.Visible = false;
                btnConsultarVentas.Visible = false;
                btnAdministrarUsuarios.Visible = false;
                btnVerEnvio.Visible = false;
            }
            if (user.Rol == "Cliente")
            {
                btnProductos.Visible = false;
                btnProgramarEnvios.Visible = false;
                btnConsultarVentas.Visible = false;
                btnAdministrarUsuarios.Visible = false;
                btnProveedores.Visible = false;
            }
        }

        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            frmComprar form = new frmComprar();
            AbrirForm(form);
        }

        private void btnVerEnvio_Click(object sender, EventArgs e)
        {
            frmEnvios form = new frmEnvios();
            AbrirForm(form);
        }

        private void btnProgramarEnvios_Click_1(object sender, EventArgs e)
        {
            frmProgramarEnvios form = new frmProgramarEnvios();
            AbrirForm(form);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            AbrirForm(form);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores form = new frmProveedores();
            AbrirForm(form);
        }

        private void btnAdministrarUsuarios_Click_1(object sender, EventArgs e)
        {
            frmAdministrarUsuarios form = new frmAdministrarUsuarios();
            AbrirForm(form);
        }

        private void btnReclamos_Click_1(object sender, EventArgs e)
        {
            frmReclamos form = new frmReclamos();
            AbrirForm(form);
        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            frmConsultarVentas admin = new frmConsultarVentas();
            AbrirForm(admin);
        }
    }
}
