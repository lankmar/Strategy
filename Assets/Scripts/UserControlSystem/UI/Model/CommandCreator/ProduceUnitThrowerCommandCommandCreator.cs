using System;
using Abstractions.Commands.CommandsInterfaces;
using UserControlSystem.CommandsRealization;
using Utils;
using Zenject;

namespace UserControlSystem
{
    public sealed class ProduceUnitThrowerCommandCommandCreator : CommandCreatorBase<IProduceUnitThrowerCommand>
    {
        [Inject] private AssetsContext _context;
        [Inject] private DiContainer _diContainer;

        protected override void ClassSpecificCommandCreation(Action<IProduceUnitThrowerCommand> creationCallback)
        {
            var produceUnitCommand = _context.Inject(new ProduceUnitThrowerCommandHeir());
            _diContainer.Inject(produceUnitCommand);
            creationCallback?.Invoke(produceUnitCommand);
        }
    }
}