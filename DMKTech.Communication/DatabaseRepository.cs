using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMKTech.Communication.Database;
using System.Data.Entity;

namespace DMKTech.Communication
{
    public class DatabaseRepository<TEntity> where TEntity : class
    {
        //  private readonly DbSet<TEntity> 
        #region IFF Database
        db_dmktechEntities context = new db_dmktechEntities();

        DbSet<TEntity> dbSet;

        public DatabaseRepository()
        {
            this.dbSet = this.context.Set<TEntity>();
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);

        }
        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            dbSet.Remove(entity);

        }
        public IQueryable<TEntity> Table
        {
            get { return dbSet.AsQueryable(); }
        }
        public List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        #endregion




    }
}
