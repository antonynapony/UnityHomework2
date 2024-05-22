using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public void DropdownMenu(int value)
    {
        if (value == 0)
        {
            text.text = "Option A";
        }
        if (value == 1)
        {
            text.text = "Option B";
        }
        if (value == 2)
        {
            text.text = "Option C";
        }
        if (value == 3)
        {
            text.text = "Option D";
        }
    }

}
