using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ProductRepository : IDataRepository<Product>
    {
        IContext _context;
        public ProductRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Product> AddAsync(Product entity)
        {
           EntityEntry<Product> newOne =   _context.Products.Add(entity);
           
            await _context.SaveChangesAsync();
            return  newOne  .Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.Id == id));
            await _context.SaveChangesAsync();  
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            var newEntity= _context.Products.Update(entity);
            await _context.SaveChangesAsync();
            return  newEntity.Entity;
        }
    }
}
