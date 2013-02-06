using System;
using System.Diagnostics;
using Common.Logging;
using Data.Contracts;
using Domain.Models;
using Domain.Services;

namespace Domain.DefaultImpl
{
    public class ContactCreator : IContactCreator 
    {
        private readonly IContactStore _contactStore;
        private readonly ILog _log;

        public ContactCreator(IContactStore contactStore, ILog log)
        {
            _contactStore = contactStore;
            _log = log;
        }

        public virtual void Create(Contact contact)
        {
            if(contact.Name.Length == 0)
                throw  new Exception("where is the name?");

            _log.Log("about to add a contact called " + contact.Name);
            var sw = Stopwatch.StartNew();
            _contactStore.Add(contact);
            sw.Stop();
            _log.Log(string.Format("successfully added contact called {0} in {1} milliseconds", contact.Name, sw.ElapsedMilliseconds));
        }
    }

}
