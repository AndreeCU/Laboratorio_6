using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedEnemy : BaseEnemy, IAttackable, IDamageableExtended, IDropable
{
    #region Variables
    private Ability ability;
    #endregion

    #region Getter
    public Ability Ability => ability;
    #endregion

    #region Methods
    public void Set(string _entityName, string _description, int _maxHealth, int _maxMana, int _damage, int _defense, Ability _ability)
    {
        base.Set(_entityName, _description, _maxHealth, _maxMana, _damage, _defense);
        ability = _ability;
    }

    public void Set(string _entityName, Ability _ability) // Sobrecarga simple
    {
        base.Set(_entityName, "Descripción");
        ability = _ability;
    }

    private void CastAbility()
    {
        if (ability != null)
        {
            ability.Activate();
        }
    }

    public void Attack()
    {
        Debug.Log("Realiza un ataque normal");
        CastAbility();
    }

    public void ReceiveDamage(int amount)
    {
        Debug.Log("Recibio " + amount + " de daño");
    }

    public void DropItem()
    {
        Debug.Log(" Dejo caer un item aleatorio");
    }
    #endregion
}



