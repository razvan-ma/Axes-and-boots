using TMPro;
using UnityEngine;

public class BattleEnabler : MonoBehaviour
{
    public Transform playerPad;
    public Transform enemyPad;
    public GameObject player;
    public GameObject cam;
    private BattleSystem bs;
    public GameObject enemyPanel;
    public GameObject playerPanel;
    void Start()
    {
        bs = GameObject.Find("BattleSystem").GetComponent<BattleSystem>();
    }
    public void EnableBattle(Transform enemy)
    {
        cam.GetComponent<Camera>().orthographicSize = 4;
        player.GetComponent<Movement>().enabled = false;
        
        player.GetComponent<Movement>().animator.SetBool("IsRunning", false);
        
        cam.GetComponent<CameraFollow>().enabled = false;

        player.GetComponent<Transform>().position = playerPad.position;
        //merge schimbat fara parametru
        enemy.position = enemyPad.position;
        bs.enabled = true;
    }
    public void DisableBattle()
    {
        cam.GetComponent<Camera>().orthographicSize = 4;
        bs.actionText.text = " ";
        player.GetComponent<Movement>().enabled = true;
        cam.GetComponent<CameraFollow>().enabled = true;
        //bs.state = BattleState.START;
        bs.enabled = false;
    }
}
