using Module7.Homework.Couriers;
using Module7.Homework.Couriers.@base;
using Module7.Homework.Deliveries.@base;

namespace Module7.Homework.Deliveries;

 internal class ShopDelivery<T> : Delivery<T> where T : Courier
 {

     public ShopDelivery()
     {
         Console.WriteLine("Доставка в магазин!");

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