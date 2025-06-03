namespace ECommerceApi.Models;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
