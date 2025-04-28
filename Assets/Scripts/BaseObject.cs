using System.Collections.Generic;
using UnityEngine;

public class BaseObject : BaseEntity, IDamageable
{
    #region Settings
    private int tickLife;
    private List<BaseObject> dropList = new List<BaseObject>();
    #endregion
    #region Getters
    public int TickLife => tickLife;
    public List<BaseObject> DropList => dropList;
    #endregion

    #region Methods

    public void Set(string _entityName, string _description, int _tickLife, List<BaseObject> _dropList)
    {
        base.Set(_entityName, _description);
        tickLife = _tickLife;
        dropList = _dropList;

    }
    #region Interface
    public void GetDamage()
    {
        Debug.Log("Object GotDamage");
    }
    #endregion
    #endregion
}

