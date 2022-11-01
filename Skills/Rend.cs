using UnityEngine;
using System.Collections;
using TMPro;
public class Rend : MonoBehaviour
{
    Unit selfUnit;
    TextMeshProUGUI actionText;
    BattleSystem bs;
    ButtonsManager bm;
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

    public IEnumerator RendSkill()
    {
        if (!selfUnit.isBot)
            bm.TurnButtons(false);

        animator.SetBool("IsAttacking", true);

        selfUnit.target.currentHealth -= selfUnit.damage;

        actionText.text = selfUnit.unitName + " hit " + selfUnit.target.unitName + " for " + selfUnit.damage + " damage";

        yield return new WaitForSeconds(1f);
        animator.SetBool("IsAttacking", false);
        selfUnit.target.GetComponentInChildren<Animator>().SetBool("IsHit", true);
        yield return new WaitForSeconds(0.5f);
        selfUnit.target.GetComponentInChildren<Animator>().SetBool("IsHit", false);
        yield return new WaitForSeconds(0.5f);

        if (selfUnit.isBot)
            bs.PlayerTurn();
        else
            bs.EnemyTurn();

    }
}
