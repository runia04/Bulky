using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Reporitory.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Reporitory
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    

   

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
