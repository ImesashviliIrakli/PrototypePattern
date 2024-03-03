using PrototypePattern.Abstract;

namespace PrototypePattern.Models;

public class FoodOrder : Prototype
{
    public string CustomerName { get; set; }
    public bool IsDelivery { get; set; }
    public string[] OrderContents { get; set; }
    public OrderInfo Info { get; set; }

    public FoodOrder(string name, bool delivery, string[] contents, OrderInfo info)
    {
        this.CustomerName = name;
        this.IsDelivery = delivery;
        this.OrderContents = contents;
        this.Info = info;
    }

    public override void Debug()
    {
        Console.WriteLine("------- Prototype Food Order -------");
        Console.WriteLine("\nName: {0} \nDelivery: {1}", this.CustomerName, this.IsDelivery);
        Console.WriteLine("ID: {0}", this.Info.OrderId);
        Console.WriteLine("Order Contents: " + string.Join(",", OrderContents) + "\n");
    }

    public override Prototype DeepCopy()
    {
        FoodOrder clonedOrder = (FoodOrder)this.MemberwiseClone();
        clonedOrder.Info = new OrderInfo(this.Info.OrderId);

        return clonedOrder;
    }

    public override Prototype ShallowCopy()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
