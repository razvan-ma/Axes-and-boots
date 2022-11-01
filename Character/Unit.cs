using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;

    [Header("Stats")]
    public int level = 1;
    public int maxHealth;
    public int currentHealth;

    public int maxMana;
    public int currentMana;

    public int damage;
    public float critChance;

    [Header("Logic")]
    public int xpGain;
    [HideInInspector] public bool isBot;
    public Unit target = null;
    private Unit playerUnit;
    [HideInInspector] public bool isDead;
    //setting up targets
    void Start()
    {
        playerUnit = GameObject.FindWithTag("Player").GetComponent<Unit>();
        if (gameObject.tag == "Enemy")
        {
            isBot = true;
            target = playerUnit;
            xpGain = 20 + level * 10;
        }
        else
            isBot = false;
        
    }   
    public bool Critical(float chance)
    {
        float number;
        number = Random.Range(1f, 100f);
        number = Mathf.RoundToInt(number);
        for (int i = 0; i <= chance; i++)
        {
            if (i == number)
                return true;
        }
        return false;
    }
    
}
