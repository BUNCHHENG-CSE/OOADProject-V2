using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Order.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Order;

public class OrderCommands
{
    public static IEnumerable<Orders> GetAllOrder()
    {
        return new GetAllCommand().Execute();
    }
    public static bool AddNewOrder(OrderDetails orderDetails)
    {
        return new AddCommand(orderDetails).Execute();
    }
    public static int AddNewCustomer()
    {
        return new AddNewCommand().Execute();
    }
    public static int AddOrderAndReturnId(Orders order)
    {
        return new AddOrderCommand(order).Execute();
    }

}
