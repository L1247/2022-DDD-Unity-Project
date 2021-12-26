#region

using DDDCore.Implement;
using Game.Actor.Scripts.Entity.Events;

#endregion

namespace Game.Actor.Scripts.Entity
{
    public class Actor : AggregateRoot , IActor
    {
    #region Constructor

        public Actor(string id) : base(id)
        {
            var actorCreated = new ActorCreated(id);
            AddDomainEvent(actorCreated);
        }

    #endregion
    }
}