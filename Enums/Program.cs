

public class Program
{
    public static Dictionary<string, OrderStatusEnum> OrderDetails = new Dictionary<string, OrderStatusEnum>();
    

    public static void Main()
    {
        OrderDetails.Add("O1", OrderStatusEnum.PLACED);
        OrderDetails.Add("O2", OrderStatusEnum.CANCELLED);
        OrderDetails.Add("O3", OrderStatusEnum.CONFIRMED);
        OrderDetails.Add("O4", OrderStatusEnum.DELIVERED);
        OrderDetails.Add("O5", OrderStatusEnum.OUT_FOR_DELIVERY);

        Console.Write("Choose Your Payment Methods : ");
        string? val = Console.ReadLine();

        if(Enum.TryParse(val, out paymentMethodsEnum selected))
        {
            PaymentMethods payment = new PaymentMethods(selected);
            payment.ProcessPayment();
        }
        else
        {
            Console.WriteLine("Error!!");
        }
        
        Console.WriteLine();

        //Order Status : 
        Console.Write("Enter Order ID : ");
        string? OrderId = Console.ReadLine();
        if(OrderId == null)
        {
            Console.WriteLine("Please Provide a valid Value");
            return;
        }

        try
        {
            OrderStatusEnum OrderStatusDetail = OrderDetails[OrderId];
            OrderProcess order = new OrderProcess(OrderStatusDetail);
            order.tellOrderStatus();
        }
        catch
        {
            Console.WriteLine("ERROR! Order Not Found");
            return;
        }


    }
}