using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    private List<AdvancedEnemy> enemies = new List<AdvancedEnemy>();
    private List<BaseItem> inventory = new List<BaseItem>();
    #endregion

    #region Methods
    private void Start()
    {
        InitializeEnemies();
        InitializeItems();

        SimulateBattle();
        SimulateItemUsage();
    }
    #endregion

    #region Private Methods
    private void InitializeEnemies()
    {
        Ability fireball = new Ability();
        fireball.Set("Bola de Fuego", 30);

        Ability iceBlast = new Ability();
        iceBlast.Set("Explosión de hielo", 20);

        AdvancedEnemy goblin = new AdvancedEnemy();
        goblin.Set("Goblin", "Pequeño oponente", 100, 50, 10, 5, fireball);

        BossEnemy dragon = new BossEnemy();
        dragon.Set("Dragon", "Criatura Ascendida", 500, 200, 50, 20, iceBlast);

        enemies.Add(goblin);
        enemies.Add(dragon);
    }

    private void InitializeItems()
    {
        HealthPotion healthPotion = new HealthPotion();
        healthPotion.Set("Posión de Vida", "Vida restaurada", 1);

        ManaPotion manaPotion = new ManaPotion();
        manaPotion.Set("Posión de mana", "Mana restaurado", 1);

        inventory.Add(healthPotion);
        inventory.Add(manaPotion);
    }

    private void SimulateBattle()
    {
        foreach (AdvancedEnemy enemy in enemies)
        {
            Debug.Log("Nombre del enemigo: " + enemy.EntityName);

            enemy.Attack();
            enemy.ReceiveDamage(25);
            enemy.DropItem();
        }
    }

    private void SimulateItemUsage()
    {
        foreach (BaseItem item in inventory)
        {
            Debug.Log("Item: " + item.EntityName);

            if (item is IConsumable consumableItem)
            {
                consumableItem.Consume();
            }

            if (item is IBuffable buffableItem)
            {
                buffableItem.ApplyBuff();
            }
        }
    }
    #endregion
}

