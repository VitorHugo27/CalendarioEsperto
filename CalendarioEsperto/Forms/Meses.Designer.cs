namespace CalendarioEsperto.Forms
{
    partial class Meses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meses));
            flowLayoutMeses = new FlowLayoutPanel();
            labelMesesDoAno = new Label();
            labelAnoAtualX = new Label();
            SuspendLayout();
            // 
            // flowLayoutMeses
            // 
            flowLayoutMeses.Location = new Point(12, 123);
            flowLayoutMeses.Name = "flowLayoutMeses";
            flowLayoutMeses.Size = new Size(605, 542);
            flowLayoutMeses.TabIndex = 0;
            // 
            // labelMesesDoAno
            // 
            labelMesesDoAno.AutoSize = true;
            labelMesesDoAno.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMesesDoAno.ForeColor = Color.Black;
            labelMesesDoAno.Location = new Point(15, 91);
            labelMesesDoAno.Name = "labelMesesDoAno";
            labelMesesDoAno.Size = new Size(100, 16);
            labelMesesDoAno.TabIndex = 2;
            labelMesesDoAno.Text = "Meses do Ano: ";
            // 
            // labelAnoAtualX
            // 
            labelAnoAtualX.AutoSize = true;
            labelAnoAtualX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAnoAtualX.ForeColor = Color.Black;
            labelAnoAtualX.Location = new Point(255, 91);
            labelAnoAtualX.Name = "labelAnoAtualX";
            labelAnoAtualX.Size = new Size(81, 16);
            labelAnoAtualX.TabIndex = 3;
            labelAnoAtualX.Text = "Ano Atual: X ";
            // 
            // Meses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 671);
            Controls.Add(labelAnoAtualX);
            Controls.Add(labelMesesDoAno);
            Controls.Add(flowLayoutMeses);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Meses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meses";
            Load += Mes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutMeses;
        private Label label1;
        private Label labelMesesDoAno;
        private Label labelAnoAtualX;
    }
}