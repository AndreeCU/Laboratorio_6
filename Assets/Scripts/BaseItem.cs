using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConsumable
{
    void Consume();
}

public interface IBuffable
{
    void ApplyBuff();
}

public class BaseItem : BaseEntity
{
    #region Settings
    private int weight;
    #endregion

    #region Getters
    public int Weight => weight;
    #endregion

    #region Methods
    public void Set(string _entityName, string _description, int _weight)
    {
        base.Set(_entityName, _description);
        weight = _weight;
    }
    #endregion
}




