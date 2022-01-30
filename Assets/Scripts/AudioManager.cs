using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject car;
    AudioSource audioSource;
    Car carScript;
    void Start()
    {
FindVehicle();
    }

    bool FindVehicle() {
        if (car == null) {
            Debug.Log("Car is NUll");
            GameObject[] cars = GameObject.FindGameObjectsWithTag("Respawn");
            if(cars.Length == 1) {
            car = cars[0];
           carScript = car.GetComponent<Car>();
           Debug.Log("Script Found!");
           return true;
        }
        return false;
        }
        return true;
    }

    public void Honk() {
        if(FindVehicle()) {
            carScript.Honk();
        } 
    }

    public void StartOrStopEngine() {
        if(FindVehicle()) {
            carScript.StartOrStopEngine();
        } 
    }
}
