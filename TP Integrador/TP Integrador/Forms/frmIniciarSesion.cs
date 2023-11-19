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
using Microsoft.VisualBasic.ApplicationServices;

namespace TP_Integrador
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        BLLUsuarios bllUsuarios = new BLLUsuarios();

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            (bool esValido, Usuario user) = bllUsuarios.VerificarUsuario(txtNombreUsuario.Text, txtClave.Text);
            user.IDUser = bllUsuarios.TraerId(txtNombreUsuario.Text);

            if (esValido)
            {
                this.Hide(); //oculta el formulario actual
                frmInicio form = new frmInicio(user);
                form.Show();
                form.FormClosing += CerrandoFormulario; //cuando se cierra el formulario Inicio ejecuta la funcion CerrandoFormulario que vuelve a mostrar el formulario actual
            }
            else
            {
                MessageBox.Show("No iniciaste sesión");
            }
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse form = new frmRegistrarse();
            form.Show();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "Empleado";
            txtClave.Text = "123";
        }

        private void CerrandoFormulario(object sender, FormClosingEventArgs e)
        {
            this.Show();
            //txtNombreUsuario.Text = "";
            //txtClave.Text = "";
        }
    }
}
