using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RezewareDemo : MonoBehaviour
{
    private void OnDisable()
    {
        Mic mic = new Mic();
        Debug.Log(mic.Speak());
    }
}
