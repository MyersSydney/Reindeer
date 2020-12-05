using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float sceneTime = 0f;
    GameObject player;
    public int pretime;
    public bool isPlaying = false;
    public int distance;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
        sceneTime -= pretime;
    }

    void StartGame()
    {

        //Function starts the match!
        Debug.Log("!   Game Start  !");
        isPlaying = true;

    }
    // Update is called once per frame
    void Update()
    {
        sceneTime += Time.deltaTime;
        if (sceneTime >= 0 && isPlaying == false)
            StartGame();
    }
}
