#region

using DDDCore.Implement;

#endregion

namespace Game.Actor.Scripts.Entity.Events
{
    public class ActorCreated : DomainEvent
    {
    #region Public Variables

        public string actorId;

    #endregion

    #region Constructor

        public ActorCreated(string actorId)
        {
            this.actorId = actorId;
        }

    #endregion
    }
}