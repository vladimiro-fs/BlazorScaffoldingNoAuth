namespace BlazorScaffoldingNoAuth.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
