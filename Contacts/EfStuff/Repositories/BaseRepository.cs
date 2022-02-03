using Contacts.EfStuff.DbModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Contacts.EfStuff.Repositories
{
    public abstract class BaseRepository<Template> where Template : BaseModel
    {
        protected WebContext _webContext;
        protected DbSet<Template> _dbSet;

        public BaseRepository(WebContext webContext)
        {
            _webContext = webContext;
            _dbSet = webContext.Set<Template>();
        }

        public virtual Template Get(long id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual List<Template> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Save(Template model)
        {
            if (model.Id > 0)
            {
                _webContext.Update(model);
            }
            else
            {
                _dbSet.Add(model);
            }
            _webContext.SaveChanges();
        }

        public virtual void Remove(long id)
        {
            Remove(Get(id));
        }

        public virtual void Remove(Template model)
        {
            _webContext.Remove(model);
            _webContext.SaveChanges();
        }

        public virtual void Remove(List<Template> models)
        {
            foreach (Template model in models)
            {
                _dbSet.Remove(model);
            }

            _webContext.SaveChanges();
        }
    }
}
