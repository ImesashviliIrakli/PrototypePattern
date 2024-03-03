using PrototypePattern.Manager;
using PrototypePattern.Models;

Console.WriteLine("Original order:");
FoodOrder savedOrder = new FoodOrder("Harrison",
                                        true,
                                        new string[] { "Pizza", "Coke" },
                                        new OrderInfo(2345));
savedOrder.Debug();

Console.WriteLine("Cloned order:");
FoodOrder clonedOrder = (FoodOrder)savedOrder.DeepCopy();
clonedOrder.Debug();

Console.WriteLine("Order changes:");
savedOrder.CustomerName = "Jeff";
savedOrder.Info.OrderId = 5555;
savedOrder.Debug();
clonedOrder.Debug();

PrototypeManager manager = new PrototypeManager();
manager["2/3/2020"] = new FoodOrder("Steve",
                                        false,
                                        new string[] { "Chicken Parm", "Root Beer" },
                                        new OrderInfo(8912));

Console.WriteLine("Manager clone:");
FoodOrder managerOrder = (FoodOrder)manager["2/3/2020"].DeepCopy();
managerOrder.Debug();