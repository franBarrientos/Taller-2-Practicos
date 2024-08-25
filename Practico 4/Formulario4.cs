using System;
using System.Linq;
using System.Windows.Forms;
using OxyPlot.Series;
using OxyPlot;

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
            listBox1.Items.Clear();
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

            int desde = Convert.ToInt32(TBDesde.Text);
            while (desde <= Convert.ToInt32(TBHasta.Text))
            {
                listBox1.Items.Add(desde);
                desde++;
            }

            // Crea el gráfico
            var plotModel = new PlotModel { Title = "Gráfico" };
            double[] ys = listBox1.Items.Cast<int>().Select(x => (double)x).ToArray();
            double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
            var series = new LineSeries();
            for (int i = 0; i < xs.Length; i++)
            {
                series.Points.Add(new DataPoint(xs[i], ys[i]));
            }
            plotModel.Series.Add(series);

            // Muestra el gráfico en el nuevo formulario
            var graphForm = new GraphForm();
            graphForm.SetPlotModel(plotModel);
            graphForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

            int desde = Convert.ToInt32(TBDesde.Text);
            while (desde <= Convert.ToInt32(TBHasta.Text))
            {
                if (desde % 2 == 0)
                {
                    listBox1.Items.Add(desde);
                }
                desde++;
            }

            // Crea el gráfico
            var plotModel = new PlotModel { Title = "Gráfico" };
            double[] ys = listBox1.Items.Cast<int>().Select(x => (double)x).ToArray();
            double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
            var series = new LineSeries();
            for (int i = 0; i < xs.Length; i++)
            {
                series.Points.Add(new DataPoint(xs[i], ys[i]));
            }
            plotModel.Series.Add(series);

            // Muestra el gráfico en el nuevo formulario
            var graphForm = new GraphForm();
            graphForm.SetPlotModel(plotModel);
            graphForm.Show();
        }

        private void BTImpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

            int desde = Convert.ToInt32(TBDesde.Text);
            while (desde <= Convert.ToInt32(TBHasta.Text))
            {
                if (desde % 2 != 0)
                {
                    listBox1.Items.Add(desde);
                }
                desde++;
            }

            // Crea el gráfico
            var plotModel = new PlotModel { Title = "Gráfico" };
            double[] ys = listBox1.Items.Cast<int>().Select(x => (double)x).ToArray();
            double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
            var series = new LineSeries();
            for (int i = 0; i < xs.Length; i++)
            {
                series.Points.Add(new DataPoint(xs[i], ys[i]));
            }
            plotModel.Series.Add(series);

            // Muestra el gráfico en el nuevo formulario
            var graphForm = new GraphForm();
            graphForm.SetPlotModel(plotModel);
            graphForm.Show();
        }

        private void BTPrimos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

            int desde = Convert.ToInt32(TBDesde.Text);
            while (desde <= Convert.ToInt32(TBHasta.Text))
            {
                bool esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(desde); i++)
                {
                    if (desde % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo && desde > 1)
                {
                    listBox1.Items.Add(desde);
                }
                desde++;
            }

            // Crea el gráfico
            var plotModel = new PlotModel { Title = "Gráfico" };
            double[] ys = listBox1.Items.Cast<int>().Select(x => (double)x).ToArray();
            double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
            var series = new LineSeries();
            for (int i = 0; i < xs.Length; i++)
            {
                series.Points.Add(new DataPoint(xs[i], ys[i]));
            }
            plotModel.Series.Add(series);

            // Muestra el gráfico en el nuevo formulario
            var graphForm = new GraphForm();
            graphForm.SetPlotModel(plotModel);
            graphForm.Show();
        }
    }
}
