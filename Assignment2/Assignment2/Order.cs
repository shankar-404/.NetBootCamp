using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Order
    {
        public int id { get; }
        public string name { get; }
        public DateTime date { get; }
        public int quantity { get; }

        public Order(int id, string name, DateTime date, int quantity)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.quantity = quantity;
        }

        public void getOrder()
        {
            Console.WriteLine("ID:"+this.id + "\tName:"+this.name + "\tDate:"+this.date + "\tQnty:"+this.quantity);
        }
    }

}
