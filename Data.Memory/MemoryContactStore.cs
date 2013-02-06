using Data.Contracts;
using Domain.Models;
using System.Collections.Generic;

namespace Data.Memory
{
    public class MemoryContactStore : IContactStore
    {
        private static readonly List<Contact> Contacts;

        static MemoryContactStore()
        {
            Contacts = new List<Contact>();
        }

        public void Add(Contact contact)
        {
            Contacts.Add(contact);
        }

        public IEnumerable<Contact> List()
        {
            return Contacts.ToArray();
        }
    }

}
