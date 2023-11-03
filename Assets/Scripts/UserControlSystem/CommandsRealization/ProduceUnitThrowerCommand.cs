using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;
using Zenject;

namespace UserControlSystem.CommandsRealization
{
    public class ProduceUnitThrowerCommand : IProduceUnitThrowerCommand
    {
        [Inject(Id = "GolemThrower")] public string UnitName { get; }
        [Inject(Id = "GolemThrower")] public Sprite Icon { get; }
        [Inject(Id = "GolemThrower")] public float ProductionTime { get; }

        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("GolemThrower")] private GameObject _unitPrefab;
    }
}
