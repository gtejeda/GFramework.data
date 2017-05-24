using GFramework.core.commanding;
using GFramework.core.domainEntities;
using GFramework.data.commands;

namespace GFramework.data.handlers
{
    public interface IUpdateCommandHandler<T>: ICommandHandler<UpdateEntityCommand<T>> where T: IEntity
    {
    }
}
