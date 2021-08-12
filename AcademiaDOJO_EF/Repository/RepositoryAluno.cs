using AcademiaDOJO_EF.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Repository
{
    public class RepositoryAluno
    {
        public int Save(Aluno aluno, bool AddOrUpdate)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(aluno).State == EntityState.Detached)
                {
                    db.Set<Aluno>().Attach(aluno);
                }
                if (AddOrUpdate)
                {
                    db.Entry(aluno).State = EntityState.Added;
                }
                else
                {
                    db.Entry(aluno).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Aluno aluno)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(aluno).State == EntityState.Detached)
                {
                    db.Set<Aluno>().Attach(aluno);
                }
                db.Entry(aluno).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
