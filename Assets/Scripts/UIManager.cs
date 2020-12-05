using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text distDisplay;
    public GameObject GameOverUI;

    // Start is called before the first frame update
    void Awake()
    {
       // GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        distDisplay.text = string.Format("Current Run: {0:0.00}m\nBest Run: {1:0.00}m ", GameManager.instance.playerDist, GameManager.instance.bestDist);
    }

    public void replay()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }

    public void quit()
    {
        Application.Quit();
    }
    
    public void loadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1;
    }
}
