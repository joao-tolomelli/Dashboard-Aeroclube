namespace GestaoAeroclube.Forms
{
    partial class formAluguel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbCHTInstrutor = new System.Windows.Forms.TextBox();
            this.tbHorasTotais = new System.Windows.Forms.TextBox();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.bntValorFinal = new System.Windows.Forms.Button();
            this.lblInfoAero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Matricula da aeronave:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "CHT do instrutor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Duração do aluguel (horas):";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMatricula.Location = new System.Drawing.Point(267, 20);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(146, 20);
            this.tbMatricula.TabIndex = 10;
            // 
            // tbCHTInstrutor
            // 
            this.tbCHTInstrutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCHTInstrutor.Location = new System.Drawing.Point(267, 61);
            this.tbCHTInstrutor.Name = "tbCHTInstrutor";
            this.tbCHTInstrutor.Size = new System.Drawing.Size(146, 20);
            this.tbCHTInstrutor.TabIndex = 11;
            // 
            // tbHorasTotais
            // 
            this.tbHorasTotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHorasTotais.Location = new System.Drawing.Point(267, 101);
            this.tbHorasTotais.Name = "tbHorasTotais";
            this.tbHorasTotais.Size = new System.Drawing.Size(146, 20);
            this.tbHorasTotais.TabIndex = 12;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValorFinal.Location = new System.Drawing.Point(264, 154);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(0, 17);
            this.lblValorFinal.TabIndex = 14;
            // 
            // bntValorFinal
            // 
            this.bntValorFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntValorFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bntValorFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntValorFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntValorFinal.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntValorFinal.ForeColor = System.Drawing.SystemColors.Window;
            this.bntValorFinal.Location = new System.Drawing.Point(15, 144);
            this.bntValorFinal.Name = "bntValorFinal";
            this.bntValorFinal.Size = new System.Drawing.Size(221, 37);
            this.bntValorFinal.TabIndex = 16;
            this.bntValorFinal.Text = "Valor final do aluguel:";
            this.bntValorFinal.UseVisualStyleBackColor = false;
            this.bntValorFinal.Click += new System.EventHandler(this.bntValorFinal_Click);
            // 
            // lblInfoAero
            // 
            this.lblInfoAero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfoAero.AutoSize = true;
            this.lblInfoAero.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfoAero.Location = new System.Drawing.Point(12, 196);
            this.lblInfoAero.Name = "lblInfoAero";
            this.lblInfoAero.Size = new System.Drawing.Size(80, 17);
            this.lblInfoAero.TabIndex = 17;
            this.lblInfoAero.Text = "Aeronave:";
            // 
            // formAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.lblInfoAero);
            this.Controls.Add(this.bntValorFinal);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.tbHorasTotais);
            this.Controls.Add(this.tbCHTInstrutor);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAluguel";
            this.Text = "formCombustivel";
            this.Load += new System.EventHandler(this.formAluguel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbCHTInstrutor;
        private System.Windows.Forms.TextBox tbHorasTotais;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Button bntValorFinal;
        private System.Windows.Forms.Label lblInfoAero;
    }
}