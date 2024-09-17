using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float bulletSpeed = 10f;
    [SerializeField]
    float bulletDrop = 5.0f;

    void Update()
    {
        //IF we press "the shoot button" (left mouse?)
        if (Input.GetButton("Fire1"))
        {
            //fire a projectile in a straight line in the direction of the mouse
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            mousePos = mousePos - transform.position;
            mousePos.Normalize();
            //spawn in the bullet
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity =mousePos * bulletSpeed;
            Destroy(bullet, bulletDrop);
        }
    }
}
