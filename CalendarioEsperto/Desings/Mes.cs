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
    public partial class MesUc : UserControl
    {
        public MesUc(string mesEscrito, int MesNumero)
        {
            InitializeComponent();

            panelMeses.MouseEnter += panelMeses_MouseEnter;
            panelMeses.MouseLeave += panelMeses_MouseLeave;

            labelNumeroDoMes.Text = (MesNumero + 1).ToString();
            labelMesEscrito.Text = mesEscrito.ToString();

            DateTime dataAtual = DateTime.Now;
            int numeroMesAtuala = dataAtual.Month;

            if (MesNumero == (numeroMesAtuala - 1))
            {
                panelMeses.BackColor = Color.LightBlue;
            }

        }

        private void panelMeses_MouseEnter(object sender, EventArgs e)
        {
            panelMeses.BackColor = Color.Silver;
        }

        private void panelMeses_MouseLeave(object sender, EventArgs e)
        {
            panelMeses.BackColor = Color.FromArgb(224, 224, 224);
        }
    }
}
