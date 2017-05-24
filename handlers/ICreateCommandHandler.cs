using GFramework.core.commanding;
using GFramework.core.domainEntities;
using GFramework.data.commands;

namespace GFramework.data.handlers
{
    public interface ICreateCommandHandler<T>: ICommandHandler<CreateEntityCommand<T>> where T: IEntity
    {
    }
}
