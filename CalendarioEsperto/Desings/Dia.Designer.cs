namespace CalendarioEsperto.Desings
{
    partial class DiaUc
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelDias = new Panel();
            labelFeriado = new Label();
            labelDia = new Label();
            panelDias.SuspendLayout();
            SuspendLayout();
            // 
            // panelDias
            // 
            panelDias.BackColor = Color.FromArgb(224, 224, 224);
            panelDias.Controls.Add(labelFeriado);
            panelDias.Controls.Add(labelDia);
            panelDias.Dock = DockStyle.Fill;
            panelDias.Location = new Point(0, 0);
            panelDias.Margin = new Padding(1);
            panelDias.Name = "panelDias";
            panelDias.Size = new Size(80, 80);
            panelDias.TabIndex = 0;
            panelDias.DoubleClick += panelDias_DoubleClick;
            panelDias.MouseEnter += panelDias_MouseEnter;
            panelDias.MouseLeave += panelDias_MouseLeave;
            // 
            // labelFeriado
            // 
            labelFeriado.AutoSize = true;
            labelFeriado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFeriado.Location = new Point(3, 32);
            labelFeriado.Name = "labelFeriado";
            labelFeriado.Size = new Size(0, 13);
            labelFeriado.TabIndex = 1;
            // 
            // labelDia
            // 
            labelDia.AutoSize = true;
            labelDia.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDia.Location = new Point(43, 10);
            labelDia.Name = "labelDia";
            labelDia.Size = new Size(24, 18);
            labelDia.TabIndex = 0;
            labelDia.Text = "00";
            // 
            // DiaUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDias);
            Name = "DiaUc";
            Size = new Size(80, 80);
            panelDias.ResumeLayout(false);
            panelDias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDias;
        private Label labelDia;
        public Label labelFeriado;
    }
}
