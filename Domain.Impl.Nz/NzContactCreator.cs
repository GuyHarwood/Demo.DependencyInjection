using Common.Logging;
using Data.Contracts;
using Domain.DefaultImpl;
using Domain.Models;

namespace Domain.Impl.Nz
{
    public class NzContactCreator : ContactCreator
    {
        private readonly IRoleStore _roleStore;

        public NzContactCreator(IContactStore contactStore, IRoleStore roleStore, ILog log) : base(contactStore, log)
        {
            _roleStore = roleStore;
        }

        public override void Create(Contact contact)
        {
            base.Create(contact);
            _roleStore.MapContactToRole(contact, "manager");
        }
    }
}
