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
            cbxVezesSemana.SelectedIndex = modalidade.VezesSemana - 1;
            txtNomeModalidade.DataBindings.Add("Text", modalidade, "Nome");
            txtPrecoHoraModalidade.DataBindings.Add("Text", modalidade, "PrecoHora");
            cbxVezesSemana.DataBindings.Add("SelectedItem", modalidade, "VezesSemana");
            professorBindingSource.DataSource = new AcademiaContext().Professores.ToList();

            txtNomeModalidade.Enabled = String.IsNullOrEmpty(modalidade.Nome);
            SelecionaProfessorAtual();
        }

        private void SelecionaProfessorAtual()
        {
            foreach (var item in cbxProfessor.Items)
            {
                var _modalidade = item as Modalidade;
                if (_modalidade is null) return;
                if (_modalidade.Professor.CPF == modalidade.Professor.CPF)
                {
                    cbxProfessor.SelectedItem = item;
                }
            }
        }

        private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            modalidade.Professor = cbxProfessor.SelectedItem as Professor;
        }
    }
}
