using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : BaseItem, IConsumable, IBuffable
{
    #region Methods
    public void Consume()
    {
        Debug.Log("La posión de salud fue consumida y la vida se restauro");
    }

    public void ApplyBuff()
    {
        Debug.Log("Conseguisto un buff adicional, un aumento en la resistencia en tu barra de vida");
    }
    #endregion
}