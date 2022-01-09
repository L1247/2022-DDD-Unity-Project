#region

using System;
using Game.Actor.Scripts.Adapter.Controller;
using Game.Actor.Scripts.Adapter.EventHandlers;
using Game.Actor.Scripts.Application.Components;
using Game.Actor.Scripts.Application.Presenters;
using Game.Actor.Scripts.UseCase;
using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application.Installers
{
    public class ActorMonoInstaller : MonoInstaller
    {
    #region Private Variables

        [Inject]
        private Settings settings;

    #endregion

    #region Public Methods

        public override void InstallBindings()
        {
            // 4 Application Layer
            Container.BindInterfacesAndSelfTo<ActorSamplePresenter>().AsSingle();
            // 3 Adapter Layer
            Container.Bind<ActorController>().AsSingle();
            Container.Bind<ActorEventHandler>().AsSingle().NonLazy();
            // 2 UseCase Layer
            Container.Bind<CreateActorUseCase>().AsSingle();
            Container.Bind<IActorRepository>().To<ActorRepository>().AsSingle();

            // ObjectPool
            Container.Bind<ActorFactory>().AsSingle();
            Container.BindMemoryPool<ActorComponent , ActorComponent.Pool>()
                     .WithInitialSize(30)
                     .FromComponentInNewPrefab(settings.actorPrefab)
                     .UnderTransformGroup("Actors");
        }

    #endregion

    #region Nested Types

        [Serializable]
        public class Settings
        {
        #region Public Variables

            public GameObject actorPrefab;

        #endregion
        }

    #endregion
    }
}