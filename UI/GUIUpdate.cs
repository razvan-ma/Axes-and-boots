using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GUIUpdate : MonoBehaviour
{
    /*
    7.07.2022
    teoretic daca ai vrea sa accesezi vreun text, slider ceva, le poti accesa de aici,
    unde sunt toate centralizate frumos, dar le am pus public ca face fite la warninguri,
    mainly, dupa mi-am dat seama ca e mai bun asa, ig??
    - primul cod modificat dupa un an de faculate pog
    */
    public TextMeshProUGUI enemyHealth;
    public TextMeshProUGUI playerHealth;

    public TextMeshProUGUI enemyMana;
    public TextMeshProUGUI playerMana;

    public TextMeshProUGUI enemyName;
    public TextMeshProUGUI playerName;

    public Slider pHPSlider;
    public Slider eHPSlider;

    public Slider pMPSlider;
    public Slider eMPSlider;

    private Unit enemy;
    private Unit player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Unit>();
    }

    void Update()
    {
            enemy = player.target;
            playerHealth.text = player.currentHealth.ToString() + " / " + player.maxHealth.ToString();
            playerMana.text = player.currentMana.ToString() + " / " + player.maxMana.ToString();
            pHPSlider.maxValue = player.maxHealth;
            pMPSlider.maxValue = player.maxMana;
            pHPSlider.value = player.currentHealth;
            pMPSlider.value = player.currentMana;  
            playerName.text = player.unitName;

            if(enemy)
        {
            enemyHealth.text = enemy.currentHealth.ToString() + " / " + enemy.maxHealth.ToString();
            enemyMana.text = enemy.currentMana.ToString() + " / " + enemy.maxMana.ToString();
            eHPSlider.maxValue = enemy.maxHealth;
            eMPSlider.maxValue = enemy.maxMana;
            eHPSlider.value = enemy.currentHealth;
            eMPSlider.value = enemy.currentMana;
            enemyName.text = enemy.unitName;
        }
            else
                {
                   
                }

    }
}
