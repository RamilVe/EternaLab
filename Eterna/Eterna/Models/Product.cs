using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
