using UnityEngine;
public interface IDamageable
{
    public void GetDamage();
}
public class BaseEnemy : BaseEntity, IDamageable
{
    #region Settings
    private int maxHealth;
    private int maxMana;
    private int damage;
    private int defense;
    #endregion
    #region Variables
    private int currentHealth;
    private int currentMana;
    #endregion
    #region Getters
    public int MaxHealth => maxHealth;
    public int MaxMana => maxMana;
    public int Damage => damage;
    public int Defense => defense;
    #endregion

    #region Methods
    public void Set(string _entityName, string _description, int _maxHealth, int _maxMana, int _damage, int _defense)
    {
        base.Set(_entityName, _description);
        maxHealth = _maxHealth;
        maxMana = _maxMana;
        damage = _damage;
        defense = _defense;

        currentHealth = maxHealth;
        currentMana = maxMana;
    }
    #region Interfaces
    public void GetDamage()
    {
        Debug.Log("Enemy got damage");
    }
    #endregion
    #endregion


}

