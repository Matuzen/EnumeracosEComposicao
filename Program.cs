using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1080, DateTime.Now, OrderStatus.PendingPayment);
            Console.WriteLine(order);

            Order order1 = new Order 
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order1);

            // Conversão de string para enumeração, valor enumerado para string

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Conversão de enum para string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


        }
    }
}
