namespace Agenda.View
{
    partial class AddEmail
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
            this.ButtonAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAdicionar
            // 
            this.ButtonAdicionar.Location = new System.Drawing.Point(11, 60);
            this.ButtonAdicionar.Name = "ButtonAdicionar";
            this.ButtonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdicionar.TabIndex = 0;
            this.ButtonAdicionar.Text = "Adicionar";
            this.ButtonAdicionar.UseVisualStyleBackColor = true;
            this.ButtonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 23);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(303, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(92, 60);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // AddEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 88);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAdicionar);
            this.Name = "AddEmail";
            this.Text = "AddEmail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseW);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button Cancelar;
    }
}