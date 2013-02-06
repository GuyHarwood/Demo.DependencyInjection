using Data.Contracts;
using Domain.Models;
using Domain.Services;
using System.Collections.Generic;

namespace Domain.DefaultImpl
{
    public class ContactLister : IContactLister
    {
        private readonly IContactStore _contactStore;

        public ContactLister(IContactStore contactStore)
        {
            _contactStore = contactStore;
        }

        public IEnumerable<Contact> GetList()
        {
            return _contactStore.List();
        }
    }
}
