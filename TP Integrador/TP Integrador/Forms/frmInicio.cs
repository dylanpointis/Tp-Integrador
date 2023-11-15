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
        Usuario usuarioRecibido;


        public frmInicio(Usuario user)
        {
            usuarioRecibido = user;
            InitializeComponent();
        }

        Form formActivo = new Form();

        private void AbrirForm(Form form)
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


        private void btnComprar_Click(object sender, EventArgs e)
        {
            frmComprar form = new frmComprar(usuarioRecibido);
            AbrirForm(form);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            frmReclamos form = new frmReclamos(usuarioRecibido);
            AbrirForm(form);
        }

 

        private void frmInicio_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bienvenido {usuarioRecibido.Rol} {usuarioRecibido.NombreUsuario}";
            if(usuarioRecibido.Rol == "Empleado")
            {
                btnComprar.Visible = false;
                btnVerConsultas.Visible = false;
                btnAdministrarUsuarios.Visible = false;
                btnEnvios.Visible = false;
            }
            if (usuarioRecibido.Rol == "Cliente")
            {
                btnProgramarEnvios.Visible = false;
                btnVerConsultas.Visible = false;
                btnAdministrarUsuarios.Visible = false;
            }
        }

        private void btnVerConsultas_Click(object sender, EventArgs e)
        {
            frmConsultarVentas admin = new frmConsultarVentas();
            AbrirForm(admin);
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            frmEnvios form = new frmEnvios(usuarioRecibido);
            AbrirForm(form);
        }

        private void btnProgramarEnvios_Click(object sender, EventArgs e)
        {
            frmProgramarEnvios form = new frmProgramarEnvios(usuarioRecibido);
            AbrirForm(form);
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            frmAdministrarUsuarios form = new frmAdministrarUsuarios();
            AbrirForm(form);
        }
    }
}
