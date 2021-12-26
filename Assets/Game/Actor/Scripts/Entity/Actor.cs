#region

using DDDCore.Implement;

#endregion

namespace Game.Actor.Scripts.Entity
{
    public class Actor : AggregateRoot , IActor
    {
    #region Constructor

        public Actor(string id) : base(id) { }

    #endregion
    }
}