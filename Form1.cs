using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaculadoraCorreta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblResultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblResultado.Text = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNum1.Clear();
            TxtNum2.Clear();
            LblResultado.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair do sistema?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair.Equals(DialogResult.No))
            {

            } else
            {
                Application.Exit();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Double n1 = 0;
            Double n2 = 0;
            Double Resultado = 0;

            n1 = Convert.ToDouble(TxtNum1.Text);
            n2 = Convert.ToDouble(TxtNum2.Text);

          switch (CboTipoCalc.SelectedItem.ToString() )
            {
                case "Soma":

                    Resultado = n1 + n2;
                    break;
                case "Sub":

                    Resultado = n1 - n2;
                    break;
                case "Mult":

                    Resultado = n1 * n2;
                    break;
                case "div":

                    Resultado = n1 / n2;
                    break;
            }




            LblResultado.Text = Convert.ToString(Resultado);
        }   
    }
}
