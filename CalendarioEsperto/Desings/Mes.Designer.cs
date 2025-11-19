namespace CalendarioEsperto.Desings
{
    partial class MesUc
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
            panelMeses = new Panel();
            labelMesEscrito = new Label();
            labelNumeroDoMes = new Label();
            panelMeses.SuspendLayout();
            SuspendLayout();
            // 
            // panelMeses
            // 
            panelMeses.BackColor = Color.FromArgb(224, 224, 224);
            panelMeses.Controls.Add(labelMesEscrito);
            panelMeses.Controls.Add(labelNumeroDoMes);
            panelMeses.Dock = DockStyle.Fill;
            panelMeses.Location = new Point(0, 0);
            panelMeses.Margin = new Padding(1);
            panelMeses.Name = "panelMeses";
            panelMeses.Size = new Size(115, 115);
            panelMeses.TabIndex = 0;
            panelMeses.MouseEnter += panelMeses_MouseEnter;
            panelMeses.MouseLeave += panelMeses_MouseLeave;
            // 
            // labelMesEscrito
            // 
            labelMesEscrito.AutoSize = true;
            labelMesEscrito.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMesEscrito.Location = new Point(12, 75);
            labelMesEscrito.Name = "labelMesEscrito";
            labelMesEscrito.Size = new Size(43, 20);
            labelMesEscrito.TabIndex = 1;
            labelMesEscrito.Text = "Mes:";
            labelMesEscrito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumeroDoMes
            // 
            labelNumeroDoMes.AutoSize = true;
            labelNumeroDoMes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumeroDoMes.Location = new Point(70, 9);
            labelNumeroDoMes.Name = "labelNumeroDoMes";
            labelNumeroDoMes.Size = new Size(24, 18);
            labelNumeroDoMes.TabIndex = 0;
            labelNumeroDoMes.Text = "00";
            // 
            // MesUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMeses);
            Name = "MesUc";
            Size = new Size(115, 115);
            panelMeses.ResumeLayout(false);
            panelMeses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMeses;
        private Label labelMes;
        private Label labelNumeroDoMes;
        private Label labelMesEscrito;
    }
}
