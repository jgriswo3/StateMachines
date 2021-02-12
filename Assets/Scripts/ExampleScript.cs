using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "Mark";
        if (name == "James")
        {
            Debug.Log("My name is James");
        }
        else if (name == "Mark")
        {
            Debug.Log("My name is Mark");
        }
        else
        {
            Debug.Log("I don't recognize that name");
        }

        switch(name)
        {
            case "James": Debug.Log("My name is James"); break;
            case "Mark": Debug.Log("My name is Mark"); break;
            default: Debug.Log("I don't recognize that name"); break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
