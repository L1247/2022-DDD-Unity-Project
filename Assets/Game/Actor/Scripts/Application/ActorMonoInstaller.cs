#region

using DDDCore.Implement;
using Game.Actor.Scripts.Adapter.Controller;
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
            // 4
            Container.BindInterfacesAndSelfTo<ActorSamplePresenter>().AsSingle();
            // 3
            Container.Bind<ActorController>().AsSingle();
            // 2
            Container.Bind<CreateActorUseCase>().AsSingle();
            Container.Bind<IActorRepository>().To<ActorRepository>().AsSingle();
        }

    #endregion
    }
}