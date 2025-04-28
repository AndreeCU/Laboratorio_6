using UnityEngine;

public class BaseWeapon : BaseEntity
{
    #region Settings
    private int baseDamage;
    #endregion

    #region Getters
    public int BaseDamage => baseDamage;
    #endregion

    #region Methods
    public void Set(string _entityName, string _description, int _baseDamage)
    {
        base.Set(_entityName, _description);
        baseDamage = _baseDamage;
    }

    public virtual void Attack()
    {
        Debug.Log("Base weapon attacks dealing basic damage");
    }
    #endregion
}
