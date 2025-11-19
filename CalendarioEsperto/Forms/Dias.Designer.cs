namespace CalendarioEsperto
{
    partial class Dias
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dias));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelAno = new Label();
            flowLayoutPanelDias = new FlowLayoutPanel();
            labelMes = new Label();
            buttonAnterior = new Button();
            buttonProximo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(15, 91);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 1;
            label1.Text = "Domingo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(101, 91);
            label2.Name = "label2";
            label2.Size = new Size(62, 16);
            label2.TabIndex = 2;
            label2.Text = "Segunda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(187, 91);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 3;
            label3.Text = "Terça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(273, 91);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 4;
            label4.Text = "Quarta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(359, 91);
            label5.Name = "label5";
            label5.Size = new Size(45, 16);
            label5.TabIndex = 5;
            label5.Text = "Quinta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(445, 91);
            label6.Name = "label6";
            label6.Size = new Size(41, 16);
            label6.TabIndex = 6;
            label6.Text = "Sexta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(531, 91);
            label7.Name = "label7";
            label7.Size = new Size(56, 16);
            label7.TabIndex = 7;
            label7.Text = "Sabádo";
            // 
            // labelAno
            // 
            labelAno.AutoSize = true;
            labelAno.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAno.Location = new Point(15, 22);
            labelAno.Name = "labelAno";
            labelAno.Size = new Size(40, 18);
            labelAno.TabIndex = 8;
            labelAno.Text = "0000";
            labelAno.Click += labelAno_Click;
            // 
            // flowLayoutPanelDias
            // 
            flowLayoutPanelDias.Location = new Point(12, 123);
            flowLayoutPanelDias.Name = "flowLayoutPanelDias";
            flowLayoutPanelDias.Size = new Size(605, 542);
            flowLayoutPanelDias.TabIndex = 0;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMes.Location = new Point(101, 22);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(40, 18);
            labelMes.TabIndex = 9;
            labelMes.Text = "0000";
            labelMes.Click += labelMes_Click;
            // 
            // buttonAnterior
            // 
            buttonAnterior.Location = new Point(15, 56);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(75, 23);
            buttonAnterior.TabIndex = 10;
            buttonAnterior.Text = "Anterior";
            buttonAnterior.UseVisualStyleBackColor = true;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // buttonProximo
            // 
            buttonProximo.Location = new Point(96, 56);
            buttonProximo.Name = "buttonProximo";
            buttonProximo.Size = new Size(75, 23);
            buttonProximo.TabIndex = 11;
            buttonProximo.Text = "Proximo";
            buttonProximo.UseVisualStyleBackColor = true;
            buttonProximo.Click += buttonProximo_Click;
            // 
            // Dias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 671);
            Controls.Add(buttonProximo);
            Controls.Add(buttonAnterior);
            Controls.Add(labelMes);
            Controls.Add(labelAno);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelDias);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Dias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dias";
            Load += Dias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelAno;
        private FlowLayoutPanel flowLayoutPanelDias;
        private Label labelMes;
        private Button buttonAnterior;
        private Button buttonProximo;
    }
}
