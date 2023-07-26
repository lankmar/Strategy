using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Transform PivotPoint => _pivotPoint;
    public Sprite Icon => _icon;

    private int _timeUnitCreation = 2000;

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Transform _pivotPoint;

    private float _health = 1000;

    //public override void ExecuteSpecificCommand(IProduceUnitCommand command) 
    //    => Instantiate(command.UnitPrefab, 
    //        new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), 
    //        Quaternion.identity, 
    //        _unitsParent);

    public override async void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        await Task.Delay(_timeUnitCreation);
        Instantiate(command.UnitPrefab,
              new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)),
              Quaternion.identity,
              _unitsParent);
    }
}