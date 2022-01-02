#region

using DDDCore.Implement;
using Game.Actor.Scripts.Entity.Events;

#endregion

namespace Game.Actor.Scripts.Entity
{
    public class Actor : AggregateRoot , IActor
    {
    #region Public Variables

        public string DataId { get; }

    #endregion

    #region Constructor

        public Actor(string id , string dataId) : base(id)
        {
            DataId = dataId;
            var actorCreated = new ActorCreated(id , DataId);
            AddDomainEvent(actorCreated);
        }

    #endregion
    }
}