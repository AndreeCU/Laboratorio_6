using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotion : BaseItem, IConsumable
{
    #region Methods
    public void Consume()
    {
        Debug.Log("Consumiste la posión de mana y se restauro tu mana");
    }
    #endregion
}

