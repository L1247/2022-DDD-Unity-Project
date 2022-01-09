#region

using DDDCore.Usecase.CQRS;
using Game.Actor.Scripts.UseCase;
using ThirtyParty.DDDCore.Implement.CQRS;
using Utilities.Contract;
using Zenject;

#endregion

namespace Game.Actor.Scripts.Adapter.Controller
{
    public class ActorController
    {
    #region Private Variables

        [Inject]
        private CreateActorUseCase createActorUseCase;

    #endregion

    #region Public Methods

        public CqrsCommandPresenter CreateActor(string actorDataId)
        {
            var input = new CreateActorInput();
            input.actorDataId = actorDataId;
            var output = new CqrsCommandPresenter();
            createActorUseCase.Execute(input , output);
            var exitCode = output.GetExitCode();
            Contract.Ensure(exitCode == ExitCode.SUCCESS , "ExitCode should be success");
            return output;
        }

    #endregion
    }
}