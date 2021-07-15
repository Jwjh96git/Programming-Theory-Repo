using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Dog : Animal
{
    public override void Speak()
    {
        GameManager.instance.Speak(name, speakTerm, 2);
    }
}
