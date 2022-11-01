using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterPanel : MonoBehaviour
{
    public Unit player;
    TextMeshProUGUI spellPower;
    void Start()
    {
        //spellPower = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }
    void Update()
    {
        //spellPower.text = "Spell Power: " + player.spellPower.ToString();
    }
}
