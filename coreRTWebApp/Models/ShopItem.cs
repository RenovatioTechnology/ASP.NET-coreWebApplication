using System.ComponentModel.DataAnnotations;

public class ShopItem
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    // You can add more properties like categories, images, etc. as needed
}
