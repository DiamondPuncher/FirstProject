using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZechoMovement : MonoBehaviour
{
    [SerializeField]
    float walkSpeed = 10f;
    [SerializeField]
    float runSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, yInput) * runSpeed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, yInput) * walkSpeed;
        }

    }
}
