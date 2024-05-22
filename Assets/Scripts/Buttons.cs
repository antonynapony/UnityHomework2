using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Buttons";
    }

    void Update()
    {
        if (button.interactable == true)
            button.onClick.AddListener(() => { text.text = button.name.ToString() + " Clicked"; });
        else
            text.text = "Buttons Disabled";
    }
}
