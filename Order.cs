using Module7.Homework.Model.@base;

namespace Module7.Homework;

class Order<TDelivery, TType> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public TType Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}