using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clase.Suma sum = new Clase.Suma();
        Clase.Resta res = new Clase.Resta();
        Clase.Multiplicacion mul = new Clase.Multiplicacion();
        Clase.Division divi = new Clase.Division();

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "5";
        }

        private void btnSies_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxBoton.Text = tbxBoton.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxBoton.Text);
            tbxBoton.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxBoton.Text);
            tbxBoton.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxBoton.Text);
            tbxBoton.Clear();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxBoton.Text);
            tbxBoton.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxBoton.Text);

            double Sumaa;
            double Restaa;
            double Multii;
            double divii;

            switch (operador)
            {
                case "+":
                    Sumaa = sum.Sumar((primero), (segundo));
                    tbxBoton.Text = Sumaa.ToString();
                    break;
                case "-":
                    Restaa = res.Restar((primero), (segundo));
                    tbxBoton.Text = Restaa.ToString();
                    break;
                case "*":
                    Multii = mul.Multipli((primero), (segundo));
                    tbxBoton.Text = Multii.ToString();
                    break;
                case "/":
                    divii = divi.Divi((primero), (segundo));
                    tbxBoton.Text = divii.ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxBoton.Clear();
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            if (tbxBoton.Text.Length == 1)
                tbxBoton.Text = "";
            else
                tbxBoton.Text = tbxBoton.Text.Substring(0, tbxBoton.Text.Length - 1);
        }
    }
}
