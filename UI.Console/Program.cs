using System;
using System.Data.SqlClient;
using Common.Logging;
using Data.Contracts;
using Data.Memory;
using Domain.DefaultImpl;
using Domain.Models;
using Domain.Services;
using SimpleInjector;

namespace UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the IOC container
            var container = new Container();
            //bind all our types to the interfaces
            container.Register<IContactCreator, ContactCreator>();
            container.Register<IContactLister, ContactLister>();
            container.Register<IContactStore, MemoryContactStore>();
            container.Register<ILog, NoLogging>();
            
            var creator = container.GetInstance<IContactCreator>();
            creator.Create(new Contact()
                {
                    Name = "Guy"
                });
            creator.Create(new Contact()
            {
                Name = "Ascension"
            });
            creator.Create(new Contact()
            {
                Name = "Richard"
            });

            var lister = container.GetInstance<IContactLister>();

            var contacts = lister.GetList();
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Name);
            }
            Console.ReadKey();
        }
    }
}
