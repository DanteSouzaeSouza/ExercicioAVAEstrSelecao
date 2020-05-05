using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAVAEstrSelecao
{
    public partial class FrmDiaSemana : Form
    {
        public FrmDiaSemana()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha a aplicação
            Application.Exit();
        }

        private void FrmDiaSemana_Load(object sender, EventArgs e)
        {
            // limpa o Label que mostra o dia da semana
            lblDiaSemana.ResetText();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // reservar o dia digitado pelo usuário
            int dia;

            // Verificar se o que foi digitado é mesmo um nº inteiro
            dia = Convert.ToInt16(txtDia.Text);

            //TODO: Ajustar o programa para ler uma letra e não travar.

            // verificar qual dia exibir com base no dia digitado
            switch (dia)
            {
                case 1:
                    lblDiaSemana.Text = "Domingo";
                    break;
                case 2:
                    lblDiaSemana.Text = "Segunda-feira";
                    break;
                case 3:
                    lblDiaSemana.Text = "Terça-feira";
                    break;
                case 4:
                    lblDiaSemana.Text = "Quarta-feira";
                    break;
                case 5:
                    lblDiaSemana.Text = "Quinta-feira";
                    break;
                case 6:
                    lblDiaSemana.Text = "Sexta-feira";
                    break;
                case 7:
                    lblDiaSemana.Text = "Sábado";
                    break;
                default:
                    MessageBox.Show("Digite um valor válido!");
                    break;
            }
        }
    }
}
