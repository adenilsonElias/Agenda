using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Controller
{
    public class ContatoController
    {
        private Model.Context Conn;
        public ContatoController(Model.Context conn)
        {
            this.Conn = conn;
        }
        public bool AddContato(Model.Contato contato)
        {
            try
            {
                this.Conn.Contatos.Add(contato);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public int GetId()
        {
            var last = this.Conn.Contatos.Last();
            return last.Id;
        }

        public void Save()
        {
            this.Conn.SaveChanges();
        }
    }
}
