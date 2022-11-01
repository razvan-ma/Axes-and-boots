using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    [HideInInspector] public Button[] button;
    public BattleSystem bs;
    private void Start()
    {
        button = new Button[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            button[i] = transform.GetChild(i).gameObject.GetComponent<Button>();

    }
    public void TurnButtons(bool active)
    {
        if (active)
            foreach (var button in button)
                button.interactable = true;
        else
            foreach (var button in button)
                button.interactable = false;
    }
    void Update()
    {
        if (bs.isActiveAndEnabled)
            foreach (var button in button)
                button.gameObject.SetActive(true);
        else
            foreach (var button in button)
                button.gameObject.SetActive(false);
    }
}
