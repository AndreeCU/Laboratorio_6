using UnityEngine;

public class FastEnemy : BaseEnemy
{
    #region Methods
    public void Attack()
    {
        Debug.Log("FastEnemy attacks quickly!");
    }
    public void Move()
    {
        Debug.Log("FastEnemy moves swiftly");
    }
    #endregion
}

