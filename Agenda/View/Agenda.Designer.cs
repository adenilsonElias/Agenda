namespace Agenda
{
    partial class Agenda
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
            this.ContatosList = new System.Windows.Forms.DataGridView();
            this.Nome_Contato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Descricao_Contato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantEmail = new System.Windows.Forms.TextBox();
            this.AdicionarEmail = new System.Windows.Forms.Button();
            this.RemoverEmail = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ErroNumero = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.Carregar = new System.Windows.Forms.Button();
            this.Detalhe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContatosList)).BeginInit();
            this.SuspendLayout();
            // 
            // ContatosList
            // 
            this.ContatosList.AllowUserToAddRows = false;
            this.ContatosList.AllowUserToDeleteRows = false;
            this.ContatosList.AllowUserToResizeColumns = false;
            this.ContatosList.AllowUserToResizeRows = false;
            this.ContatosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContatosList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ContatosList.BackgroundColor = System.Drawing.Color.White;
            this.ContatosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContatosList.GridColor = System.Drawing.Color.Black;
            this.ContatosList.Location = new System.Drawing.Point(218, 12);
            this.ContatosList.MultiSelect = false;
            this.ContatosList.Name = "ContatosList";
            this.ContatosList.ReadOnly = true;
            this.ContatosList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ContatosList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContatosList.Size = new System.Drawing.Size(431, 401);
            this.ContatosList.TabIndex = 0;
            // 
            // Nome_Contato
            // 
            this.Nome_Contato.Location = new System.Drawing.Point(12, 31);
            this.Nome_Contato.Name = "Nome_Contato";
            this.Nome_Contato.Size = new System.Drawing.Size(200, 20);
            this.Nome_Contato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Descricao_Contato
            // 
            this.Descricao_Contato.Location = new System.Drawing.Point(12, 70);
            this.Descricao_Contato.Multiline = true;
            this.Descricao_Contato.Name = "Descricao_Contato";
            this.Descricao_Contato.Size = new System.Drawing.Size(200, 95);
            this.Descricao_Contato.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(137, 225);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 9;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero(s)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // QuantTelefone
            // 
            this.QuantTelefone.Location = new System.Drawing.Point(12, 199);
            this.QuantTelefone.Name = "QuantTelefone";
            this.QuantTelefone.ReadOnly = true;
            this.QuantTelefone.Size = new System.Drawing.Size(35, 20);
            this.QuantTelefone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email(s)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // QuantEmail
            // 
            this.QuantEmail.Location = new System.Drawing.Point(12, 304);
            this.QuantEmail.Name = "QuantEmail";
            this.QuantEmail.ReadOnly = true;
            this.QuantEmail.Size = new System.Drawing.Size(35, 20);
            this.QuantEmail.TabIndex = 13;
            // 
            // AdicionarEmail
            // 
            this.AdicionarEmail.Location = new System.Drawing.Point(137, 304);
            this.AdicionarEmail.Name = "AdicionarEmail";
            this.AdicionarEmail.Size = new System.Drawing.Size(75, 23);
            this.AdicionarEmail.TabIndex = 14;
            this.AdicionarEmail.Text = "Adicionar";
            this.AdicionarEmail.UseVisualStyleBackColor = true;
            this.AdicionarEmail.Click += new System.EventHandler(this.button3_Click);
            // 
            // RemoverEmail
            // 
            this.RemoverEmail.Location = new System.Drawing.Point(137, 333);
            this.RemoverEmail.Name = "RemoverEmail";
            this.RemoverEmail.Size = new System.Drawing.Size(75, 23);
            this.RemoverEmail.TabIndex = 15;
            this.RemoverEmail.Text = "Remover";
            this.RemoverEmail.UseVisualStyleBackColor = true;
            this.RemoverEmail.Click += new System.EventHandler(this.RemoverEmail_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Limpar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ErroNumero
            // 
            this.ErroNumero.AutoSize = true;
            this.ErroNumero.BackColor = System.Drawing.SystemColors.Control;
            this.ErroNumero.ForeColor = System.Drawing.Color.Red;
            this.ErroNumero.Location = new System.Drawing.Point(105, 204);
            this.ErroNumero.Name = "ErroNumero";
            this.ErroNumero.Size = new System.Drawing.Size(26, 13);
            this.ErroNumero.TabIndex = 18;
            this.ErroNumero.Text = "Erro";
            this.ErroNumero.Visible = false;
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.BackColor = System.Drawing.SystemColors.Control;
            this.errorEmail.ForeColor = System.Drawing.Color.Red;
            this.errorEmail.Location = new System.Drawing.Point(105, 311);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(26, 13);
            this.errorEmail.TabIndex = 19;
            this.errorEmail.Text = "Erro";
            this.errorEmail.Visible = false;
            // 
            // Carregar
            // 
            this.Carregar.Location = new System.Drawing.Point(574, 415);
            this.Carregar.Name = "Carregar";
            this.Carregar.Size = new System.Drawing.Size(75, 23);
            this.Carregar.TabIndex = 20;
            this.Carregar.Text = "Carregar";
            this.Carregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Carregar.UseVisualStyleBackColor = true;
            this.Carregar.Click += new System.EventHandler(this.button7_Click);
            // 
            // Detalhe
            // 
            this.Detalhe.Location = new System.Drawing.Point(493, 415);
            this.Detalhe.Name = "Detalhe";
            this.Detalhe.Size = new System.Drawing.Size(75, 23);
            this.Detalhe.TabIndex = 21;
            this.Detalhe.Text = "Detalhe";
            this.Detalhe.UseVisualStyleBackColor = true;
            this.Detalhe.Click += new System.EventHandler(this.Detalhe_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(657, 443);
            this.Controls.Add(this.Detalhe);
            this.Controls.Add(this.Carregar);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.ErroNumero);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RemoverEmail);
            this.Controls.Add(this.AdicionarEmail);
            this.Controls.Add(this.QuantEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Descricao_Contato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome_Contato);
            this.Controls.Add(this.ContatosList);
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.ContatosList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContatosList;
        private System.Windows.Forms.TextBox Nome_Contato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descricao_Contato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantEmail;
        private System.Windows.Forms.Button AdicionarEmail;
        private System.Windows.Forms.Button RemoverEmail;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label ErroNumero;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Button Carregar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Detalhe;
    }
}

