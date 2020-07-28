using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpromediar_Click(object sender, EventArgs e)
        {
            Double nota1 = Double.Parse(txtnota1.Text);
            Double nota2 = Double.Parse(txtnota2.Text);
            Double Nota3 = Double.Parse(txtnota3.Text);
            Double promedio = 0;

            promedio = (nota1 + nota2 + Nota3) / 3;

            lblresultado.Text = Convert.ToString(promedio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtnota3.Text = String.Empty;
            lblresultado.Text = "0";
            txtnota1.Focus();
        }
    }
}
