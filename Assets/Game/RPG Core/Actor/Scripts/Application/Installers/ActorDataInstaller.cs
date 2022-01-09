#region

using Game.RPG_Core.Actor.Scripts.Datas;
using UnityEngine;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Application.Installers
{
    public class ActorDataInstaller : ScriptableObjectInstaller
    {
    #region Private Variables

        [SerializeField]
        private ActorMonoInstaller.Settings actorMonoInstallerSettings;

        [SerializeField]
        private ActorDataOverview overview;

    #endregion

    #region Public Methods

        public override void InstallBindings()
        {
            Container.BindInstance(actorMonoInstallerSettings);
            Container.BindInstance(overview);
        }

    #endregion
    }
}