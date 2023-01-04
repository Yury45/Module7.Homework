using Module7.Homework.Couriers;
using Module7.Homework.Couriers.@base;
using Module7.Homework.Deliveries.@base;

namespace Module7.Homework.Deliveries;

internal class PickPointDelivery<T> : Delivery<T> where T : Courier
{
    public PickPointDelivery()
    {
        Console.WriteLine("Доставка в пункт выдачи!");

    }

    internal protected override Courier SetCourier()
    {
        if (IsOversize)
        {
            return new TruckCourier(Address, Number);
        }
        else
        {
            return new CarCourier(Address, Number);
        }
    }


}