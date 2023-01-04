using Module7.Homework.Couriers.@base;

namespace Module7.Homework.Couriers;

internal class CarCourier : Courier
{
    protected override void SetCourier(string address)
    {
        base.SetCourier(address);
        Console.WriteLine("Способ доставки - легковая машина.\n");
    }


    protected internal CarCourier(string? address, string number) : base(address, number)
    {
    }
}