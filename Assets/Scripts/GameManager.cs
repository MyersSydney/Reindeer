using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float playerDist;
    public float bestDist = 0f;
    public float sceneTime = 0f;
    public Move playerMove;
    public int pretime;
    public bool isPlaying = false;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        sceneTime -= pretime;
    }

    public void EndRound()
    {
        Debug.Log("Round Ended!");
        isPlaying = false;
        playerMove.Reset();
        //Hi-Score
        if (playerDist > bestDist)
            bestDist = playerDist;
        // Purge all pillars
       //Debug.Log("Clearing Pillars...");
        GameObject[] gifts = GameObject.FindGameObjectsWithTag("Gift");
        foreach(GameObject g in gifts)
        {
            GameObject.Destroy(g);
        }
    }

    public void StartRound()
    {
        Debug.Log("Round Started!");
        isPlaying = true;
        playerDist = 0;
    }
    void StartGame()
    {

        //Function starts the match!
        Debug.Log("!   Game Start  !");
        isPlaying = true;
        Physics2D.IgnoreLayerCollision(1, 8, true);
    }
    // Update is called once per frame
    void Update()
    {
        playerDist = playerMove.dist; // grab the travel dist from the palyer move script (it tracks there)
        sceneTime += Time.deltaTime;
        if (sceneTime >= 0 && isPlaying == false)
            StartGame();
    }
}
