#region

using AutoBot.Scripts.Utilities.Extensions;
using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application
{
    public class ActorSamplePresenter : IInitializable
    {
    #region Private Variables

        [Inject]
        private ActorReferences actorReferences;

    #endregion

    #region Public Methods

        public void Initialize()
        {
            actorReferences.CreateActorButton.BindClick(() => { Debug.Log("CreateActor"); });
        }

    #endregion
    }
}