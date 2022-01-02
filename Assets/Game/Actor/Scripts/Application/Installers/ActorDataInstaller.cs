#region

using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application.Installers
{
    [CreateAssetMenu]
    public class ActorDataInstaller : ScriptableObjectInstaller
    {
    #region Public Variables

        public ActorMonoInstaller.Settings actorMonoInstallerSettings;

    #endregion

    #region Public Methods

        public override void InstallBindings()
        {
            Container.BindInstance(actorMonoInstallerSettings);
        }

    #endregion
    }
}