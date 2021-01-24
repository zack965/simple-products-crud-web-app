using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_products_crud_web_app.Models.Repos
{
    public interface IAuthInterface<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete( TEntity entity);
        List<TEntity> Search(string term);
    }
}
