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
    public partial class remNumero : Form
    {
        private Controller.TelefoneController Contro;
        private Agenda back;
        public remNumero(Controller.TelefoneController contro,Agenda back)
        {
            InitializeComponent();
            this.Contro = contro;
            loadPhones();
            this.back = back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var linha = this.TelefoneView.SelectedRows;
            var coluna = linha[0].Cells;
            var telefones = Contro.getTelefones();
            foreach(var telefone in telefones)
            {
                if (telefone.Numero == coluna[0].Value.ToString())
                {
                    telefones.Remove(telefone);
                    break;
                }
            }
            this.Contro.setTelefones(telefones);
            MessageBox.Show("Deletado com sucesso", "sucesso");
            this.back.decrementCont();
            this.back.ShowAtualiza();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void loadPhones()
        {
            var data = new DataTable();
            data.Columns.Add("Telefone", typeof(string));
            data.Columns.Add("tipo", typeof(string));

            foreach (var telefones in this.Contro.getTelefones())
            {
                data.Rows.Add(telefones.Numero,telefones.Tipo);
            }
            this.TelefoneView.DataSource = data;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelefoneView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void remNumero_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.back.Show();
        }
    }
}
