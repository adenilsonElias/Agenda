namespace Agenda
{
    partial class addNumero
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
            this.radioFixo = new System.Windows.Forms.RadioButton();
            this.radioMovel = new System.Windows.Forms.RadioButton();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioFixo
            // 
            this.radioFixo.AutoSize = true;
            this.radioFixo.Location = new System.Drawing.Point(12, 52);
            this.radioFixo.Name = "radioFixo";
            this.radioFixo.Size = new System.Drawing.Size(44, 17);
            this.radioFixo.TabIndex = 0;
            this.radioFixo.TabStop = true;
            this.radioFixo.Text = "Fixo";
            this.radioFixo.UseVisualStyleBackColor = true;
            // 
            // radioMovel
            // 
            this.radioMovel.AutoSize = true;
            this.radioMovel.Location = new System.Drawing.Point(12, 75);
            this.radioMovel.Name = "radioMovel";
            this.radioMovel.Size = new System.Drawing.Size(54, 17);
            this.radioMovel.TabIndex = 1;
            this.radioMovel.TabStop = true;
            this.radioMovel.Text = "Movel";
            this.radioMovel.UseVisualStyleBackColor = true;
            this.radioMovel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(12, 26);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(153, 20);
            this.textTelefone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefone";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(12, 105);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 4;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(93, 105);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 132);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.radioMovel);
            this.Controls.Add(this.radioFixo);
            this.Name = "addNumero";
            this.Text = "addNumero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addNumero_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioFixo;
        private System.Windows.Forms.RadioButton radioMovel;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Cancelar;
    }
}