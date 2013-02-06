using System.Collections.Generic;
using Domain.Models;

namespace Infonetica.ContactApp.UI.Web.Models
{
    public class ContactIndexModel
    {
        public ContactIndexModel()
        {
            Contacts = new Contact[] {};
        }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}