using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    
    Unit enemy;
    Attack attack;
    Heal heal;
    void Start()
    {
        enemy = gameObject.GetComponent<Unit>();
        attack = gameObject.GetComponent<Attack>();
        heal = gameObject.GetComponent<Heal>();
    }
    public void AIAction()
    {
        if (enemy.currentHealth < enemy.maxHealth / 4 && enemy.currentMana >= heal.manacost)
        {
            StartCoroutine(heal.HealSkill());
        }
        else
        {
            StartCoroutine(attack.AttackSkill());
        }
    }



}
