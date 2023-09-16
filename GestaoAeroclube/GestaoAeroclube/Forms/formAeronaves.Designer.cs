namespace GestaoAeroclube.Forms
{
    partial class formAeronaves
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
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manutencao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCategoriaMotor = new System.Windows.Forms.ComboBox();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMotor = new System.Windows.Forms.TextBox();
            this.dtManutencao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbHorasVoo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.Fabricante,
            this.Modelo,
            this.Matricula,
            this.Horas,
            this.Motor,
            this.Manutencao,
            this.Categoria});
            this.tabelaAeronaves.Location = new System.Drawing.Point(19, 23);
            this.tabelaAeronaves.Name = "tabelaAeronaves";
            this.tabelaAeronaves.Size = new System.Drawing.Size(582, 150);
            this.tabelaAeronaves.TabIndex = 1;
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            // 
            // Motor
            // 
            this.Motor.HeaderText = "Motor(es)";
            this.Motor.Name = "Motor";
            // 
            // Manutencao
            // 
            this.Manutencao.HeaderText = "Manutenção";
            this.Manutencao.Name = "Manutencao";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // tbCategoriaMotor
            // 
            this.tbCategoriaMotor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCategoriaMotor.FormattingEnabled = true;
            this.tbCategoriaMotor.Items.AddRange(new object[] {
            "Monomotor",
            "Bimotor"});
            this.tbCategoriaMotor.Location = new System.Drawing.Point(174, 221);
            this.tbCategoriaMotor.Name = "tbCategoriaMotor";
            this.tbCategoriaMotor.Size = new System.Drawing.Size(121, 21);
            this.tbCategoriaMotor.TabIndex = 4;
            // 
            // tbFabricante
            // 
            this.tbFabricante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFabricante.Location = new System.Drawing.Point(174, 248);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(121, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria de Motor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fabricante";
            // 
            // tbModelo
            // 
            this.tbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbModelo.Location = new System.Drawing.Point(174, 274);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(121, 20);
            this.tbModelo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Matricula";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMatricula.Location = new System.Drawing.Point(174, 300);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(121, 20);
            this.tbMatricula.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Motor(es)";
            this.label5.Click += new System.EventHandler(this.formAeronaves_Load);
            // 
            // tbMotor
            // 
            this.tbMotor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMotor.Location = new System.Drawing.Point(174, 352);
            this.tbMotor.Name = "tbMotor";
            this.tbMotor.Size = new System.Drawing.Size(121, 20);
            this.tbMotor.TabIndex = 13;
            // 
            // dtManutencao
            // 
            this.dtManutencao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtManutencao.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dtManutencao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dtManutencao.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dtManutencao.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtManutencao.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dtManutencao.Location = new System.Drawing.Point(368, 248);
            this.dtManutencao.Name = "dtManutencao";
            this.dtManutencao.Size = new System.Drawing.Size(233, 20);
            this.dtManutencao.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(365, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ultima manutenção";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.Location = new System.Drawing.Point(368, 352);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbHorasVoo
            // 
            this.tbHorasVoo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHorasVoo.Location = new System.Drawing.Point(174, 326);
            this.tbHorasVoo.Name = "tbHorasVoo";
            this.tbHorasVoo.Size = new System.Drawing.Size(121, 20);
            this.tbHorasVoo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(16, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Horas voo";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(15, 188);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Adicionar aeronave:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.Location = new System.Drawing.Point(449, 352);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.Location = new System.Drawing.Point(530, 352);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // formAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbHorasVoo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtManutencao);
            this.Controls.Add(this.tbMotor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.tbCategoriaMotor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabelaAeronaves);
            this.Name = "formAeronaves";
            this.Text = "formAeronaves";
            this.Load += new System.EventHandler(this.formAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabelaAeronaves;
        private System.Windows.Forms.ComboBox tbCategoriaMotor;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMotor;
        private System.Windows.Forms.DateTimePicker dtManutencao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbHorasVoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manutencao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
    }
}