using AristotlePrepPayton.Models.Enums;

namespace AristotlePrepPayton.Models;

public class CartItem
{
    public int CartItemId { get; set; }
    
    public string Name { get; set; }
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }
    
    public CartItemType Type { get; set; }
}