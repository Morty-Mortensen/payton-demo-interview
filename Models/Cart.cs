namespace AristotlePrepPayton.Models;

public class Cart
{
    public int CartId { get; set; }
    
    public IList<CartItem> Items { get; set; }
}