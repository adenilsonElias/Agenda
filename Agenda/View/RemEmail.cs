using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class RemEmail : Form
    {
        private Agenda back;
        private Controller.EmailController controller;
        public RemEmail(Agenda back, Controller.EmailController controller)
        {
            InitializeComponent();
            this.back = back;
            this.controller = controller;
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var linha = this.dataGridViewEmail.SelectedCells;
            MessageBox.Show(linha.Count.ToString());
            var emails = this.controller.GetEmails();
            foreach (var email in emails)
            {
                if(email.E_mail == linha[0].Value.ToString())
                {
                    emails.Remove(email);
                    break;
                }
            }
            this.controller.SetEmails(emails);
            MessageBox.Show("Email removido com sucesso", "Sucesso");
            this.back.DecreamentEmail();
            this.back.ShowAtualiza();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadTable()
        {
            var table = new DataTable();
            table.Columns.Add("Email");
            foreach(var email in controller.GetEmails())
            {
                table.Rows.Add(email.E_mail);
            }
            this.dataGridViewEmail.DataSource = table;
        }

        private void RemEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.back.Show();
        }
    }
}
