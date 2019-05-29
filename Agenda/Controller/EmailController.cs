using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Controller
{
    public class EmailController
    {
        private Model.Context conn;
        private ICollection<Model.Email> emails;
        public EmailController(Model.Context conn)
        {
            this.conn = conn;
            this.emails = new Collection<Model.Email>();
        }

        public void CleanEmails()
        {
            this.emails.Clear();
        }
        public ICollection<Model.Email> GetEmails()
        {
            return this.emails;
        }

        public void SetEmails(ICollection<Model.Email> emails)
        {
            this.emails = emails;
        }
        public void AddEmail(Model.Email email)
        {
            this.emails.Add(email);
        }

        public void AddIdEmail(int id)
        {
            foreach(var email in this.emails)
            {
                email.Id_contato = id;
            }
        }

        public void SaveEmails()
        {
            foreach(var email in this.emails)
            {
                this.conn.Emails.Add(email);
            }
        }
    }
}
