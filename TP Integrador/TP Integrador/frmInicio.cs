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

namespace TP_Integrador
{
    public partial class frmInicio : Form
    {
        string nombreUsuario;
        string rol;

        Usuario usuarioRecibido;


        public frmInicio(Usuario user)
        {
            usuarioRecibido = user;
            nombreUsuario = user.NombreUsuario;
            rol = user.Rol;
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
            frmComprar form = new frmComprar();
            AbrirForm(form);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            frmReclamos form = new frmReclamos(usuarioRecibido);
            AbrirForm(form);
        }

 

        private void frmInicio_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bienvenido {rol} {nombreUsuario}";
        }

        private void btnVerConsultas_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            AbrirForm(admin);
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            frmEnvios form = new frmEnvios();
            AbrirForm(form);
        }
    }
}
