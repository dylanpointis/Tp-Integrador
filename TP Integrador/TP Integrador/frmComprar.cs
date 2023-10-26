﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TP_Integrador
{
    public partial class frmComprar : Form
    {
        public frmComprar()
        {
            InitializeComponent();
        }

        public BLLComprar bll = new BLLComprar();

        private void frmComprar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.traerTabla();
        }
    }
}
