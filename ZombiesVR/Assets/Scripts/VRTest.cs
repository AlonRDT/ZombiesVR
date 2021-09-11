using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTest : MonoBehaviour
{
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void White()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
