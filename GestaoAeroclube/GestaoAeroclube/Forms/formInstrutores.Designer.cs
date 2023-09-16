namespace GestaoAeroclube.Forms
{
    partial class formInstrutores
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
            this.tabelaAeronaves = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasVoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Associado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAssociado = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbHorasVoo = new System.Windows.Forms.TextBox();
            this.tbCHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCHTRemove = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAeronaves)).BeginInit();
            this.SuspendLayout();
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
            this.Associado});
            this.tabelaAeronaves.Location = new System.Drawing.Point(21, 23);
            this.tabelaAeronaves.Name = "tabelaAeronaves";
            this.tabelaAeronaves.Size = new System.Drawing.Size(582, 150);
            this.tabelaAeronaves.TabIndex = 2;
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
            // Associado
            // 
            this.Associado.HeaderText = "Associado";
            this.Associado.Name = "Associado";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(18, 192);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 17);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHT";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Horas Voo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Associado";
            // 
            // tbAssociado
            // 
            this.tbAssociado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAssociado.FormattingEnabled = true;
            this.tbAssociado.Items.AddRange(new object[] {
            "Monomotor",
            "Bimotor"});
            this.tbAssociado.Location = new System.Drawing.Point(121, 287);
            this.tbAssociado.Name = "tbAssociado";
            this.tbAssociado.Size = new System.Drawing.Size(121, 21);
            this.tbAssociado.TabIndex = 11;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Location = new System.Drawing.Point(121, 192);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(121, 20);
            this.tbNome.TabIndex = 12;
            // 
            // tbHorasVoo
            // 
            this.tbHorasVoo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHorasVoo.Location = new System.Drawing.Point(121, 254);
            this.tbHorasVoo.Name = "tbHorasVoo";
            this.tbHorasVoo.Size = new System.Drawing.Size(121, 20);
            this.tbHorasVoo.TabIndex = 13;
            // 
            // tbCHT
            // 
            this.tbCHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCHT.Location = new System.Drawing.Point(121, 222);
            this.tbCHT.Name = "tbCHT";
            this.tbCHT.Size = new System.Drawing.Size(121, 20);
            this.tbCHT.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(413, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "CHT";
            // 
            // tbCHTRemove
            // 
            this.tbCHTRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCHTRemove.Location = new System.Drawing.Point(473, 189);
            this.tbCHTRemove.Name = "tbCHTRemove";
            this.tbCHTRemove.Size = new System.Drawing.Size(121, 20);
            this.tbCHTRemove.TabIndex = 16;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(23, 335);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(134, 335);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 23);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.Location = new System.Drawing.Point(416, 220);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(178, 23);
            this.btnRemover.TabIndex = 19;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // formInstrutores
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
            this.Controls.Add(this.tbAssociado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tabelaAeronaves);
            this.Name = "formInstrutores";
            this.Text = "formInstrutores";
            this.Load += new System.EventHandler(this.formInstrutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaAeronaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasVoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Associado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tbAssociado;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbHorasVoo;
        private System.Windows.Forms.TextBox tbCHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCHTRemove;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
    }
}