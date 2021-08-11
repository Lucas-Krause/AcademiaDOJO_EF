using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Dominio
{
    public class Professor : Pessoa
    {
        [MaxLength(20)]
        public string Turno { get; set; }
        public double SalarioHora { get; set; }

        public Professor Clone()
        {
            var professor = new Professor()
            {
               CPF = this.CPF,
               Nome = this.Nome,
               Telefone = this.Telefone,
               Turno = this.Turno,
               SalarioHora = this.SalarioHora
            };
            return professor;
        }

        public void FromProfessor(Professor professor)
        {
            this.Nome = professor.Nome;
            this.CPF = professor.CPF;
            this.Telefone = professor.Telefone;
            this.Turno = professor.Turno;
            this.SalarioHora = professor.SalarioHora;
        }
    }
}
