using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Controller;

namespace Agenda
{
    public partial class Agenda : Form
    {
        public TelefoneController telefoneController { get; }
        public EmailController EmailController { get; }
        public Model.Context conexao;
        private int cont;
        private int email;

        public void incrementCont()
        {
            this.cont += 1;
        }

        public void decrementCont()
        {
            this.cont -= 1;
        }

        public void CleanScreen()
        {
            this.Nome_Contato.Text = "";
            this.Descricao_Contato.Text = "";
            this.QuantTelefone.Text = "0";
            this.QuantEmail.Text = "0";
            this.telefoneController.cleanNubers();
            this.EmailController.CleanEmails();
            this.cont = 0;
            this.email = 0;
            DeactivateErrorNumber();
        }
        public Agenda()
        {
            InitializeComponent();
            this.conexao = new Model.Context();
            this.telefoneController = new TelefoneController(this.conexao);
            this.EmailController = new EmailController(this.conexao);
            this.cont = 0;
            this.email = 0;
            this.QuantTelefone.Text = cont.ToString();
            this.QuantEmail.Text = email.ToString();
            this.buttonRemover.Enabled = false;
            this.RemoverEmail.Enabled = false;
            this.Detalhe.Enabled = false;
        }

        public void IncrementEmail()
        {
            this.email += 1;
        }

        public void DecreamentEmail()
        {
            this.email -= 1;
        }
        public void ActvateErrorNumber()
        {
            this.ErroNumero.Visible = true;
        }
        public void DeactivateErrorNumber()
        {
            this.ErroNumero.Visible = false;
        }
        public void ActivateErrorEmail()
        {
            this.errorEmail.Visible = true;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var add = new addNumero(this);
            add.Show();
        }
        public void ShowAtualiza()
        {
            this.QuantTelefone.Text = cont.ToString();
            this.QuantEmail.Text = email.ToString();
            if(this.cont == 0)
            {
                this.buttonRemover.Enabled = false;
            }
            else
            {
                this.buttonRemover.Enabled = true;
            }
            if (this.email == 0)
            {
                this.RemoverEmail.Enabled = false;
            }
            else
            {
                this.RemoverEmail.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mostrarTelefone = new remNumero(this.telefoneController, this);
            mostrarTelefone.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.Nome_Contato.Text == "")
            {
                MessageBox.Show("Insira o nome do contato", "Erro");
                return;
            }
            var contatoContro = new Controller.ContatoController(this.conexao);
            var contato = new Model.Contato()
            {
                Nome = this.Nome_Contato.Text,
                Descricao = this.Descricao_Contato.Text
            };
            contatoContro.AddContato(contato);
            int lastid = contatoContro.GetId();
            telefoneController.AddIdContatos(lastid+1);
            EmailController.AddIdEmail(lastid + 1);
            EmailController.SaveEmails();
            telefoneController.SaveNumbers();
            try
            {
                conexao.SaveChanges();
                CleanScreen();
                MessageBox.Show("Contato Adicionado com sucesso", "Sucesso");
                LoadTable();
                this.Detalhe.Enabled = true;
            }
            catch(Exception Exception)
            {
                MessageBox.Show(Exception.ToString(),"Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CleanScreen();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadTable();
            this.Detalhe.Enabled = true;
        }

        public void LoadTable()
        {
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("descricao", typeof(string));
            foreach (var contato in this.conexao.Contatos)
            {
                table.Rows.Add(contato.Id, contato.Nome, contato.Descricao);
            }
            this.ContatosList.DataSource = table;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addEmail = new View.AddEmail(this, this.EmailController);
            addEmail.Show();
            this.Hide();
        }

        private void RemoverEmail_Click(object sender, EventArgs e)
        {
            var removerEmail = new View.RemEmail(this, this.EmailController);
            removerEmail.Show();
            this.Hide();
        }

        private void Detalhe_Click(object sender, EventArgs e)
        {
            var data = this.ContatosList.SelectedRows[0].Cells[0].Value.ToString();
            var id = int.Parse(data);
            var detalhes = new View.Contato(this, this.conexao, id);
            detalhes.Show();
            this.Hide();
        }


    }
}
