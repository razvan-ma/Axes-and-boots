using System.Collections;
using TMPro;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Unit selfUnit;
    private TextMeshProUGUI actionText;
    private BattleSystem bs;
    private ButtonsManager bm;
    public Animator animator;
    public Animation anim;
    void Start()
    {
        selfUnit = gameObject.GetComponent<Unit>();
        actionText = GameObject.Find("ActionText").GetComponent<TextMeshProUGUI>();
        bs = GameObject.Find("BattleSystem").GetComponent<BattleSystem>();
        bm = GameObject.Find("PlayerOptions").GetComponent<ButtonsManager>();
        animator = gameObject.GetComponentInChildren<Animator>();
    }
    
    public IEnumerator AttackSkill()
    {
        if (!selfUnit.isBot)
            bm.TurnButtons(false);

        animator.SetBool("IsAttacking", true);

        int dmgdealt;

        if (selfUnit.Critical(selfUnit.critChance) == false)
        {
            dmgdealt = selfUnit.damage;
            selfUnit.target.currentHealth -= dmgdealt;
        }
        else
        {   
            dmgdealt = Mathf.RoundToInt(selfUnit.damage * 1.5f);   
            selfUnit.target.currentHealth -= dmgdealt;
        }

        actionText.text = selfUnit.unitName + " hit " + selfUnit.target.unitName + " for " + dmgdealt + " damage";

        yield return new WaitForSeconds(1f);
        animator.SetBool("IsAttacking", false);
        selfUnit.target.GetComponentInChildren<Animator>().SetBool("IsHit",true);
        yield return new WaitForSeconds(0.5f);
        selfUnit.target.GetComponentInChildren<Animator>().SetBool("IsHit", false);
        yield return new WaitForSeconds(0.5f);

        if (selfUnit.isBot)
            bs.PlayerTurn();
        else
            bs.EnemyTurn();

        if(selfUnit.currentMana < selfUnit.maxMana - 5)
            selfUnit.currentMana += 5;

    }
    public void CastAttack()
    {
        StartCoroutine(AttackSkill());
    }
}
