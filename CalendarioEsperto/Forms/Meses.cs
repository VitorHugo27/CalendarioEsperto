using CalendarioEsperto.Desings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioEsperto.Forms
{
    public partial class Meses : Form
    {
        public Meses()
        {
            InitializeComponent();
        }

        private void Mes_Load(object sender, EventArgs e)
        {
            //CarregarMeses();

            //DateTime hoje = DateTime.Now;
        }

        public void CarregarMeses(string ano)
        {
            flowLayoutMeses.Controls.Clear();

            labelAnoAtualX.Text = $"Ano Atual: {ano} ";
            string[] mesesDoAno = DateTimeFormatInfo.CurrentInfo.MonthNames;

            for (int i = 0; i <= 11; i++)
            {
                MesUc mesUc = new MesUc(mesesDoAno[i], i);
                flowLayoutMeses.Controls.Add(mesUc);
            }
        }
    }
}
