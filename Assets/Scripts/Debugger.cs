using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    static public void PrintRed(string message)
    {
        Debug.Log("<color=red>" + message + "</color>");
    }
}
