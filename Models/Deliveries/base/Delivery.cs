using Module7.Homework.Couriers;
using Module7.Homework.Couriers.@base;

namespace Module7.Homework.Deliveries.@base;

internal abstract class Delivery<T> where T : Courier
{
    protected internal string? Address { get; set; }

    protected internal bool IsOversize { get; set; }

    protected internal string Number { get; set; }

    protected internal bool IsFarPoint { get; set; }

    public Delivery()
    {
        IsFarPoint = Randomizer.GetRandomBool();
    }

    abstract protected internal Courier SetCourier();
}