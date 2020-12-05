using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Vector3 worldPosition;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.y = 10;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
