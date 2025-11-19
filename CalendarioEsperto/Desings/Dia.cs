using ApiFeriadosDoAno.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioEsperto.Desings
{
    public partial class DiaUc : UserControl
    {
        public DiaUc(string Dia, string Mes, List<Feriados> feriados)
        {
            InitializeComponent();

            panelDias.MouseEnter += panelDias_MouseEnter;
            panelDias.MouseLeave += panelDias_MouseLeave;

            foreach (var feriado in feriados)
            {
                DateTime dataFeriado = feriado.date;
                int diaFeriado = dataFeriado.Day;
                int mesFeriado = dataFeriado.Month;
                if (!string.IsNullOrEmpty(Dia) && !string.IsNullOrEmpty(Mes))
                {
                    if (int.Parse(Dia) == diaFeriado && int.Parse(Mes) == mesFeriado)
                    {
                        string stringComQuebraDeLinha = string.Join(Environment.NewLine, feriado.name.Select((c, i) => new { c, i })
                                                             .GroupBy(x => x.i / 9)
                                                             .Select(g => new string(g.Select(x => x.c).ToArray())));
                        labelFeriado.Text = stringComQuebraDeLinha;
                        labelFeriado.ForeColor = Color.Red;
                    }
                }
            }

            labelDia.Text = Dia.ToString();

            DateTime dataAtual = DateTime.Now;
            int numeroDiaAtual = dataAtual.Day;
            int numeroMesAtual = dataAtual.Month;
            if (!string.IsNullOrEmpty(Dia) && !string.IsNullOrEmpty(Mes))
            {
                if (int.Parse(Dia) == numeroDiaAtual && int.Parse(Mes) == numeroMesAtual)
                {
                    panelDias.BackColor = Color.LightBlue;
                }
            }
        }

        private void panelDias_MouseEnter(object sender, EventArgs e)
        {
            panelDias.BackColor = Color.Silver;
        }

        private void panelDias_MouseLeave(object sender, EventArgs e)
        {
            panelDias.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panelDias_DoubleClick(object sender, EventArgs e)
        {
            string dia = this.labelDia.Text;
            string feriado = this.labelFeriado.Text;

            if(!string.IsNullOrEmpty(feriado))
            {
                dia += "\nFeriado: " + feriado;
            }
            MessageBox.Show(dia);
        }
    }
}
