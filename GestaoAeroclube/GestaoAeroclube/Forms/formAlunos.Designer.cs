namespace GestaoAeroclube.Forms
{
    partial class formAlunos
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbCHTRemove = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCHT = new System.Windows.Forms.TextBox();
            this.tbHorasVoo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbPendencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabelaAeronaves = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasVoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.Location = new System.Drawing.Point(418, 228);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(178, 23);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(136, 343);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 23);
            this.btnAtualizar.TabIndex = 32;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(25, 343);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 23);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbCHTRemove
            // 
            this.tbCHTRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCHTRemove.Location = new System.Drawing.Point(475, 197);
            this.tbCHTRemove.Name = "tbCHTRemove";
            this.tbCHTRemove.Size = new System.Drawing.Size(121, 20);
            this.tbCHTRemove.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(415, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "CHT";
            // 
            // tbCHT
            // 
            this.tbCHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCHT.Location = new System.Drawing.Point(123, 230);
            this.tbCHT.Name = "tbCHT";
            this.tbCHT.Size = new System.Drawing.Size(121, 20);
            this.tbCHT.TabIndex = 28;
            // 
            // tbHorasVoo
            // 
            this.tbHorasVoo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHorasVoo.Location = new System.Drawing.Point(123, 262);
            this.tbHorasVoo.Name = "tbHorasVoo";
            this.tbHorasVoo.Size = new System.Drawing.Size(121, 20);
            this.tbHorasVoo.TabIndex = 27;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Location = new System.Drawing.Point(123, 200);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(121, 20);
            this.tbNome.TabIndex = 26;
            // 
            // tbPendencia
            // 
            this.tbPendencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPendencia.FormattingEnabled = true;
            this.tbPendencia.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tbPendencia.Location = new System.Drawing.Point(123, 295);
            this.tbPendencia.Name = "tbPendencia";
            this.tbPendencia.Size = new System.Drawing.Size(121, 21);
            this.tbPendencia.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pendência";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Horas Voo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "CHT";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(20, 200);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 17);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome";
            // 
            // tabelaAeronaves
            // 
            this.tabelaAeronaves.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabelaAeronaves.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tabelaAeronaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaAeronaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CHT,
            this.HorasVoo,
            this.Pendencia});
            this.tabelaAeronaves.Location = new System.Drawing.Point(23, 31);
            this.tabelaAeronaves.Name = "tabelaAeronaves";
            this.tabelaAeronaves.Size = new System.Drawing.Size(582, 150);
            this.tabelaAeronaves.TabIndex = 20;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // CHT
            // 
            this.CHT.HeaderText = "CHT";
            this.CHT.Name = "CHT";
            this.CHT.Width = 200;
            // 
            // HorasVoo
            // 
            this.HorasVoo.HeaderText = "Horas Voo";
            this.HorasVoo.Name = "HorasVoo";
            // 
            // Pendencia
            // 
            this.Pendencia.HeaderText = "Pendência";
            this.Pendencia.Name = "Pendencia";
            // 
            // formAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbCHTRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCHT);
            this.Controls.Add(this.tbHorasVoo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbPendencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tabelaAeronaves);
            this.Name = "formAlunos";
            this.Text = "formAlunos";
            this.Load += new System.EventHandler(this.formAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbCHTRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCHT;
        private System.Windows.Forms.TextBox tbHorasVoo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox tbPendencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView tabelaAeronaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasVoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendencia;
    }
}