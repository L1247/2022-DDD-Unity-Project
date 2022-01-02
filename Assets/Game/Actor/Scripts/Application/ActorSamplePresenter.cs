#region

using AutoBot.Scripts.Utilities.Extensions;
using Game.Actor.Scripts.Adapter.Controller;
using Game.Actor.Scripts.Adapter.EventHandlers;
using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application
{
    public class ActorSamplePresenter : IInitializable , IActorPresenter
    {
    #region Private Variables

        [Inject]
        private ActorReferences actorReferences;

        [Inject]
        private ActorController actorController;

    #endregion

    #region Public Methods

        public void CreateActor()
        {
            var position = Random.onUnitSphere * 3;
            Object.Instantiate(actorReferences.ActorPrefab , position , Quaternion.identity);
        }

        public void Initialize()
        {
            actorReferences.CreateActorButton.BindClick(() => { actorController.CreateActor("123"); });
        }

    #endregion
    }
}