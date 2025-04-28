using UnityEngine;
public class HeavyEnemy : BaseEnemy
{
    #region Methods
    public void Attack()
    {
        Debug.Log("HeavyEnemy performs a strong attack!");
    }
    public void Move()
    {
        Debug.Log("HeavyEnemy moves slowly but steadily");
    }
    #endregion
}
