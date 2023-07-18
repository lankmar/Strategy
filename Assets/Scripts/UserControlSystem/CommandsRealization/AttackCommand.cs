using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;

public sealed class AttackCommand : CommandExecutorBase<IAttackCommand>
{
    public override void ExecuteSpecificCommand(IAttackCommand command)
    {
        UnityEngine.Debug.Log("Attack");
    }
}