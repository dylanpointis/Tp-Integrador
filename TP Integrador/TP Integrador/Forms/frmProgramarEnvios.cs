using BE;
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
    public partial class frmProgramarEnvios : Form
    {
        private Usuario user;
        public frmProgramarEnvios(Usuario userRecibido)
        {
            user = userRecibido;
            InitializeComponent();
        }

        private void frmProgramarEnvios_Load(object sender, EventArgs e)
        {

        }
    }
}
