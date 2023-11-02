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

namespace TP_Integrador
{
    public partial class frmReclamos : Form
    {
        public frmReclamos()
        {
            InitializeComponent();
        }

        BLLReclamos bllReclamos = new BLLReclamos();

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllReclamos.TraerTabla();
        }
    }
}
