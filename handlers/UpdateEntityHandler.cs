using System;
using GFramework.core.commanding;
using GFramework.core.converters;
using GFramework.core.domainEntities;
using GFramework.core.persistence;
using GFramework.data.commands;
using Microsoft.Practices.Unity;

namespace GFramework.data.handlers
{
    /// <summary>
    /// Please note this command's DTO input is automatically converted to a Domain object to validate business rules 
    /// </summary>
    /// <typeparam name="T">Object to update in database</typeparam>
    public class UpdateEntityHandler<T>: ICommandHandler<UpdateEntityCommand<T>> where T : IEntity
    {
        public bool Execute(UpdateEntityCommand<T> Command, ICommandProcessor CommandProcessor)
        {
            IDTOConverter<T> converter = null;

            try
            {
                converter = (IDTOConverter<T>)CommandProcessor.UnityContainer.Resolve(typeof(IDTOConverter<T>));
            }
            catch (Exception)
            {
                throw new ApplicationException("A Converter has not been found for this DTO, please make sure it was registered in the Unity Container Configuration");
            }


            var converted = converter.Convert(Command.Entity);
            var dapperRepository = CommandProcessor.UnityContainer.Resolve<IDefaultDomainRepository>();

            dapperRepository.Delete(converted);
            return true;
        }
    }
}
