using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine(String.Format("Stock [ Name: {0}, Quantity: {1} ] bought", name, quantity));
        }

        public void Sell()
        {
            Console.WriteLine(String.Format("Stock [ Name: {0}, Quantity: {1} ] sold", name, quantity));
        }
    }
}
