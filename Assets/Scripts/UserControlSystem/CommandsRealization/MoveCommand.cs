using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class MoveCommand : CommandExecutorBase<IMoveCommand> 
    {

        public override void ExecuteSpecificCommand(IMoveCommand command)
        {
            UnityEngine.Debug.Log("Move");
        }
    }
}