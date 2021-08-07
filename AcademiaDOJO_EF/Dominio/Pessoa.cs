using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Dominio
{
    public abstract class Pessoa
    {
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(14)]
        public string Telefone { get; set; }
        [MaxLength(14) , Key]
        public string CPF { get; set; }
    }
}
