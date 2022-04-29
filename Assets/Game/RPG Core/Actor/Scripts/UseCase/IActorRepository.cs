#region

using DDDCore.Event.Usecase;
using RPG_Core.Actor.Entity.ExposedClasses;

#endregion

namespace Game.Actor.Scripts.UseCase
{
    public interface IActorRepository : IRepository<IActor> { }
}