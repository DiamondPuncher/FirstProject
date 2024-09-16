using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

   
    void Update()
    {
        //If you press the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1) 
            {
                //make the pause menu visible
                GetComponent<Canvas>().enabled = true;
                //also, stop the game from playing
                Time.timeScale = 0;
            }
            else
            {
                GetComponent<Canvas>().enabled = false;
                Time.timeScale = 1;
            }
        }

    }
}
