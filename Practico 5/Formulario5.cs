using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicos.Practico_5
{
    public partial class Formulario5 : Form
    {
        public Formulario5()
        {
            InitializeComponent();
        }



        private void Formulario5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = ovalImg1.ImageLocation;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                TBFoto.Text = FileName;
                ovalImg1.Image = Image.FromFile(FileName);
            }
        }
        private void FormatTextBox(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string text = textBox.Text;
                textBox.TextChanged -= TBApellido_TextChanged;
                textBox.TextChanged -= TBNombre_TextChanged;

                textBox.Text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;

                textBox.TextChanged += TBApellido_TextChanged;
                textBox.TextChanged += TBNombre_TextChanged;
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            FormatTextBox(sender as TextBox);
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            FormatTextBox(sender as TextBox);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            String name = TBNombre.Text.Trim();
            String surname = TBApellido.Text.Trim();
            String saldo = TBSaldo.Text.Trim();
            String path = TBFoto.Text.Trim();

            if (name == "" || surname == "" || saldo == "" || path == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!saldo.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!name.All(char.IsLetter) || !surname.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en los campos Nombre y Apellidos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!CBHombre.Checked && !CBMujer.Checked)
            {
                MessageBox.Show("Por favor, seleccione un genero.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            Image img = null;
            try
            {
                img = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CBHombre.Checked)
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
                    dataGridView1.Rows.Add(name, surname, fecha, "Hombre", new DataGridViewButtonCell() { Value = "Eliminar" }, saldo ,  img, path);
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
                    dataGridView1.Rows.Add(name, surname, fecha, "Mujer", new DataGridViewButtonCell() { Value = "Eliminar" }, saldo, img, path);
                }
            }
            if (Int32.Parse(saldo) < 50)
            {
                int rowIndex = dataGridView1.Rows.Count - 1;

                // Cambia el color de fondo de la fila
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void CBHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (CBHombre.Checked)
            {
                CBMujer.Checked = false;
            }
        }

        private void CBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMujer.Checked)
            {
                CBHombre.Checked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Confirm the deletion
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta usuario?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the row
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sexo" && e.RowIndex >= 0)
            {
                string sexo = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (sexo == "Hombre")
                {
                    CBHombre.Checked = true;
                    CBMujer.Checked = false;
                }
                else
                {
                    CBMujer.Checked = true;
                    CBHombre.Checked = false;

                }

            }

        }


    }
}

