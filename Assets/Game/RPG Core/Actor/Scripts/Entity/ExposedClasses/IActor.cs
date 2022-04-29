#region

using DDDCore.Model;

#endregion

namespace RPG_Core.Actor.Entity.ExposedClasses
{
    public interface IActor : IAggregateRoot
    {
    #region Public Variables

        string DataId { get; }

    #endregion
    }
}