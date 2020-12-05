using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEnter!");
        if (collision.collider.CompareTag("Gift"))
        {
            Debug.Log("You Get Coal!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
