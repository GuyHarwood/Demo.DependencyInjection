using System.Collections.Generic;
using Domain.Models;

namespace Data.Contracts
{
    public interface IContactStore
    {
        void Add(Contact contact);
        IEnumerable<Contact> List();
    }
}
