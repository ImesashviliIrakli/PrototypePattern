namespace PrototypePattern.Models;

public class OrderInfo
{
    public int OrderId { get; set; }
    public OrderInfo(int orderId)
    {
        this.OrderId = orderId;
    }
}
