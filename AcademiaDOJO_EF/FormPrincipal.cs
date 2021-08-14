using AcademiaDOJO_EF.Dominio;
using AcademiaDOJO_EF.Repository;
using System;
using System.Linq;
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
            using (var db = new AcademiaContext())
            {
                modalidadeBindingSource.DataSource = db.Modalidades.ToList();
                professorBindingSource.DataSource = db.Professores.ToList();
                alunoBindingSource1.DataSource = db.Alunos.ToList();
            }
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

            using (var formProfessor = new FormProfessor(temporario))
            {
                if (formProfessor.ShowDialog() == DialogResult.OK)
                {
                    professor.FromProfessor(temporario);
                    if (new RepositoryProfessor().Save(professor, sender == btnNovoProfessor) > 0)
                    {
                        dgvProfessor.Refresh();
                        ProfessorSaveMessage();
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
                    ProfessorDeleteMessage();
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

            using (var formM = new FormModalidade(temporario))
            {
                if (formM.ShowDialog() == DialogResult.OK)
                {
                    modalidade.FromModalidade(temporario);
                    if (new RepositoryModalidade().Save(modalidade, sender == btnNovaModalidade) > 0)
                    {
                        dgvModalidade.Refresh();
                        ModalidadeSaveMessage();
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
                    ModalidadeDeleteMessage();
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

            using (var formA = new FormAluno(temporario))
            {
                if (formA.ShowDialog() == DialogResult.OK)
                {
                    aluno.FromAluno(temporario);
                    if (new RepositoryAluno().Save(aluno, sender == btnNovoAluno) > 0)
                    {
                        dgvAluno.Refresh();
                        AlunoSaveMessage();
                    }
                }
                else
                {
                    if (sender != btnAlterarAluno)
                    {
                        alunoBindingSource1.MoveLast();
                        alunoBindingSource1.RemoveCurrent();
                    }
                }
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
                    AlunoDeleteMessage();
                }
            }

        }

        public void ProfessorSaveMessage()
        {
            var professor = professorBindingSource.Current as Professor;
            MessageBox.Show($"Os dados do professor {professor.Nome} foram salvos com sucesso!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ProfessorDeleteMessage()
        {
            var professor = professorBindingSource.Current as Professor;
            MessageBox.Show($"O professor foi deletado com sucesso.",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ModalidadeSaveMessage()
        {
            var modalidade = modalidadeBindingSource.Current as Modalidade;
            MessageBox.Show($"Os dados da modalidade {modalidade.Nome} foram salvos com sucesso!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ModalidadeDeleteMessage()
        {
            var modalidade = modalidadeBindingSource.Current as Modalidade;
            
            MessageBox.Show($"A modalidade foi deletada com sucesso.",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AlunoSaveMessage()
        {
            var aluno = alunoBindingSource1.Current as Aluno;
            MessageBox.Show($"O aluno {aluno.Nome} foi salvo com sucesso!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AlunoDeleteMessage()
        {
            var aluno = alunoBindingSource1.Current as Aluno;
            MessageBox.Show($"O aluno foi deletado com sucesso.",
                       "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
