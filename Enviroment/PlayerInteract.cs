using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public BattleEnabler be;
    Unit playerUnit;
    public GameObject ePanel;
    void Start()
    {
        be = GameObject.Find("GameManager").GetComponent<BattleEnabler>();
        playerUnit = gameObject.GetComponent<Unit>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            be.EnableBattle(col.transform);
            //gameObject.GetComponent<Unit>().target = col.GetComponent<Unit>();
        }
        else if(col.tag == "Friendly")
        {
            Debug.Log("friendly");
        }

    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                ePanel.SetActive(true);
                Debug.Log("Target Name: " + hit.collider.gameObject.name);
                playerUnit.target = hit.collider.GetComponent<Unit>();
                
            }
        }
    }
}
