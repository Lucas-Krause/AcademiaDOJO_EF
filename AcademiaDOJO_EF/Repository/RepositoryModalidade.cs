using AcademiaDOJO_EF.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDOJO_EF.Repository
{
    public class RepositoryModalidade
    {
        public int Save(Modalidade modalidade, bool AddOrUpdate)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                {
                    db.Set<Modalidade>().Attach(modalidade);
                }
                if (AddOrUpdate)
                {
                    db.Entry(modalidade).State = EntityState.Added;
                }
                else
                {
                    db.Entry(modalidade).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }

        public int Delete(Modalidade modalidade)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                {
                    db.Set<Modalidade>().Attach(modalidade);
                }
                db.Entry(modalidade).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }

    }
}
