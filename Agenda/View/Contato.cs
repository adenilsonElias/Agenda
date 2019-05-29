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
    public partial class Contato : Form
    {
        private Agenda back;
        private Model.Context conn;
        private int Id;
        public Contato(Agenda back, Model.Context conn,int id)
        {
            InitializeComponent();
            this.back = back;
            this.conn = conn;
            this.Id = id;
            MostraContato();
            LoadData();
        }

        private void MostraContato()
        {
            var contato = this.conn.Contatos.Where(s => s.Id == this.Id).ToList()[0];
            this.TextBoxNome.Text = contato.Nome;
            this.TexBoxDescricao.Text = contato.Descricao;
        }

        private void MostrarNumeros()
        {
            var numeros = this.conn.Telefones.Where(s => s.Id_contato == Id).ToList();
            var data = new DataTable();
            data.Columns.Add("Numero",typeof(string));
            data.Columns.Add("Tipo", typeof(string));
            foreach (var numero in numeros)
            {
                data.Rows.Add(numero.Numero, numero.Tipo);
            }
            this.dataGridView.DataSource = data;
        }
        private void MostrarFixo()
        {
            var fixo = this.conn.Telefones.Where(s => s.Id_contato == Id && s.Tipo == "Fixo").ToList();
            var data = new DataTable();
            data.Columns.Add("Numero", typeof(string));
            data.Columns.Add("Tipo", typeof(string));
            foreach (var numero in fixo)
            {
                data.Rows.Add(numero.Numero, numero.Tipo);
            }
            this.dataGridView.DataSource = data;
        }
        private void MostrarMovel()
        {
            var movel = this.conn.Telefones.Where(s => s.Id_contato == Id && s.Tipo == "Movel").ToList();
            var data = new DataTable();
            data.Columns.Add("Numero", typeof(string));
            data.Columns.Add("Tipo", typeof(string));
            foreach (var numero in movel)
            {
                data.Rows.Add(numero.Numero, numero.Tipo);
            }
            this.dataGridView.DataSource = data;
        }
        private void MostrarEmail()
        {
            var emails = this.conn.Emails.Where(s => s.Id_contato == Id).ToList();
            var data = new DataTable();
            data.Columns.Add("Email", typeof(string));
            foreach (var email in emails)
            {
                data.Rows.Add(email.E_mail);
            }
            this.dataGridView.DataSource = data;
        }

        private void LoadData()
        {
            if (this.radioButtonNumbers.Checked)
            {
                MostrarNumeros();
            }
            else if (this.radioButtonFixo.Checked)
            {
                MostrarFixo();
            }
            else if (this.radioButtonMovel.Checked)
            {
                MostrarMovel();
            }
            else if (this.radioButtonEmail.Checked)
            {
                MostrarEmail();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contato_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.back.Show();
        }
    }
}
