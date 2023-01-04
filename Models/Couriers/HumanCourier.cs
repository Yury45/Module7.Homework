using Module7.Homework.Couriers.@base;

namespace Module7.Homework.Couriers;

internal class HumanCourier : Courier
{
    protected override void SetCourier(string address)
    {
        base.SetCourier(address);
        Console.WriteLine("Способ доставки - пеший курьер.\n");
    }

    protected internal HumanCourier(string? address, string number) : base(address, number)
    {

    }
}