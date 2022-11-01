using System.Collections;
using TMPro;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST };
public class BattleSystem : MonoBehaviour
{
    private Unit playerUnit;
    public TextMeshProUGUI actionText;
    public BattleEnabler be;
    public ButtonsManager bm;   
    [HideInInspector] public BattleState state;
    void Awake()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());

        GameObject playerGO = GameObject.FindWithTag("Player");
        playerUnit = playerGO.GetComponent<Unit>();
    }

    IEnumerator SetupBattle()
    {
        yield return new WaitForSeconds(1f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }
    public void PlayerTurn()   
    {
        EndBattle();
        bm.TurnButtons(true);
        state = BattleState.PLAYERTURN;
    }
    
    
    public void EnemyTurn()
    {
        EndBattle();
        state = BattleState.ENEMYTURN;
        playerUnit.target.GetComponent<EnemyAI>().AIAction();
    }
    public void EndBattle()
    {
        if (state == BattleState.WON)
        {
            be.DisableBattle();
            playerUnit.gameObject.GetComponent<LevelSystem>().GainXp(playerUnit.target.xpGain);
            Destroy(playerUnit.target.gameObject);
            
        }
        else if (state == BattleState.LOST)
        {
            be.DisableBattle();
            Destroy(playerUnit.gameObject);

            //nu cred ca destroy :)
        }
    } 
    //pana aici
}
