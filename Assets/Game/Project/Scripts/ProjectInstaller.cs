#region

using rStarUtility.DDDCore.Implement.Core;
using Zenject;

#endregion

public class ProjectInstaller : MonoInstaller
{
#region Public Methods

    public override void InstallBindings()
    {
        DDDInstaller.Install(Container);
        Container.BindInterfacesTo<ProjectFlow>().AsSingle();
    }

#endregion
}