using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace TP_Integrador
{
    public partial class frmEnvios : Form
    {
        Usuario usuarioRecibido;
        public frmEnvios(Usuario user)
        {
            usuarioRecibido = user;
            InitializeComponent();
        }

        BLLEnvios bllEnvios = new BLLEnvios();
        

        private void frmEnvios_Load(object sender, EventArgs e)
        {
            grillaEnvios.DataSource = bllEnvios.traerTablaSegunCliente(usuarioRecibido.IDUser);
        }
    }
}
