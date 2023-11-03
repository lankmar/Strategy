using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;
using Zenject;

namespace UserControlSystem.CommandsRealization
{
    public class HealthBuildingUpgradeCommand : IHealthBuildingUpgrade
    {
        public float Health { get; }

        public float MaxHealth { get; }
    }
}
