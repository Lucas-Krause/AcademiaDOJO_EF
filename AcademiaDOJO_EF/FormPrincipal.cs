using AcademiaDOJO_EF.Dominio;
using AcademiaDOJO_EF.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDOJO_EF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            modalidadeBindingSource.DataSource = new AcademiaContext().Modalidades.ToList();
            professorBindingSource.DataSource = new AcademiaContext().Professores.ToList();
            alunoBindingSource1.DataSource = new AcademiaContext().Alunos.ToList();
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoProfessor)
            {
                professorBindingSource.Add(new Professor());
                professorBindingSource.MoveLast();
            }

            var professor = professorBindingSource.Current as Professor;
            if (professor == null) return;

            var temporario = new Professor();
            temporario = professor.Clone();

            var formP = new FormProfessor(temporario);
            if (formP.ShowDialog() == DialogResult.OK)
            {
                professor.FromProfessor(temporario);
                if (new RepositoryProfessor().Save(professor, sender == btnNovoProfessor) > 0)
                {
                    dgvProfessor.Refresh();
                    MessageBox.Show($"Os dados do professor {professor.Nome} foram salvos com sucesso!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Os dados do professor {professor.Nome} não foram salvos com sucesso.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (sender == btnNovoProfessor)
                {
                    professorBindingSource.MoveLast();
                    professorBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            var professor = professorBindingSource.Current as Professor;
            if (professor == null) return;
            if (MessageBox.Show($"Você realmente deseja excluir permanentemente o professor {professor.Nome}?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (new RepositoryProfessor().Delete(professor) > 0)
                {
                    professorBindingSource.Remove(professor);
                    dgvProfessor.Refresh();
                    MessageBox.Show($"O professor {professor.Nome} foi deletado com sucesso.",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"O professor {professor.Nome} não foi deletado com sucesso.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNovaModalidade_Click(object sender, EventArgs e)
        {
            if (sender == btnNovaModalidade)
            {
                modalidadeBindingSource.Add(new Modalidade());
                modalidadeBindingSource.MoveLast();
            }

            var modalidade = modalidadeBindingSource.Current as Modalidade;
            if (modalidade == null) return;

            var temporario = new Modalidade();
            temporario = modalidade.Clone();

            var formM = new FormModalidade(temporario);
            if (formM.ShowDialog() == DialogResult.OK)
            {
                modalidade.FromModalidade(temporario);
                if (new RepositoryModalidade().Save(modalidade, sender == btnNovaModalidade) > 0)
                {
                    dgvModalidade.Refresh();
                    MessageBox.Show($"Os dados da modalidade {modalidade.Nome} foram salvos com sucesso!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Os dados da modalidade {modalidade.Nome} não foram salvos com sucesso.",
                      "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                if (sender != btnAlterarModalidade)
                {
                    modalidadeBindingSource.MoveLast();
                    modalidadeBindingSource.RemoveCurrent();
                }
                dgvModalidade.Refresh();
            }
        }

        private void btnExcluirModalidade_Click(object sender, EventArgs e)
        {
            var modalidade = modalidadeBindingSource.Current as Modalidade;
            if (modalidade == null) return;
            if (MessageBox.Show($"Você realmente deseja excluir permanentemente a modalidade {modalidade.Nome}?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                if (new RepositoryModalidade().Delete(modalidade) > 0)
                {
                    modalidadeBindingSource.Remove(modalidade);
                    dgvModalidade.Refresh();
                    MessageBox.Show($"A modalidade {modalidade.Nome} foi deletado com sucesso.",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"A modalidade {modalidade.Nome} não foi deletado com sucesso.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoAluno)
            {
                alunoBindingSource1.Add(new Aluno());
                alunoBindingSource1.MoveLast();
            }

            var aluno = alunoBindingSource1.Current as Aluno;
            if (aluno == null) return;

            var temporario = new Aluno();
            temporario = aluno.Clone();

            var formM = new FormAluno(temporario);
            if (formM.ShowDialog() == DialogResult.OK)
            {
                aluno.FromAluno(temporario);
                if (new RepositoryAluno().Save(aluno, sender == btnNovoAluno) > 0)
                {
                    dgvAluno.Refresh();
                    MessageBox.Show($"O aluno {aluno.Nome} foi salvo com sucesso!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"O aluno {aluno.Nome} não foi salvo com sucesso.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (sender != btnAlterarAluno)
                {
                    alunoBindingSource1.MoveLast();
                    alunoBindingSource1.RemoveCurrent();
                }
                dgvAluno.Refresh();
            }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            var aluno = alunoBindingSource1.Current as Aluno;
            if (aluno == null) return;
            if (MessageBox.Show($"Você realmente deseja excluir permanentemente o aluno {aluno.Nome}?",
               "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                if (new RepositoryAluno().Delete(aluno) > 0)
                {
                    alunoBindingSource1.Remove(aluno);
                    dgvAluno.Refresh();
                    MessageBox.Show($"O aluno  {aluno.Nome} foi deletado com sucesso.",
                       "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"O aluno {aluno.Nome} não foi deletado com sucesso.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
                
        }
    }
}
