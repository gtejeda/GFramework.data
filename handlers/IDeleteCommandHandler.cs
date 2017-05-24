using GFramework.core.commanding;
using GFramework.core.domainEntities;
using GFramework.data.commands;

namespace GFramework.data.handlers
{
    public interface IDeleteCommandHandler<T>: ICommandHandler<DeleteEntityCommand<T>> where T: IEntity
    {
    }
}
