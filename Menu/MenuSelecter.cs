using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelecter : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public void OnStartButton()
    {
        SceneManager.LoadScene("WorldScene");
    }
    public void OnOptionsButton()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void OnBackButton()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}
