using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class LevelSystem : MonoBehaviour
{
    public int requiredXp = 100;
    public int currentXp = 0;
    public Slider xpSlider;
    public TextMeshProUGUI levelText;
    private Unit player;
    void Start()
    {
        player = gameObject.GetComponent<Unit>();
    }
    void Update()
     {  
        UpdateXpUI();

        if (Input.GetKeyDown(KeyCode.Equals))
            GainXp(20);
        if (currentXp >= requiredXp)
        {
            LevelUp();
        }
    }
    public void UpdateXpUI()
    {
        xpSlider.maxValue = requiredXp;
        xpSlider.value = currentXp;
    }
    public void GainXp(int amount)
    {
        currentXp += amount;

    }
    public void LevelUp()
    {
        player.level++;
        currentXp -= requiredXp;
        //stats increase
        player.maxHealth += 10;
        player.currentHealth += 10;

        player.maxMana += 5;
        player.currentMana += 5;

        player.damage++;


        requiredXp += player.level * 10;



        levelText.text = player.level.ToString();
    }

}
