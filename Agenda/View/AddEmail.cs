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
    public partial class AddEmail : Form
    {
        private Agenda back;
        private Controller.EmailController controller;
        public AddEmail(Agenda back,Controller.EmailController controller)
        {
            InitializeComponent();
            this.back = back;
            this.controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            var email = new Model.Email()
            {
                E_mail = this.EmailTextBox.Text,
            };
            controller.AddEmail(email);
            MessageBox.Show("Email adicionado com sucesso", "sucesso");
            back.IncrementEmail();
            back.ShowAtualiza();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CloseW(object sender, FormClosedEventArgs e)
        {
            this.back.Show();
        }
    }
}
