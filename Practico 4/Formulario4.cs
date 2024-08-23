using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicos.Practico_4
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBDesde.Text == "" || TBHasta.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TBDesde.Text.All(char.IsDigit) || !TBHasta.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en los campos Desde y Hasta.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 desde = Convert.ToInt32(TBDesde.Text);
            while (desde <= Convert.ToInt32(TBHasta.Text))
            {   
                listBox1.Items.Add(desde);
                desde++;
            }
        }
    }
}
