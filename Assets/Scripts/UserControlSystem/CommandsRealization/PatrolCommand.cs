using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class PatrolCommand : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            UnityEngine.Debug.Log("Patrol");
        }
    }
}