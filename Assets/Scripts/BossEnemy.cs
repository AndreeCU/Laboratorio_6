using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossEnemy : AdvancedEnemy
{
    #region Methods
    public new void Attack()
    {
        Debug.Log("El jefe realizo un ataque devastador");
    }

    public void SummonMinions()
    {
        Debug.Log("El jefe genero aliados para defenderlo");
    }
    #endregion
}
