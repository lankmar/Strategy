using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;
using Zenject;

namespace UserControlSystem.CommandsRealization
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        [Inject(Id = "Golem")] public string UnitName { get; }
        [Inject(Id = "Golem")] public Sprite Icon { get; }
        [Inject(Id = "Golem")] public float ProductionTime { get; }

        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("Golem")] private GameObject _unitPrefab;
    }
}