#region

using Game.Actor.Scripts.Adapter.EventHandlers;
using Game.Actor.Scripts.Application.Presenters;
using Zenject;

#endregion

namespace Game.RPG_Core.Actor.Scripts.Application.Flows
{
    public class ActorFlow : IActorFlow
    {
    #region Private Variables

        [Inject]
        private ActorFactory actorFactory;

        [Inject]
        private ActorSamplePresenter actorPresenter;

    #endregion

    #region Public Methods

        public void WhenActorCreated(string dataId)
        {
            // Create actor instances with factor.
            var actorComponent = actorFactory.Create();
            // Display actor details by presenter.
            actorPresenter.ShowActor(actorComponent , dataId);
            actorPresenter.ShowActorCount();
        }

    #endregion
    }
}