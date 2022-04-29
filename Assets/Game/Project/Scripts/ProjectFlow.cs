#region

using UnityEngine;
using Zenject;

#endregion

public class ProjectFlow : IInitializable
{
#region Public Methods

    public void Initialize()
    {
        Application.targetFrameRate = 60;
    }

#endregion
}