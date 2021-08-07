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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            modalidadeBindingSource.DataSource = new AcademiaContext().Modalidades.ToList();
            professorBindingSource.DataSource = new AcademiaContext().Professores.ToList();
            alunoBindingSource.DataSource = new AcademiaContext().Alunos.ToList();
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoProfessor)
            {
                professorBindingSource.Add(new Professor());
                professorBindingSource.MoveLast();
            }


            var formP = new FormProfessor(professorBindingSource.Current as Professor);
            if (formP.ShowDialog() == DialogResult.OK)
            {
                using (var db = new AcademiaContext())
                {

                    var professor = professorBindingSource.Current as Professor;

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
            
        }
    }
}
