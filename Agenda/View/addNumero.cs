using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class addNumero : Form
    {
        private Agenda back;
        public addNumero(Agenda d)
        {
            InitializeComponent();
            this.back = d;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool teste = false;
            if (radioFixo.Checked)
            {
                var newNumber = new Model.Telefone()
                {
                    Numero = textTelefone.Text,
                    Tipo = "Fixo"
                };
                teste = back.telefoneController.AddTelefone(newNumber);
            }
            else if (radioMovel.Checked)
            {
                var newNumber = new Model.Telefone()
                {
                    Numero = textTelefone.Text,
                    Tipo = "Movel"
                };
                Console.WriteLine(newNumber.Numero);
                teste = back.telefoneController.AddTelefone(newNumber);
            }
            Console.WriteLine(teste);
            if (!teste)
            {
                this.back.ActvateErrorNumber();
            }
            else
            {
                this.back.incrementCont();
                this.back.DeactivateErrorNumber();
            }
            this.back.ShowAtualiza();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addNumero_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.back.Show();
        }
    }
}
