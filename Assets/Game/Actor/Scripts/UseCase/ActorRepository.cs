#region

using DDDCore.Implement;
using Game.Actor.Scripts.Entity;

#endregion

namespace Game.Actor.Scripts.UseCase
{
    public class ActorRepository : AbstractRepository<IActor> , IActorRepository { }
}