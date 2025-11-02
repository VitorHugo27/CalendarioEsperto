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
        public DiaUc(string Dia)
        {
            InitializeComponent();

            labelDia.Text = Dia.ToString();

            //if (Dia == DateTime.Now.Day.ToString())
            //{
            //    labelDia.BackColor = Color.LightBlue;
            //}
        }
    }
}
