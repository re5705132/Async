using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class CategoryRepository : IDataRepository<Category>
    {
        IContext _context;
        public CategoryRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Category> AddAsync(Category entity)
        {
           var newCategory= _context.Categories.Add(entity);
           await _context.SaveChangesAsync();
          return newCategory.Entity;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
