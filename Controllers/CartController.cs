using AristotlePrepPayton.Models;
using AristotlePrepPayton.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AristotlePrepPayton.Controllers;

[ApiController]
[Route("cart")]
public class CartController : ControllerBase
{
    // Database 
    private static IList<CartItem> CartItems = new List<CartItem>()
    {
        new CartItem()
        {
            CartItemId = 1,
            Name = "Milk",
            Quantity = 2,
            Price = 2.33m,
            Type = CartItemType.GroceryItem
        },
        new CartItem()
        {
            CartItemId = 2,
            Name = "Ice",
            Quantity = 1,
            Price = 5.22m,
            Type = CartItemType.GroceryItem
        },
        new CartItem()
        {
            CartItemId = 3,
            Name = "TV - The Smart Kind",
            Quantity = 5,
            Price = 150.00m,
            Type = CartItemType.ElectronicItem
        },
        new CartItem()
        {
            CartItemId = 4,
            Name = "Watch - The Smart Kind Of Course",
            Quantity = 1,
            Price = 200.50m,
            Type = CartItemType.ElectronicItem
        },
        new CartItem()
        {
            CartItemId = 5,
            Name = "Shirt",
            Quantity = 5,
            Price = 22.00m,
            Type = CartItemType.CothingItem
        }
    };
    
    // #1 Get electronics only
    // 1. Before: Explain how you'd architecture (database) an online shopping cart (extra info: user has a shopping cart with different types of items)
    // 2. After: 
    public ActionResult GetTotalCostForElectronicCartItems(int cartId)
    {
        try
        {
            return Ok(new { });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
    
    // #2 How would you add a new item to your cart here?
    // 1. All the way from client -> server -> database (use mocked database) -> response to client.
    public ActionResult AddItemToCart()
    {
        try
        {
            return Ok(new { });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}