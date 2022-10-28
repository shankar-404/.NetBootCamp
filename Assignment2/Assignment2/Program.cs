using Assignment2;
using System.Collections;

//Question1
int[] arr1 = { 28, 3, 10, 200, 10, 900, 11100 };

var myQuery = from num in arr1 where num > 100 && num < 1000 select num * num * num;

foreach (var num in myQuery)
    Console.WriteLine(num);

//Question 2
//string[] India = { "Mahesh", "Ramesh", "Somesh", "Rakesh" };
//string[] France = { "Dia", "Kia", "Sia", "Tia" };


//Question3


List<Order> OrderList = new List<Order>();
OrderList.Add(new Order(1, "Boomer1", new DateTime(2018, 12, 25), 1));
OrderList.Add(new Order(2, "Boomer2", new DateTime(2016, 12, 25), 50));
OrderList.Add(new Order(3, "Boomer3", new DateTime(2017, 11, 25), 20));

List<Item> ItemList = new List<Item>();
ItemList.Add(new Item("Boomer1", 6.5));
ItemList.Add(new Item("Boomer2", 7.5));


var orderedDateQnty = OrderList.OrderByDescending(ele => ele.date).ThenByDescending(ele => ele.quantity).ToList();
Console.WriteLine("Order by DateQnty");
foreach(var order in orderedDateQnty)
{
    Console.WriteLine("ID:" + order.id + "\tName:" + order.name + "\tDate:" + order.date + "\tQnty:" + order.quantity);
}


//Question-4
Console.WriteLine("Question-4");
var orderGrp = OrderList.GroupBy(x => x.date.Month).Select(g => g.OrderBy(x=>x.date));
foreach (var group in orderGrp)
{
    Console.WriteLine("Group");
    foreach (var order in group)
    {
        //Console.Write(order.);
        Console.WriteLine("ID:" + order.id + "\tName:" + order.name + "\tDate:" + order.date + "\tQnty:" + order.quantity);
    }
}


//Question 5/6
var PriceList = (from order in OrderList
                 join item in ItemList on order.name equals item.name
                 orderby order.date.Month, order.date.Date descending
                 select new { order.id, order.name, order.date, totalPrice = order.quantity * item.price });

foreach (var entry in PriceList)
{
    Console.WriteLine($"{entry.id}  {entry.name}  {entry.date} {entry.totalPrice}");
}