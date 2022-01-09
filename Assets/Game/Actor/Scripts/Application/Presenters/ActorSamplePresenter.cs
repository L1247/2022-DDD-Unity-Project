#region

using AutoBot.Scripts.Utilities.Extensions;
using Game.Actor.Scripts.Adapter.Controller;
using Game.Actor.Scripts.Adapter.EventHandlers;
using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application.Presenters
{
    public class ActorSamplePresenter : IInitializable , IActorPresenter
    {
    #region Private Variables

        [Inject]
        private ActorReferences actorReferences;

        [Inject]
        private ActorController actorController;

        [Inject]
        private ActorFactory actorFactory;

    #endregion

    #region Public Methods

        public void CreateActor()
        {
            var actorComponent = actorFactory.Create();
            var position       = Random.onUnitSphere * 3;
            actorComponent.SetPosition(position);
        }

        public void Initialize()
        {
            actorReferences.CreateActorButton.BindClick(() => actorController.CreateActor("123"));
        }

    #endregion
    }
}