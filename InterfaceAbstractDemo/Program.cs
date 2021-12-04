using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarburcksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new System.DateTime(1985, 1, 6), FirstName = "Engin1", LastName = "Demiroğ", NationalityId = 28861499108 });

            Console.ReadLine();
        }
    }
}
