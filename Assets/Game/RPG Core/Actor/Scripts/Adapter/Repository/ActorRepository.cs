#region

using DDDCore.Implement;
using Game.Actor.Scripts.UseCase;
using RPG_Core.Actor.Entity.ExposedClasses;

#endregion

namespace Game.RPG_Core.Actor.Adapter.Repository
{
    public class ActorRepository : AbstractRepository<IActor> , IActorRepository { }
}