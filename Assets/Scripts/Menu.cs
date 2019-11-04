using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditMenu;

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        creditMenu.SetActive(false);
    }

    public void ShowCreditsMenu()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
