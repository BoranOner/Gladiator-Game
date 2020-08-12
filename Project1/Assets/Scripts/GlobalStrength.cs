using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStrength : MonoBehaviour
{
    public static int StrengthCount;
    public GameObject StrengthDisplay;
    public int InternalStrength;

// Update is called once per frame
void Update()
    {
        InternalStrength = StrengthCount;
        StrengthDisplay.GetComponent<Text>().text = "Strength: " + InternalStrength;

    }

}