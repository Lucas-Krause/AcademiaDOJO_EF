using AcademiaDOJO_EF.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDOJO_EF
{
    public partial class FormModalidade : Form
    {
        Modalidade modalidade;
        public FormModalidade(Modalidade _modalidade)
        {
            InitializeComponent();
            modalidade = _modalidade;
        }

        private void FormModalidade_Load(object sender, EventArgs e)
        {
            txtNomeModalidade.DataBindings.Add("Text", modalidade, "Nome");
            txtPrecoHoraModalidade.DataBindings.Add("Text", modalidade, "PrecoHora");
            txtVezesSemanaModalidade.DataBindings.Add("Text", modalidade, "VezesSemana");

            txtNomeModalidade.Enabled = String.IsNullOrEmpty(modalidade.Nome);
            professorBindingSource.DataSource = new AcademiaContext().Professores.ToList();

            cbxProfessor.SelectedItem = modalidade.Professor;
        }

        private void cbxProfessor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var professor = cbxProfessor.SelectedItem as Professor;
            if (professor == null) return;
            modalidade.Professor = professor;
        }
    }
}
