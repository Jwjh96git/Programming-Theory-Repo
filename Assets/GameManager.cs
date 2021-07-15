using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //ENCAPSULATION
    public static GameManager instance { get; private set;}

    public Text animalText;

    public Text speakText;

    private Cat cat;

    private Dog dog;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);

        //create a cat and dog
        cat = new Cat();
        cat.name = "cat";
        cat.speakTerm = "Meow~";

        dog = new Dog();
        dog.name = "dog";
        dog.speakTerm = "Woof!";
    }

    //POLYMORPHISM
    public void Speak(string name, string speakTerm)
    {
        speakText.text = $"I am a {name}. {speakTerm}";
    }

    public void Speak(string name, string speakTerm, int num)
    {
        speakText.text = $"I am a {name}.";
        for (int i = 0; i < num; i++)
        {
            speakText.text += speakTerm + " ";
        }
    }

    public void StartGame()
    {
        string animal = animalText.text.ToLower();

        if (animal == "cat")
        {
            cat.Speak();
        }
        else if (animal == "dog")
        {
            dog.Speak();
        }
    }
}
