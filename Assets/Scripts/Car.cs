using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    // string name;
     private string name
 {
     get; set;
 }
     private string type
 {
     get; set;
 }
     private string manufacturer
 {
     get; set;
 }
    public AudioSource hornAudio;
    public AudioSource engineAudio;
    bool onOrOff = false;

    public override void Honk() {
    hornAudio.Play();
    }
    public override void StartOrStopEngine() {
    if(onOrOff){
        engineAudio.Stop();
    }
    else {
        engineAudio.loop = true;
        engineAudio.Play();
    }
    onOrOff = !onOrOff;
    }


}
