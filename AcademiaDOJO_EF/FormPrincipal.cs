using AcademiaDOJO_EF.Dominio;
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
        //github
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
                using (var db = new AcademiaContext())
                {


                    if (db.Entry(professor).State == EntityState.Detached)
                    {
                        db.Set<Professor>().Attach(professor);
                    }

                    if (sender == btnNovoProfessor)
                    {
                        db.Entry(professor).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(professor).State = EntityState.Modified;
                    }

                    if (db.SaveChanges() > 0)
                    {
                        dgvProfessor.Refresh();
                    }
                }
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

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            if (professorBindingSource.Current != null)
            {
                using (var db = new AcademiaContext())
                {
                    var professor = professorBindingSource.Current as Professor;
                    db.Entry(professor).State = EntityState.Deleted;
                    professorBindingSource.Remove(professor);
                    dgvProfessor.Refresh();
                    db.SaveChanges();
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
                using (var db = new AcademiaContext())
                {
                    if (db.Entry(modalidade).State == EntityState.Detached)
                    {
                        db.Set<Modalidade>().Attach(modalidade);
                    }

                    if (sender == btnNovaModalidade)
                    {
                        db.Entry(modalidade).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(modalidade).State = EntityState.Modified;
                    }

                    if (db.SaveChanges() > 0)
                    {
                        dgvModalidade.Refresh();
                    }
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
            if (modalidadeBindingSource.Current != null)
            {
                using (var db = new AcademiaContext())
                {
                    var modalidade = modalidadeBindingSource.Current as Modalidade;
                    db.Entry(modalidade).State = EntityState.Deleted;
                    modalidadeBindingSource.Remove(modalidade);
                    dgvModalidade.Refresh();
                    db.SaveChanges();
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
