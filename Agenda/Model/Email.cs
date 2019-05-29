using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class Email
    {
        [Key]
        public string E_mail { get; set; }
        public int Id_contato { get; set; }
        [ForeignKey(nameof(Id_contato))]
        public virtual Contato Contato { get; set; } 
    }
}
