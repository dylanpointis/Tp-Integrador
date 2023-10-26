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
using System.Data;

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
            Usuario user = new Usuario(txtNombreUsuario.Text, txtClave.Text);

            (bool esValido, string rol) = bllUsuarios.VerificarUsuario(user.NombreUsuario, user.Clave);


            if (esValido)
            {
                user.Rol = rol;
                frmInicio form = new frmInicio(user);
                form.Show();
   
            }
            else
            {
                MessageBox.Show("No iniciaste sesion");
            }
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "Joaquin";
            txtClave.Text = "123";
        }
    }
}
