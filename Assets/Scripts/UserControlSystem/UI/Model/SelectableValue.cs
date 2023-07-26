using System;
using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObjectValueBase<ISelectable>
    {

    }
    //[CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    //public class SelectableValue : ScriptableObjectValueBase<ISelectable>
    //{
    //    public ISelectable CurrentValue { get; private set; }
    //    public Action<ISelectable> OnSelected;

    //    public void SetValue(ISelectable value)
    //    {
    //        CurrentValue = value;
    //        OnSelected?.Invoke(value);
    //    }
    //}
}