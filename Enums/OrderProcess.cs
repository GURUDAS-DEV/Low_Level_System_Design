public enum OrderStatusEnum
{
    PLACED, 
    CONFIRMED,
    SHIPPED, 
    OUT_FOR_DELIVERY, 
    DELIVERED, 
    CANCELLED,
    NAN
}


public class OrderProcess
{
    OrderStatusEnum orderStatus = OrderStatusEnum.NAN;

    public OrderProcess(OrderStatusEnum order){
        orderStatus = order;
    }

    public void tellOrderStatus()
    {
        Console.WriteLine($"Your Order is currently {orderStatus} ");
    }
}