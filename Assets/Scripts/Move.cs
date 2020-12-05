using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 1;
    private Rigidbody2D rb;
    Vector3 start;
    public float dist;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        start = transform.position;
    }

    public void Reset()
    {
        // start = transform.position;
        velocity = -1;
    }
    private void Update()
    {
        dist = Vector3.Distance(start, transform.position);
        start.x = start.x + ( velocity * Time.deltaTime ); // Since the player is actually stationary simulate movement by moving the start away
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
}
