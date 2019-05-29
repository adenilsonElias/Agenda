namespace Agenda.View
{
    partial class RemEmail
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
            this.dataGridViewEmail = new System.Windows.Forms.DataGridView();
            this.Remover = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmail
            // 
            this.dataGridViewEmail.AllowUserToAddRows = false;
            this.dataGridViewEmail.AllowUserToDeleteRows = false;
            this.dataGridViewEmail.AllowUserToResizeColumns = false;
            this.dataGridViewEmail.AllowUserToResizeRows = false;
            this.dataGridViewEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewEmail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmail.GridColor = System.Drawing.Color.Black;
            this.dataGridViewEmail.Location = new System.Drawing.Point(10, 12);
            this.dataGridViewEmail.MultiSelect = false;
            this.dataGridViewEmail.Name = "dataGridViewEmail";
            this.dataGridViewEmail.ReadOnly = true;
            this.dataGridViewEmail.Size = new System.Drawing.Size(240, 397);
            this.dataGridViewEmail.TabIndex = 0;
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(10, 415);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(120, 23);
            this.Remover.TabIndex = 1;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(136, 415);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(114, 23);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // RemEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.dataGridViewEmail);
            this.Name = "RemEmail";
            this.Text = "RemEmail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemEmail_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmail;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button Cancelar;
    }
}