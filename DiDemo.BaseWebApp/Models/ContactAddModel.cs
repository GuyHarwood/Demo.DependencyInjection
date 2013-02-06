using System.ComponentModel.DataAnnotations;

namespace Infonetica.ContactApp.UI.Web.Models
{
    public class ContactAddModel
    {
        [Required]
        public string Name { get; set; }
    }
}