namespace Agenda.View
{
    partial class Contato
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TexBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.radioButtonNumbers = new System.Windows.Forms.RadioButton();
            this.radioButtonFixo = new System.Windows.Forms.RadioButton();
            this.radioButtonMovel = new System.Windows.Forms.RadioButton();
            this.radioButtonEmail = new System.Windows.Forms.RadioButton();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(222, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(276, 426);
            this.dataGridView.TabIndex = 0;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(12, 28);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(204, 20);
            this.TextBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // TexBoxDescricao
            // 
            this.TexBoxDescricao.Location = new System.Drawing.Point(12, 70);
            this.TexBoxDescricao.Multiline = true;
            this.TexBoxDescricao.Name = "TexBoxDescricao";
            this.TexBoxDescricao.Size = new System.Drawing.Size(204, 115);
            this.TexBoxDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(12, 415);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // radioButtonNumbers
            // 
            this.radioButtonNumbers.AutoSize = true;
            this.radioButtonNumbers.Checked = true;
            this.radioButtonNumbers.Location = new System.Drawing.Point(12, 191);
            this.radioButtonNumbers.Name = "radioButtonNumbers";
            this.radioButtonNumbers.Size = new System.Drawing.Size(67, 17);
            this.radioButtonNumbers.TabIndex = 6;
            this.radioButtonNumbers.TabStop = true;
            this.radioButtonNumbers.Text = "Numeros";
            this.radioButtonNumbers.UseVisualStyleBackColor = true;
            // 
            // radioButtonFixo
            // 
            this.radioButtonFixo.AutoSize = true;
            this.radioButtonFixo.Location = new System.Drawing.Point(12, 214);
            this.radioButtonFixo.Name = "radioButtonFixo";
            this.radioButtonFixo.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFixo.TabIndex = 7;
            this.radioButtonFixo.TabStop = true;
            this.radioButtonFixo.Text = "Fixo";
            this.radioButtonFixo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMovel
            // 
            this.radioButtonMovel.AutoSize = true;
            this.radioButtonMovel.Location = new System.Drawing.Point(12, 237);
            this.radioButtonMovel.Name = "radioButtonMovel";
            this.radioButtonMovel.Size = new System.Drawing.Size(54, 17);
            this.radioButtonMovel.TabIndex = 8;
            this.radioButtonMovel.TabStop = true;
            this.radioButtonMovel.Text = "Movel";
            this.radioButtonMovel.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.AutoSize = true;
            this.radioButtonEmail.Location = new System.Drawing.Point(12, 260);
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Size = new System.Drawing.Size(55, 17);
            this.radioButtonEmail.TabIndex = 9;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.Text = "Emails";
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(12, 283);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ButtonRefresh.TabIndex = 10;
            this.ButtonRefresh.Text = "Atualizar";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.radioButtonEmail);
            this.Controls.Add(this.radioButtonMovel);
            this.Controls.Add(this.radioButtonFixo);
            this.Controls.Add(this.radioButtonNumbers);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TexBoxDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.dataGridView);
            this.Name = "Contato";
            this.Text = "Contato";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contato_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TexBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.RadioButton radioButtonNumbers;
        private System.Windows.Forms.RadioButton radioButtonFixo;
        private System.Windows.Forms.RadioButton radioButtonMovel;
        private System.Windows.Forms.RadioButton radioButtonEmail;
        private System.Windows.Forms.Button ButtonRefresh;
    }
}