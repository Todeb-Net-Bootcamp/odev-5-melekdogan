using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAll();
        public Category Get(int id);
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(Category category);
       
    }
}
