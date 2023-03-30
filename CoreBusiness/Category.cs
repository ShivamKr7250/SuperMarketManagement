using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {
        [Key]
        public int CategoriesId { get; set; }

        [Required] public string? Name { get; set; }

        public string? Description { get; set; }

        //Navigation Property for ef core
        public List<Product> Products { get; set; }

    }
}