using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    #region Variables
    private string abilityName;
    private int power;
    #endregion

    #region Getters
    public string AbilityName => abilityName;
    public int Power => power;
    #endregion

    #region Methods
    public void Set(string _abilityName, int _power)
    {
        abilityName = _abilityName;
        power = _power;
    }

    public void Activate()
    {
        Debug.Log("Habilidad activada: " + abilityName + " con el poder: " + power);
    }
    #endregion
}

