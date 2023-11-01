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

            if (esValido)
            {
                frmInicio form = new frmInicio(user);
                form.Show();
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
            txtNombreUsuario.Text = "Joaquin";
            txtClave.Text = "123";
        }
    }
}
