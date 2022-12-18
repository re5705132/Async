using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public partial class Product
    {
        public int Price { get; set; }
       // public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
    public class Category 
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
