using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ABSTRACTION
public abstract class Animal
{
    public string name { get; set; }
    public string speakTerm { get; set; }

    public virtual void Speak()
    {
        GameManager.instance.Speak("animal", "Default");
    }
}
