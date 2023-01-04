
using Module7.Homework.Couriers.@base;
using Module7.Homework.Deliveries;
using Module7.Homework.Deliveries.@base;
using Module7.Homework.Models.Product;
using Module7.Homework.Order.@base;

namespace Module7.Homework;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("###########  ЗАКАЗЫ НА ДОМ  ###########");

        Order<HomeDelivery<Courier>> homeOrder1 = new Order<HomeDelivery<Courier>>(new List<Product>());

        Order<HomeDelivery<Courier>> homrOrder2 = new Order<HomeDelivery<Courier>>(new List<Product>());

        Order<HomeDelivery<Courier>> homeOrder3 = new Order<HomeDelivery<Courier>>(new List<Product>());

        Console.WriteLine("###########  ЗАКАЗЫ В ПУНКТ ВЫДАЧИ  ###########");

        Order<PickPointDelivery<Courier>> pickPointOrder1 = new Order<PickPointDelivery<Courier>>(new List<Product>());

        Order<PickPointDelivery<Courier>> pickPointOrder2 = new Order<PickPointDelivery<Courier>>(new List<Product>());

        Order<PickPointDelivery<Courier>> pickPointOrder3 = new Order<PickPointDelivery<Courier>>(new List<Product>());

        Console.WriteLine("###########  ЗАКАЗЫ В МАГАЗИН  ###########");

        Order<ShopDelivery<Courier>> shopOrder1 = new Order<ShopDelivery<Courier>>(new List<Product>());

        Order<ShopDelivery<Courier>> shopOrder2 = new Order<ShopDelivery<Courier>>(new List<Product>());

        Order<ShopDelivery<Courier>> shopOrder3 = new Order<ShopDelivery<Courier>>(new List<Product>());


    }
}