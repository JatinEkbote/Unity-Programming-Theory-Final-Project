using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Car : Vehicle
{
    //ENCAPSULATION
     private string name
 {
     get; set;
 }
 //ENCAPSULATION
     private string type
 {
     get; set;
 }
 //ENCAPSULATION
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
