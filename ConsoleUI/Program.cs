using System;
using Business.Concrete;
using DataAccess.Concrete.InMemoryDal;
using Business;
using DataAccess.Concrete.Entityframework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
            Console.ReadLine();
        }
    }
}
