namespace Core.Entities;

public class ShoppingCart
{
    public string Id { get; set; }
    public LinkedList<CartItem> Items { get; set; } = [];
}
