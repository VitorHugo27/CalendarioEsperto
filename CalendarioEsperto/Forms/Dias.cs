using CalendarioEsperto.Desings;
using CalendarioEsperto.Forms;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalendarioEsperto
{
    public partial class Dias : Form
    {
        public Dias()
        {
            InitializeComponent();
        }

        private void Dias_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            DiasDoMes(mes, ano, dia);
        }

        private void DiasDoMes(int mes = 0, int ano = 0, int dia = 0)
        {
            flowLayoutPanelDias.Controls.Clear();
            labelAno.Text = "Ano: " + ano;
            labelMes.Text = "Mês: " + mes;
            DateTime primeiroDia = new DateTime(ano, mes, 1);

            int diaNumeroDaSemana = (int)primeiroDia.DayOfWeek;
            for (int i = 0; i < diaNumeroDaSemana; i++)
            {
                DiaUc diasUc = new DiaUc("");
                flowLayoutPanelDias.Controls.Add(diasUc);
            }

            int qtdDiasDoMes = DateTime.DaysInMonth(ano, mes);

            for (dia = 1; dia <= qtdDiasDoMes; dia++)
            {
                DiaUc diasUc = new DiaUc(dia.ToString());
                flowLayoutPanelDias.Controls.Add(diasUc);
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            int anoAtual = (int.Parse(labelAno.Text.Replace("Ano:", "")));
            int mesAtual = (int.Parse(labelMes.Text.Replace("Mês:", "")) - 1);

            if (mesAtual == 0)
            {
                mesAtual = 12;
                anoAtual -= 1;
            }

            DiasDoMes(mesAtual, anoAtual);

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            int anoAtual = (int.Parse(labelAno.Text.Replace("Ano:", "")));
            int mesAtual = (int.Parse(labelMes.Text.Replace("Mês:", "")) + 1);

            if (mesAtual == 13)
            {
                mesAtual = 1;
                anoAtual += 1;
            }

            DiasDoMes(mesAtual, anoAtual);
        }

        private void labelMes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meses MesesForm = new Meses();
            MesesForm.Show();
        }

        private void labelAno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meses MesesForm = new Meses();
            MesesForm.Show();
        }
    }
}
