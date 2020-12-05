using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    GameManager manager;
    [Header("Does Collision")]
    public string pname = "NO-NAME"; // player name

    public int giftCounter = 0;
    private void Awake()
    {
        var gm = GameObject.Find("GameManager");
        manager = gm.GetComponent<GameManager>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("CollisionEnter!");
        if (collision.collider.CompareTag("Gift"))
        {
            Debug.Log("You Get Coal!");
            //GameObject.Destroy(collision.gameObject);
            manager.EndRound();
        } else if (collision.collider.CompareTag("GameController"))
        {
            Debug.Log("Out of Bounds!");
            manager.EndRound();
        }
    }
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("counter"))
        {
            giftCounter = giftCounter + 1;
        }
    }
}
