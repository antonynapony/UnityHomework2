using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private TextMeshProUGUI text;

    void Update()
    {
        if (toggle.isOn) 
        { 
        text.text = toggle.name.ToString();
        }
    }
}
