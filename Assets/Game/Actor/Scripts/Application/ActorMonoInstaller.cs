#region

using DDDCore.Implement;
using Game.Actor.Scripts.Adapter.Controller;
using Game.Actor.Scripts.Adapter.EventHandlers;
using Game.Actor.Scripts.UseCase;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application
{
    public class ActorMonoInstaller : MonoInstaller
    {
    #region Public Methods

        public override void InstallBindings()
        {
            DDDInstaller.Install(Container);
            // 4 Application Layer
            Container.BindInterfacesAndSelfTo<ActorSamplePresenter>().AsSingle();
            // 3 Adapter Layer
            Container.Bind<ActorController>().AsSingle();
            Container.Bind<ActorEventHandler>().AsSingle().NonLazy();
            // 2 UseCase Layer
            Container.Bind<CreateActorUseCase>().AsSingle();
            Container.Bind<IActorRepository>().To<ActorRepository>().AsSingle();
        }

    #endregion
    }
}