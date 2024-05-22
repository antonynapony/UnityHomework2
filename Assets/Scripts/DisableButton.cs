using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableScript : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(() =>
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }
        });
    }
}

