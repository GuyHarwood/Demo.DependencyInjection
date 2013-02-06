
namespace Common.Commands
{
    public interface ICommandHandler<in TCommand>
    {
        void Execute(TCommand command);
    }
}
