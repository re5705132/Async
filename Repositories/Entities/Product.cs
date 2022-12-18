using System.ComponentModel.DataAnnotations;

namespace Repositories.Entities
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
    }
}