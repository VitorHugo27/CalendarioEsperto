using ApiFeriadosDoAno.Class;
using ApiFeriadosDoAno.Service;
using CalendarioEsperto.Desings;
using CalendarioEsperto.Forms;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalendarioEsperto
{
    public partial class Dias : Form
    {
        public Dias()
        {
            InitializeComponent();
        }

        private async void Dias_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            await DiasDoMes(mes, ano, dia);
        }

        private async Task DiasDoMes(int mes = 0, int ano = 0, int dia = 0)
        {
            flowLayoutPanelDias.Controls.Clear();
            labelAno.Text = "Ano: " + ano;
            labelMes.Text = "Mês: " + mes;
            DateTime primeiroDia = new DateTime(ano, mes, 1);

            int diaNumeroDaSemana = (int)primeiroDia.DayOfWeek;

            var api = new ApiService();

            List<Feriados> feriados = await api.GetAsync(ano);

            for (int i = 0; i < diaNumeroDaSemana; i++)
            {
                DiaUc diasUc = new DiaUc("", "", feriados);
                flowLayoutPanelDias.Controls.Add(diasUc);
            }

            int qtdDiasDoMes = DateTime.DaysInMonth(ano, mes);

            for (dia = 1; dia <= qtdDiasDoMes; dia++)
            {
                DiaUc diasUc = new DiaUc(dia.ToString(), mes.ToString(), feriados);
                flowLayoutPanelDias.Controls.Add(diasUc);
            }
        }

        private async void buttonAnterior_Click(object sender, EventArgs e)
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

        private async void buttonProximo_Click(object sender, EventArgs e)
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

        private async void labelMes_Click(object sender, EventArgs e)
        {
            this.Hide();
            string ano = this.labelAno.Text.Replace("Ano:", "");
            Meses MesesForm = new Meses();
            MesesForm.Show();
            MesesForm.CarregarMeses(ano);
        }

        private async void labelAno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meses MesesForm = new Meses();
            MesesForm.Show();
        }
    }
}
