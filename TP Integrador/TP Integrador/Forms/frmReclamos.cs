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
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;

namespace TP_Integrador
{
    public partial class frmReclamos : Form
    {
        private Usuario usuario;

        public frmReclamos(Usuario usuarioRecibido)
        {
            usuario = usuarioRecibido;
            InitializeComponent();
        }

        BLLReclamos bllReclamos = new BLLReclamos();

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[3].Width = 270;
            ActualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reclamos reclamo = new Reclamos(textBox1.Text, comboBox1.Text);
            bllReclamos.AgregarReclamos(usuario.IDUser, reclamo);
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();
            DataTable tabla = bllReclamos.TraerTabla();

            if(usuario.Rol == "Cliente") // SI ES UN CLIENTE SOLO MUESTRA SUS RECLAMOS
            {
                foreach (DataRow row in tabla.Rows)
                {
                    if (Convert.ToInt32(row[1]) == usuario.IDUser)
                    {
                        dataGridView1.Rows.Add(row.ItemArray);
                    }
                }
            }
            else // SI ES EMPLEADO O ADMIN MUESTRA TODOS LOS RECLAMOS
            {
                foreach (DataRow row in tabla.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idReclamo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            bllReclamos.EliminarReclamo(idReclamo);
            ActualizarGrilla();
        }
    }
}
