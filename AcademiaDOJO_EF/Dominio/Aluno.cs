using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Dominio
{
    public class Aluno : Pessoa
    {
        public virtual Modalidade Modalidade { get; set; }

        public Aluno Clone()
        {
            var aluno = new Aluno()
            {
                CPF = this.CPF,
                Nome = this.Nome,
                Telefone = this.Telefone,
                Modalidade = this.Modalidade
            };
            return aluno;
        }

        public void FromAluno(Aluno aluno)
        {
            this.CPF = aluno.CPF;
            this.Nome = aluno.Nome;
            this.Telefone = aluno.Telefone;
            this.Modalidade = aluno.Modalidade;
        }
    }
}
