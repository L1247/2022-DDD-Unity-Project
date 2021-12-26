#region

using System;
using DDDCore.Event;
using DDDCore.Implement;
using DDDCore.Usecase.CQRS;
using ThirtyParty.DDDCore.Implement.CQRS;
using ThirtyParty.DDDCore.Usecase;

#endregion

namespace Game.Actor.Scripts.UseCase
{
    public class CreateActorUseCase : UseCase<CreateActorInput , CqrsCommandPresenter , IActorRepository>
    {
    #region Constructor

        public CreateActorUseCase(IDomainEventBus domainEventBus , IActorRepository repository) : base(domainEventBus , repository) { }

    #endregion

    #region Public Methods

        public override void Execute(CreateActorInput input , CqrsCommandPresenter output)
        {
            var id    = Guid.NewGuid().ToString();
            var actor = new Entity.Actor(id);
            repository.Save(actor);

            domainEventBus.PostAll(actor);

            output.SetId(id);
            output.SetExitCode(ExitCode.SUCCESS);
        }

    #endregion
    }

    public class CreateActorInput : Input { }
}