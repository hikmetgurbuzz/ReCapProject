using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
                Console.WriteLine("Marka: " + car.CarName);
                Console.WriteLine("Model: " + car.Description);
                Console.WriteLine("Üretim Yılı: " + car.ModelYear);
                Console.WriteLine("Günlük Kiralama Ücreti: " + car.DailyPrice + " TL " + "(KDV dahil değildir.)");
            }
        }
    }
}
