﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    [Table("Fixo")]
    public class Fixo:Telefone
    {
        public string Numero { get; set; }
    }
}
