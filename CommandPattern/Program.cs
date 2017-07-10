using CommandPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            broker.placeOrders();
            Console.ReadLine();
        }
    }
}
