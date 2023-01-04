using Module7.Homework.Couriers;
using Module7.Homework.Couriers.@base;
using Module7.Homework.Deliveries.@base;
using Module7.Homework.Order.@base;
using System.Net;

namespace Module7.Homework.Deliveries;

internal class HomeDelivery<T> : Delivery<T> where T : Courier
{
    public HomeDelivery()
    {
        Console.WriteLine("Доставка на дом!");

    }

    protected internal override Courier SetCourier()
    {
        if (base.IsOversize)
        {
            return new TruckCourier(Address, Number);
        }
        else if (IsFarPoint)
        {
            return new CarCourier(Address, Number);
        }
        else
        {
            return new HumanCourier(Address, Number);
        }
    }
}