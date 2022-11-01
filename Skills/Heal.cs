using System.Collections;
using UnityEngine;
using TMPro;

public class Heal : MonoBehaviour
{
    Unit selfUnit;
    TextMeshProUGUI actionText;
    BattleSystem bs;
    ButtonsManager bm;

    public int manacost = 30;

    readonly int healingBase = 10; 
    void Start()
    {
        selfUnit = gameObject.GetComponent<Unit>();
        actionText = GameObject.Find("ActionText").GetComponent<TextMeshProUGUI>();
        bs = GameObject.Find("BattleSystem").GetComponent<BattleSystem>();
        bm = GameObject.Find("PlayerOptions").GetComponent<ButtonsManager>();
    }

    public IEnumerator HealSkill()
    {
        if (!selfUnit.isBot)
            bm.TurnButtons(false);


        int prevHP = selfUnit.currentHealth;

        if (manacost <= selfUnit.currentMana)
        {
            selfUnit.currentHealth += healingBase;
            selfUnit.currentMana -= manacost;
        }
        else
        {
            bm.button[1].interactable = false;
            Debug.Log("Not enough mana");
        }
        if (selfUnit.currentHealth >= selfUnit.maxHealth)
            selfUnit.currentHealth = selfUnit.maxHealth;

        int amountHealed = selfUnit.currentHealth - prevHP;

        actionText.text = selfUnit.unitName + " healed himself for " + amountHealed + " HP";

        yield return new WaitForSeconds(2f);
        if (selfUnit.isBot)
            bs.PlayerTurn();
        else
            bs.EnemyTurn();

    }
    public void CastHeal()
    {
        StartCoroutine(HealSkill());
    }
}
