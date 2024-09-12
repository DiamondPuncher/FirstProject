using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int health = 20;
    [SerializeField]
    string levelToLoad = "MazeEntrance";
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //We want to take damage IF the player hits the enemy capsule
        //bool key = true;
        if (collision.gameObject.tag == "Enemy")
        {
            //health = health - 1;
            health -= 1;
            //consequences for taking too much damage
            //IF we take enough damage to bring health to 0, reload level
            if(health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //SceneManager.LoadScene(levelToLoad);
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
            if (health <= 0)
            {
                SceneManager.LoadScene(levelToLoad);
                //SceneManager.LoadScene(levelToLoad);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
