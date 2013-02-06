using Domain.Models;

namespace Data.Contracts
{
    public interface IRoleStore
    {
        void MapContactToRole(Contact contact, string manager);
    }
}