using Module7.Homework.Couriers.@base;
using Module7.Homework.Deliveries.@base;
using Module7.Homework.Models.Product;
using System.Net;
using Module7.Homework.Couriers;
using Module7.Homework.Deliveries;
using Module7.Homework.Extentions;

namespace Module7.Homework.Order.@base;

internal class Order<TDelivery> where TDelivery : Delivery<Courier>, new()
{
    protected internal TDelivery Delivery { get; set; }

    protected string? Number { get; private set; }

    protected string? Address { get ; private set; }

    protected bool IsOversize { get; private set; }

    protected string? Description { get; set; }

    protected List<Product> Products { get; set; }

    protected internal Order(List<Product> products)
    {
        Products = new List<Product>();
        Products = products;
        GetSizeType();
        SetDescription();
        SetNumber();
        SetAddress();
        InitializeDelivery( Address ,IsOversize, Number);
        CreateOrder();

    }

    private void InitializeDelivery(string? address, bool isOversize, string number)
    {
        Delivery = new TDelivery()
        {
            Address = Address,
            IsOversize = isOversize,
            Number = number
        };
    }

    private void GetSizeType()
    {
        /*
         * инициализация поля крупногабортности заказа:
         * на основании параметров заказа будет указан флаг габаритности посылки
        */
        IsOversize = Randomizer.GetRandomBool();
    }

    private void SetNumber()
    {
        /*
         * инициализация поля номера заказа:
         * строковое / числовое представление
        */
        Number = Randomizer.GetRandomNumber().ToNewFormat();
    }

    private void SetDescription()
    {
        /*
         * инициализация поля описания заказа:
         * число товаров и их наименования,
         * общая ценность,
         * размер.
        */
    }

    private void SetAddress()
    {
        /*
         * иницализания конечного пункта доставки
         */
    }

    private void CreateOrder()
    {
        Delivery.SetCourier();

    }
}