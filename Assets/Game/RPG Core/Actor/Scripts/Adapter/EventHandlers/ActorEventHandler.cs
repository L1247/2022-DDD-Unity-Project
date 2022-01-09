#region

using DDDCore.Event;
using DDDCore.Implement;
using Game.RPG_Core.Actor.Scripts.Entity.ExposedClasses.Events;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Adapter.EventHandlers
{
    public class ActorEventHandler : DomainEventHandler
    {
    #region Private Variables

        [Inject]
        private IActorPresenter actorPresenter;

    #endregion

    #region Constructor

        public ActorEventHandler(IDomainEventBus domainEventBus) : base(domainEventBus)
        {
            Register<ActorCreated>(created => { actorPresenter.CreateActor(); });
        }

    #endregion
    }
}