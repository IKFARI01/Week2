using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{

    public TextMeshProUGUI label;

    public void PrintMessage()
    {

        label.text = "Hi there!";

    }

    public void PrintMessage1()
    {

        label.text = "What's your name?";

    }

}
