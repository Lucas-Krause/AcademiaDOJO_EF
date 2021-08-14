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
            using (var db = new AcademiaContext())
            {
                professorBindingSource.DataSource = db.Professores.ToList();
            }
            cbxProfessor.DataBindings.Add("SelectedItem", modalidade, "Professor");

            if (modalidade.Professor == null)
            {
                cbxProfessor.SelectedItem = null;
            }
            else
            {
                foreach (var item in cbxProfessor.Items)
                {
                    var professor = item as Professor;
                    if (professor == null) return;
                    if (professor.CPF == modalidade.Professor.CPF)
                    {
                        cbxProfessor.SelectedItem = item;
                    }
                }
            }

            txtNomeModalidade.Enabled = String.IsNullOrEmpty(modalidade.Nome);
        }
    }
}
