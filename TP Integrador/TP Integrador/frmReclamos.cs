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
using System.Data;
using BE;
using System.Threading;

namespace TP_Integrador
{
    public partial class frmReclamos : Form
    {
        private int idUser;

        public frmReclamos(Usuario user)
        {
            idUser = user.IDUser;
            InitializeComponent();
        }

        BLLReclamos bllReclamos = new BLLReclamos();

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reclamos reclamo = new Reclamos(textBox1.Text, comboBox1.Text);
            bllReclamos.AgregarReclamos(idUser,reclamo);
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();
            DataTable tabla = bllReclamos.TraerTabla();

            foreach(DataRow row in tabla.Rows)
            {
                if(Convert.ToInt32(row[1]) == idUser)
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
