using simple_products_crud_web_app.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_products_crud_web_app.Models.Repos
{
    public class AuthDbRepository : IAuthInterface<AuthorDependency>
    {
        AppDbContext  db;

        public AuthDbRepository(AppDbContext _db)
        {
            db = _db;
        }

        public void Add(AuthorDependency entity)
        {
            db.authors.Add(entity);
            db.SaveChanges();
        }

        public void Delete(AuthorDependency entity)
        {
            //var auth = Find(id);
            db.authors.Remove(entity);
            db.SaveChanges();
            
        }

        public AuthorDependency Find(int id)
        {
            var authfind = db.authors.SingleOrDefault(x => x.AuthId == id);
            return authfind;
        }

        public IList<AuthorDependency> List()
        {
            return db.authors.ToList();
        }

        public List<AuthorDependency> Search(string term)
        {
            var result = db.authors.Where(x => x.AuthName == term || x.AuthDesc == term).ToList();


            return result;
        }

        public void Update(int id, AuthorDependency entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    }
}
