using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class Telefone
    {
        [Key]
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public int Id_contato { get; set; }
        [ForeignKey(nameof(Id_contato))]
        public virtual Contato Contato { get; set; }
        //public virtual ICollection<Fixo> Fixos { get; set; }
        //public virtual ICollection<Movel> Movels { get; set; }
    }
}
