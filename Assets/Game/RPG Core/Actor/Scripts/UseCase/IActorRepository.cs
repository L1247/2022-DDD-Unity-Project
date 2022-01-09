#region

using DDDCore.Event.Usecase;
using Game.Actor.Scripts.Entity;

#endregion

namespace Game.Actor.Scripts.UseCase
{
    public interface IActorRepository : IRepository<IActor> { }
}