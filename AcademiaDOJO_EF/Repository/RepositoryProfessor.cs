using AcademiaDOJO_EF.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Repository
{
    public class RepositoryProfessor
    {
        public int Save(Professor professor, bool addOrUpdate)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                {
                    db.Set<Professor>().Attach(professor);
                }

                if (addOrUpdate)
                {
                    db.Entry(professor).State = EntityState.Added;
                }
                else
                {
                    db.Entry(professor).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Professor professor)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                {
                    db.Set<Professor>().Attach(professor);
                }
                db.Entry(professor).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
