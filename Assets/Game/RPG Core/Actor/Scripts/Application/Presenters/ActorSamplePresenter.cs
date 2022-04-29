#region

using AutoBot.Scripts.Utilities.Extensions;
using Game.Actor.Scripts.Adapter.Controller;
using Game.Actor.Scripts.Application.Components;
using Game.RPG_Core.Actor.Scripts.Datas;
using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application.Presenters
{
    public class ActorSamplePresenter : IInitializable
    {
    #region Private Variables

        [Inject]
        private ActorReferences actorReferences;

        [Inject]
        private ActorController actorController;

        [Inject]
        private ActorDataOverview actorDataOverview;

    #endregion

    #region Public Methods

        public void Initialize()
        {
            actorReferences.CreateActorButton.BindClick(() =>
            {
                var randomData = actorDataOverview.GetRandomData();
                actorController.CreateActor(randomData.DataId);
            });
        }

        public void ShowActor(ActorComponent actorComponent , string dataId)
        {
            var position = Random.onUnitSphere * 3;
            actorComponent.SetPosition(position);
            var actorData = actorDataOverview.GetData(dataId);
            if (actorData == null) return;
            actorComponent.SetSprite(actorData.MainSprite);
        }

        public void ShowActorCount()
        {
            var countText = actorReferences.ActorCountText;
            var allActor  = actorController.GetAllActor();
            countText.text = $"Actor Count: {allActor.Count}";
        }

    #endregion
    }
}