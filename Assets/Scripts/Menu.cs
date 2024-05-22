using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject[] menuTabs;

    void Start()
    {
        for (int i = 0; i < menuTabs.Length; i++)
        {
            if (menuTabs[i].activeSelf)
            {
                menuTabs[i].SetActive(false);
            }
        }

        if (mainMenu.activeSelf == false)
        {
            mainMenu.SetActive(true);
        }
    }
}
