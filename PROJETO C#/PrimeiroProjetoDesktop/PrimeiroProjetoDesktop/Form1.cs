using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoDesktop
{
    public partial class Form1 : Form
    {
        public int segundos;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTestar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Olá {txtNome.Text}! seja bem vindo ❤", "Boas Vindas‼", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 + n2;
            double resultadoM = n1 * n2;
            txtResultado.Text = resultado.ToString();
            txtResultadoMulti.Text = resultadoM.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
          
        }

        private void tmrSegundos_Tick(object sender, EventArgs e)
        {
            segundos += 1;
            lblsegundos.Text = segundos.ToString();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            tmrSegundos.Enabled = true;
            btnstart.Enabled = false;
            
            btnstop.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            tmrSegundos.Enabled = false;
            btnstop.Enabled= false;
            btnzerar.Enabled = true;
            btnstart.Enabled = true;
        }

        private void btnzerar_Click(object sender, EventArgs e)
        {
            segundos = 0;
            lblsegundos.Text = segundos.ToString();
            tmrSegundos.Enabled = false;
            btnstart.Enabled = true;
            btnzerar.Enabled= false;
            btnstop.Enabled = false;
        }
    }
}
