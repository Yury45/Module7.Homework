namespace Module7.Homework.Couriers.@base;

internal class Courier
{
    protected string? CourierName { get; private set; }

    protected string? PhoneNumber { get; private set; }

    protected string? Address { get; set; }

    protected string Number { get; set; }

    protected internal Courier(string? address, string number)
    {
        /*
         * Логика подбора курьера из БД
         * заполнение полей доставщика 
         */

        Address = address;
        Number = number;
        SetCourier(address);
    }

    protected virtual void SetCourier(string address)
    {

        Console.WriteLine($"Доставка по адресу: {Address}" +
                          $"\nНомер заказа: {Number}" +
                          $"\nИмя курьера: {CourierName}" +
                          $"\nТелефон для связи: {PhoneNumber}");
    }
}