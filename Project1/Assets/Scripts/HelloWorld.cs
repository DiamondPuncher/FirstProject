using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string name = "Timmy";
        Debug.Log(name);
        int timmyHealth = 10;
        Debug.Log(timmyHealth);
        float critChance = 0.2f;
        Debug.Log(critChance);
        Debug.Log(name + " has " + timmyHealth + " health, and a critical hit chance of " + critChance + ".");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Crazy? Timmy was crazy once. They locked him in a room. A rubber room. A rubber room with rats, the rats made him crazy.");
    }
}
