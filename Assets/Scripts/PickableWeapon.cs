using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableWeapon : BaseWeapon, IPickable
{
    #region Interface
    public void Pick()
    {
        Debug.Log("Weapon picked and added to inventory");
    }
    #endregion
}