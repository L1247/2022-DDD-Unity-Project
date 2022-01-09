#region

using AutoBot.Scripts.Utilities.Extensions;
using Game.Actor.Scripts.Adapter.Controller;
using Game.Actor.Scripts.Adapter.EventHandlers;
using Game.RPG_Core.Actor.Scripts.Datas;
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

        [Inject]
        private ActorDataOverview actorDataOverview;

    #endregion

    #region Public Methods

        public void CreateActor(string dataId)
        {
            var actorComponent = actorFactory.Create();
            var position       = Random.onUnitSphere * 3;
            actorComponent.SetPosition(position);
            var actorData = actorDataOverview.GetData(dataId);
            if (actorData == null) return;
            actorComponent.SetSprite(actorData.MainSprite);
        }

        public void Initialize()
        {
            actorReferences.CreateActorButton.BindClick(() =>
            {
                var randomData = actorDataOverview.GetRandomData();
                actorController.CreateActor(randomData.DataId);
            });
        }

    #endregion
    }
}