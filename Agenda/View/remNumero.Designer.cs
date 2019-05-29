namespace Agenda
{
    partial class remNumero
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
            this.TelefoneView = new System.Windows.Forms.DataGridView();
            this.Remover = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TelefoneView)).BeginInit();
            this.SuspendLayout();
            // 
            // TelefoneView
            // 
            this.TelefoneView.AllowUserToAddRows = false;
            this.TelefoneView.AllowUserToDeleteRows = false;
            this.TelefoneView.AllowUserToResizeColumns = false;
            this.TelefoneView.AllowUserToResizeRows = false;
            this.TelefoneView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TelefoneView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TelefoneView.BackgroundColor = System.Drawing.Color.White;
            this.TelefoneView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefoneView.GridColor = System.Drawing.Color.Black;
            this.TelefoneView.Location = new System.Drawing.Point(12, 12);
            this.TelefoneView.MultiSelect = false;
            this.TelefoneView.Name = "TelefoneView";
            this.TelefoneView.ReadOnly = true;
            this.TelefoneView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TelefoneView.Size = new System.Drawing.Size(176, 401);
            this.TelefoneView.TabIndex = 0;
            this.TelefoneView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TelefoneView_CellContentClick);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(12, 415);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(82, 23);
            this.Remover.TabIndex = 1;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(100, 415);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(88, 23);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // remNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.TelefoneView);
            this.Name = "remNumero";
            this.Text = "MostraTelefones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.remNumero_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TelefoneView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TelefoneView;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button Cancelar;
    }
}