namespace GestaoAeroclube
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAluguel = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnInstrutores = new System.Windows.Forms.Button();
            this.btnAeronaves = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAux = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btnAluguel);
            this.panel1.Controls.Add(this.btnAlunos);
            this.panel1.Controls.Add(this.btnInstrutores);
            this.panel1.Controls.Add(this.btnAeronaves);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 515);
            this.panel1.TabIndex = 0;
            // 
            // btnAluguel
            // 
            this.btnAluguel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluguel.FlatAppearance.BorderSize = 0;
            this.btnAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluguel.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluguel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAluguel.Image = ((System.Drawing.Image)(resources.GetObject("btnAluguel.Image")));
            this.btnAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluguel.Location = new System.Drawing.Point(0, 260);
            this.btnAluguel.Name = "btnAluguel";
            this.btnAluguel.Size = new System.Drawing.Size(220, 60);
            this.btnAluguel.TabIndex = 5;
            this.btnAluguel.Text = "   Aluguel";
            this.btnAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAluguel.UseVisualStyleBackColor = true;
            this.btnAluguel.Click += new System.EventHandler(this.btnCombustivel_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlunos.FlatAppearance.BorderSize = 0;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlunos.Image")));
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.Location = new System.Drawing.Point(0, 200);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(220, 60);
            this.btnAlunos.TabIndex = 4;
            this.btnAlunos.Text = "   Alunos";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnInstrutores
            // 
            this.btnInstrutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstrutores.FlatAppearance.BorderSize = 0;
            this.btnInstrutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstrutores.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrutores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInstrutores.Image = ((System.Drawing.Image)(resources.GetObject("btnInstrutores.Image")));
            this.btnInstrutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstrutores.Location = new System.Drawing.Point(0, 140);
            this.btnInstrutores.Name = "btnInstrutores";
            this.btnInstrutores.Size = new System.Drawing.Size(220, 60);
            this.btnInstrutores.TabIndex = 3;
            this.btnInstrutores.Text = "   Instrutores";
            this.btnInstrutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstrutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstrutores.UseVisualStyleBackColor = true;
            this.btnInstrutores.Click += new System.EventHandler(this.btnInstrutores_Click);
            // 
            // btnAeronaves
            // 
            this.btnAeronaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAeronaves.FlatAppearance.BorderSize = 0;
            this.btnAeronaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAeronaves.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeronaves.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAeronaves.Image = ((System.Drawing.Image)(resources.GetObject("btnAeronaves.Image")));
            this.btnAeronaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAeronaves.Location = new System.Drawing.Point(0, 80);
            this.btnAeronaves.Name = "btnAeronaves";
            this.btnAeronaves.Size = new System.Drawing.Size(220, 60);
            this.btnAeronaves.TabIndex = 2;
            this.btnAeronaves.Text = "  Aeronaves";
            this.btnAeronaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAeronaves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAeronaves.UseVisualStyleBackColor = true;
            this.btnAeronaves.Click += new System.EventHandler(this.btnAeronaves_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 80);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 80);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(606, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 1;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(280, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlAux
            // 
            this.pnlAux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAux.Location = new System.Drawing.Point(220, 80);
            this.pnlAux.Name = "pnlAux";
            this.pnlAux.Size = new System.Drawing.Size(640, 435);
            this.pnlAux.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(860, 515);
            this.Controls.Add(this.pnlAux);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestão Aeroclube";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnInstrutores;
        private System.Windows.Forms.Button btnAeronaves;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel pnlAux;
        private System.Windows.Forms.Button btnAluguel;
    }
}

