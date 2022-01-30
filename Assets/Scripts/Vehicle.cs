using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    //ABSTRACTION
    public abstract void Honk();
    public abstract void StartOrStopEngine();
}

