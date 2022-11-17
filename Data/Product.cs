

namespace FlowerCRM.Data;

public class Product
{
    public int Id { get; set; }
    public string ProductCode { get; set; }
    public string ProductDescription { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DateCreated { get; set; }
    public bool IsPopular { get; set; }
}
