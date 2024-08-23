using Practicos.Practico_1;
using Practicos.Practico_2;
using Practicos.Practico_3;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicos
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Formulario1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Formulario2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Formulario3().Show();
        }
    }
}
