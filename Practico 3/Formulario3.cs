using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicos.Practico_3
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void Formulario2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            String name = TBNombre.Text.Trim();
            String surname = TBApellido.Text.Trim();
            String dni = TBDni.Text.Trim();
            String telefono = TBTelefono.Text.Trim();
            if (name == "" || surname == "" || dni == "" || telefono == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dni.Length != 8)
            {
                MessageBox.Show("Por favor, ingrese un DNI de 8 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!name.All(char.IsLetter) || !surname.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en los campos Nombre y Apellidos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CBMastercard.Checked && !CBVisa.Checked && !CBNaranja.Checked)
            {
                MessageBox.Show("Por favor, seleccione un tipo de tarjeta.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CBVaron.Checked && !CBMujer.Checked)
            {
                MessageBox.Show("Por favor, seleccione un genero.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LModificar.Text = name + " " + surname;

            if (CBVaron.Checked)
            {
                DialogResult ask = MessageBox.Show(
                   "¿Seguro que desea insertar un nuevo Cliente?",
                   "Confirmar Insercion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + name + " " + surname + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    LModificar.Text = "";
                }
            }
            else
            {
                DialogResult ask = MessageBox.Show(
               "¿Seguro que desea insertar una nueva Clienta?",
               "Confirmar Insercion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("La clienta " + name + " " + surname + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    LModificar.Text = "";
                }


            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            String name = TBNombre.Text.Trim();
            String surname = TBApellido.Text.Trim();
            String dni = TBDni.Text.Trim();
            String telefono = TBTelefono.Text.Trim();
            if (name == "" || surname == "" || dni == "" || telefono == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dni.Length != 8)
            {
                MessageBox.Show("Por favor, ingrese un DNI de 8 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!name.All(char.IsLetter) || !surname.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en los campos Nombre y Apellidos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!CBMastercard.Checked && !CBVisa.Checked && !CBNaranja.Checked)
            {
                MessageBox.Show("Por favor, seleccione un tipo de tarjeta.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CBVaron.Checked && !CBMujer.Checked)
            {
                MessageBox.Show("Por favor, seleccione un genero.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LModificar.Text = name + " " + surname;

            if (CBVaron.Checked)
            {
                DialogResult ask = MessageBox.Show(
                   "Esta a punto de eliminar el Cliente: " + name + " " + surname,
                   "Confirmar Eliminacion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button2);

                if (ask == DialogResult.Yes)
                {

                    MessageBox.Show("El cliente " + name + " " + surname + " ha sido eliminado con exito.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBApellido.Text = "";
                    TBNombre.Text = "";
                    LModificar.Text = "";
                    TBDni.Text = "";
                    TBTelefono.Text = "";
                    CBNaranja.Checked = false;
                    CBVisa.Checked = false;
                    CBMastercard.Checked = false;
                }
            }
            else
            {
                DialogResult ask = MessageBox.Show(
              "Esta a punto de eliminar la Clienta: " + name + " " + surname,
              "Confirmar Eliminacion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button2);

                if (ask == DialogResult.Yes)
                {

                    MessageBox.Show("La clienta " + name + " " + surname + " ha sido eliminado con exito.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBApellido.Text = "";
                    TBNombre.Text = "";
                    LModificar.Text = "";
                    TBDni.Text = "";
                    TBTelefono.Text = "";
                    CBNaranja.Checked = false;
                    CBVisa.Checked = false;
                    CBMastercard.Checked = false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CBVaron.Checked)
            {
                CBMujer.Checked = false;
                ImgAvatar.BackgroundImage = Image.FromFile(@"..\..\..\Properties\avatar.png");
                LBTitulo.Text = "Nuevo Cliente";
            }
        }

        private void CBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMujer.Checked)
            {
                CBVaron.Checked = false;
                ImgAvatar.BackgroundImage = Image.FromFile(@"..\..\..\Properties\mujer.png");
                LBTitulo.Text = "Nueva Clienta";
            }

        }

        private void avatar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Avatar_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
