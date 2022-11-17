

namespace FlowerCRM.Data;

public class Product
{
    public int Id { get; set; }
    public string ProductCode { get; set; }
    public string ProductDescription { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public string ImageUrl { get; set; }
}
