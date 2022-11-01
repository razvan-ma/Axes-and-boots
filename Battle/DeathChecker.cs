using UnityEngine;

public class DeathChecker : MonoBehaviour
{
    Unit eunit = null, punit;
    BattleSystem bs;
    //public ItemDatabase db;
    void Start()
    {
        bs = gameObject.GetComponent<BattleSystem>();
        punit = GameObject.FindGameObjectWithTag("Player").GetComponent<Unit>();
    }
    void Update()
    {
        eunit = punit.target;
        if (punit.target)
        {
            eunit = punit.target;
            if (eunit.currentHealth <= 0)
            {  
                eunit.currentHealth = 0;
                eunit.isDead = true;
                bs.state = BattleState.WON;
                

            }
            else if (punit.currentHealth <= 0)
            {
                punit.currentHealth = 0;
                punit.isDead = true;
                bs.state = BattleState.LOST;
            }
        }
    }
    
}
