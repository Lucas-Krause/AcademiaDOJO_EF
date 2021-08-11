using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AcademiaDOJO_EF.Dominio
{
    public class Modalidade
    {
        [MaxLength(100), Key]
        public string Nome { get; set; }
        public int VezesSemana { get; set; }
        public double PrecoHora { get; set; }     
        
        public Modalidade Clone()
        {
            var modalidade = new Modalidade()
            {
                Nome = this.Nome,
                VezesSemana = this.VezesSemana,
                PrecoHora = this.PrecoHora
            };
            return modalidade;
        }

        public void FromModalidade(Modalidade modalidade)
        {
            this.Nome = modalidade.Nome;
            this.VezesSemana = modalidade.VezesSemana;
            this.PrecoHora = modalidade.PrecoHora;
        }
    }
}
