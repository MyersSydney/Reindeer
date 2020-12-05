using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float playerDist;
    public float bestDist = 0f;
    public float sceneTime = 0f;
    public Move playerMove;
    public int pretime;
    public bool isPlaying = false;
    public GameObject gameOver;
    public PlayerBehavior player;
    public Text giftCount;
    public GameObject inGameUI;

    //player prefs
    public int topScore;
    public Text topScoreUI;
    public Text finalScoreUI;

    public static GameManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        sceneTime -= pretime;
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Start()
    {
        StartGame();
        gameOver.SetActive(false);
        inGameUI.SetActive(true);
        topScore = PlayerPrefs.GetInt("TopScore");
    }
    public void EndRound()
    {
        if(topScore < player.giftCounter)
        {
            PlayerPrefs.SetInt("TopScore", player.giftCounter);
            Debug.Log(PlayerPrefs.GetInt("TopScore"));
        }
        Debug.Log("Round Ended!");
        isPlaying = false;
        playerMove.Reset();
        //Hi-Score
        if (playerDist > bestDist)
            bestDist = playerDist;
        // Purge all pillars
       //Debug.Log("Clearing Pillars...");
        GameObject[] gifts = GameObject.FindGameObjectsWithTag("Gift");
        Time.timeScale = 0;
        foreach (GameObject g in gifts)
        {
           // GameObject.Destroy(g);
           

        }

        //game over ui enable
        gameOver.SetActive(true);
        inGameUI.SetActive(false);
        topScoreUI.text = PlayerPrefs.GetInt("TopScore").ToString();
        finalScoreUI.text = player.giftCounter.ToString();

    }

    public void StartRound()
    {
        Debug.Log("Round Started!");
        isPlaying = true;
        playerDist = 0;
        Time.timeScale = 1;

        //game over ui
       
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
        /* if (sceneTime >= 0 && isPlaying == false)
             StartGame();*/

        giftCount.text = player.giftCounter.ToString();

    }
}
