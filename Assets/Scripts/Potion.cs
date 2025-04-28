using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickable
{
    void Pick();
}
public interface IAttackable
{
    void Attack();
}

public interface IDamageableExtended
{
    void ReceiveDamage(int amount);
}

public interface IDropable
{
    void DropItem();
}

public class Potion : BaseObject, IPickable
{
    #region Methods
    public void Use()
    {
        Debug.Log("Potion is used to heal or buff!");
    }
    #endregion

    #region Interface
    public void Pick()
    {
        Debug.Log("Potion picked and added to inventory");
    }
    #endregion
}
