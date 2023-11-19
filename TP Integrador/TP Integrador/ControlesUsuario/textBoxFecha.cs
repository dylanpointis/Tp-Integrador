using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador.ControlesUsuario
{
    public partial class textBoxFecha : UserControl
    {
        public textBoxFecha()
        {
            InitializeComponent();
        }

        public string Text;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //No funciona
            Regex re = new Regex("^([012][0-9]|3[01])\\/(0[1-9]|1[0-2])\\/(199[0-9]|20[12][0-9])$");

            if (re.IsMatch(textBox1.Text.Trim()))
            {
                Text = textBox1.Text;
            }
            
        }
    }
}
