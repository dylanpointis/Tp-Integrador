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
using BLL;


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

        BLLEnvios bllEnvios = new BLLEnvios();
        BLLLogistica bllLogistica = new BLLLogistica();

        private void frmProgramarEnvios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void btnProgramarEnvio_Click(object sender, EventArgs e)
        {
            //ID EMPLEADO, ID_LOGISTICA, ESTADO A "Esperando preparación", Fecha de envío
            try
            {
                int idLogistica = Convert.ToInt32(grillaLogistica.CurrentRow.Cells[0].Value);
                int idEnvio = Convert.ToInt32(grillaEnvios.CurrentRow.Cells[0].Value);


                bllEnvios.ProgramarEnvio(idEnvio, user.IDUser, idLogistica, "En preparación", dateTimePicker1.Value.ToString("dd-MM-yyyy"));

                ActualizarGrilla();
            }catch(Exception ex) { MessageBox.Show("Seleccione un envio y una empresa de logistica"); }
           
        }

        private void ActualizarGrilla()
        {
            grillaEnvios.DataSource = bllEnvios.traerTabla();
            grillaLogistica.DataSource = bllLogistica.traerTabla();

        }
    }
}
