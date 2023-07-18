using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;

namespace UserControlSystem.CommandsRealization
{
    public sealed class StopCommand : CommandExecutorBase<IStopCommand>
    {
        public override void ExecuteSpecificCommand(IStopCommand command)
        {
            UnityEngine.Debug.Log("Stop");
        }
    }
}