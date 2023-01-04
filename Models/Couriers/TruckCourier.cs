using Module7.Homework.Couriers.@base;

namespace Module7.Homework.Couriers;

internal class TruckCourier : Courier
{
    protected override void SetCourier(string? address)
    {
        base.SetCourier(address);
        Console.WriteLine("Способ доставки - грузовая машина.\n");
    }

    protected internal TruckCourier(string? address, string number) : base(address, number)
    {

    }
}