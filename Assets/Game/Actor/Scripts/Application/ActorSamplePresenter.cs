#region

using AutoBot.Scripts.Utilities.Extensions;
using Game.Actor.Scripts.Adapter.Controller;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application
{
    public class ActorSamplePresenter : IInitializable
    {
    #region Private Variables

        [Inject]
        private ActorReferences actorReferences;

        [Inject]
        private ActorController actorController;

    #endregion

    #region Public Methods

        public void Initialize()
        {
            actorReferences.CreateActorButton.BindClick(() => { actorController.CreateActor(); });
        }

    #endregion
    }
}