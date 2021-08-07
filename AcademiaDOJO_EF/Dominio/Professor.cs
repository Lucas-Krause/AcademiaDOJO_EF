using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Dominio
{
    public class Professor:Pessoa
    {
        [MaxLength(20)]
        public string Turno { get; set; }
        public double SalarioHora { get; set; }
          
    }
}
