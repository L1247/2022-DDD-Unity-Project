#region

using Zenject;

#endregion

namespace Game.Actor.Scripts.Application
{
    public class ActorMonoInstaller : MonoInstaller
    {
    #region Public Methods

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ActorSamplePresenter>().AsSingle();
        }

    #endregion
    }
}