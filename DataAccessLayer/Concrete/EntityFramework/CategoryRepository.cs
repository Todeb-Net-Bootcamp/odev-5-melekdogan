using DataAccessLayer.Abstract;
using DataAccessLayer.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class CategoryRepository:ICategoryRepository
    {
        private BookStoreDbContext _dbContext;

        public CategoryRepository(BookStoreDbContext Context)
        {
            _dbContext = Context;
        }

        public void Add(Category category) //Kategori ekleme işleminde kullanılacak metot
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        public void Delete(Category category) //Kategori silme işleminde kullanılacak metot
        {
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
        }

        public Category Get(int id)// Verilen idye sahip kategoriye erişmek için kullanılacak metot
        {
            return _dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public IEnumerable<Category> GetAll() //Bütün Kategorileri liste halinde döndürecek metot
        {
            return _dbContext.Categories.ToList();
        }

        public void Update(Category category) //Kategori güncelleme işleminde kullanılacak metot
        {
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
        }
      
    }
}
