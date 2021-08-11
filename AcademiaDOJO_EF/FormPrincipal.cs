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
                }
                else
                {
                    if (sender != btnAlterarProfessor)
                    {
                        professorBindingSource.MoveLast();
                        professorBindingSource.RemoveCurrent();
                    }
                    dgvProfessor.Refresh();
                }
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            var professor = professorBindingSource.Current as Professor;
            if (professor == null) return;
            if (new RepositoryProfessor().Delete(professor) > 0)
            {
                professorBindingSource.Remove(professor);
                dgvProfessor.Refresh();
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
            if (new RepositoryModalidade().Delete(modalidade) > 0)
            {
                modalidadeBindingSource.Remove(modalidade);
                dgvModalidade.Refresh();
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

            var temporario = aluno.Clone();

            var formA = new FormAluno(temporario);
            if (formA.ShowDialog() == DialogResult.OK)
            {
                aluno.FromAluno(temporario);
                using (var db = new AcademiaContext())
                {
                    if (db.Entry(aluno).State == EntityState.Detached)
                    {
                        db.Set<Aluno>().Attach(aluno);
                    }

                    if (sender == btnNovoAluno)
                    {
                        db.Entry(aluno).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(aluno).State = EntityState.Modified;
                    }

                    if (db.SaveChanges() > 0)
                    {
                        dgvAluno.Refresh();
                    }
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
            if (alunoBindingSource1.Current != null)
            {
                using (var db = new AcademiaContext())
                {
                    var aluno = alunoBindingSource1.Current as Aluno;
                    db.Entry(aluno).State = EntityState.Deleted;
                    alunoBindingSource1.Remove(aluno);
                    dgvAluno.Refresh();
                    db.SaveChanges();
                }
            }
        }
    }
}
