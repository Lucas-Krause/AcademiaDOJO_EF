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
    public partial class FormAluno : Form
    {
        Aluno aluno;
        public FormAluno(Aluno _aluno)
        {
            InitializeComponent();
            aluno = _aluno;
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add("Text", aluno, "Nome");
            mskCPF.DataBindings.Add("Text", aluno, "CPF");
            mskTelefone.DataBindings.Add("Text", aluno, "Telefone");
            modalidadeBindingSource.DataSource = new AcademiaContext().Modalidades.ToList();

            cbxModalidade.DataBindings.Add("SelectedItem", aluno, "Modalidade");

            if (aluno.Modalidade == null)
            {
                cbxModalidade.SelectedItem = null;
            }
            else
            {
                foreach (var item in cbxModalidade.Items)
                {
                    var modalidade = item as Modalidade;
                    if (modalidade == null) return;
                    if (modalidade.Nome == aluno.Modalidade.Nome)
                    {
                        cbxModalidade.SelectedItem = item;
                    }
                }
            }

            mskCPF.Enabled = String.IsNullOrEmpty(aluno.CPF);
        }
    }
}
