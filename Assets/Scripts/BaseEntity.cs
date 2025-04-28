using UnityEngine;

public class BaseEntity
{
    #region Variables
    private string entityName;
    private string description;
    #endregion

    #region Getters
    public string EntityName => entityName;
    public string Description => description;
    #endregion
    #region Methods
    public void Set(string _entityName, string _description)
    {
        entityName = _entityName;
        description = _description;
    }
    #endregion
}
