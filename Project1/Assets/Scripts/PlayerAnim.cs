using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("x", xInput);
        GetComponent <Animator>().SetFloat("y", yInput);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            bool running = true;
            GetComponent<Animator>().SetBool("run", running);
        }
        else
        {
            bool running = false;
            GetComponent<Animator>().SetBool("run", running);
        }
    }
}
