using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IContactLister
    {
        IEnumerable<Contact> GetList();
    }
}
