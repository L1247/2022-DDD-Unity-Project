#region

using Game.Actor.Scripts.Application.Components;

#endregion

namespace Game.Actor.Scripts.Application.Presenters
{
    public class ActorFactory
    {
    #region Private Variables

        private readonly ActorComponent.Pool pool;

    #endregion

    #region Constructor

        public ActorFactory(ActorComponent.Pool pool)
        {
            this.pool = pool;
        }

    #endregion

    #region Public Methods

        public ActorComponent Create()
        {
            return pool.Spawn();
        }

    #endregion
    }
}