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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_Integrador.Forms
{
    public partial class frmAdministrarUsuarios : Form
    {
        public frmAdministrarUsuarios()
        {
            InitializeComponent();
        }


        BLLUsuarios bllUser = new BLLUsuarios();

        private void frmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }


        BLLEmpleado bllEmp = new BLLEmpleado();
        BLLCliente bllCli = new BLLCliente();


        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllUser.traerTabla();
        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string rol = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);


            if (rol == "Empleado")
            {
                bllEmp.BajaEmpleado(id);
            }
            if (rol == "Cliente")
            {
                bllCli.BajaCliente(id);
            }
            bllUser.BajaUsuario(id);

            ActualizarGrilla();
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            bllUser.RegistrarUsuario(txtUsuario.Text, txtClave.Text, comboBox1.Text);
            if (comboBox1.Text == "Empleado")
            {
                int idUser = bllUser.TraerId(txtUsuario.Text);
                frmAltaEmpleado form = new frmAltaEmpleado(idUser);
                form.Show();
            }

            ActualizarGrilla();
        }
    }
}
