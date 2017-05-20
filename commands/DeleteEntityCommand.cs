using GFramework.core.Commanding;
using GFramework.core.domainEntities;

namespace GFramework.data.commands
{
    /// <summary>
    /// Please note this command's DTO input is automatically converted to a Domain object to validate business rules 
    /// </summary>
    /// <typeparam name="T">Please note this DTO will be converted to its Domain Entity equivalent and it's Validate function will be called automatically.</typeparam>
    public class DeleteEntityCommand<T>: BaseCommand where T: IEntity
    {
        public T Entity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Entity">Please note this DTO will be converted to its Domain Entity equivalent and it's Validate function will be called automatically.</param>
        /// <param name="ExecutedBy">User executing the command, Typically User.Identity.Name</param>
        public DeleteEntityCommand(T Entity, string ExecutedBy) : base(ExecutedBy)
        {
            this.Entity = Entity;
        }
    }
}
