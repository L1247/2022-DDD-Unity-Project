#region

using DDDCore.Implement;

#endregion

namespace Game.Actor.Scripts.Entity.Events
{
    public class ActorCreated : DomainEvent
    {
    #region Public Variables

        public string actorDataId;

        public string actorId;

    #endregion

    #region Constructor

        public ActorCreated(string actorId , string actorDataId)
        {
            this.actorId     = actorId;
            this.actorDataId = actorDataId;
        }

    #endregion
    }
}