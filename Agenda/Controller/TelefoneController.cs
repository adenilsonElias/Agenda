using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Controller
{
    public class TelefoneController
    {
        private ICollection<Model.Telefone> telefones;
        private Model.Context Conn;
        public TelefoneController(Model.Context conn)
        {
            this.Conn = conn;
            this.telefones = new Collection<Model.Telefone>();
        }

        public ICollection<Model.Telefone> getTelefones()
        {
            return this.telefones;
        }
        public void setTelefones(ICollection<Model.Telefone> telefones)
        {
            this.telefones = telefones;
        }
        public void cleanNubers()
        {
            this.telefones.Clear();
        }
        public bool AddTelefone(Model.Telefone telefone)
        {
            try
            {
                this.telefones.Add(telefone);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro " + exception.ToString());
                return false;
            }
        }
        public bool AddIdContatos(int id)
        {
            try
            {
                Console.WriteLine(this.telefones.Count);
                foreach (var e in this.telefones)
                {
                    e.Id_contato = id;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveNumbers()
        {
            foreach(var e in this.telefones)
            {
                this.Conn.Telefones.Add(e);
            }
            return true;
        }
    }
}
