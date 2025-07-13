namespace Core.Entities;

public class ShoppingCart
{
    public string Id { get; set; }
    public LinkedList<CartItem> Items { get; set; } = [];
    public int? DeliveryMethodId { get; set; }
    public string? ClientSecret { get; set; }
    public string? PaymentIntentId { get; set; }
}
