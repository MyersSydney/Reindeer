using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text distDisplay;
    GameManager gm;
    // Start is called before the first frame update
    void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        distDisplay.text = string.Format("Current Run: {0:0.00}m\nBest Run: {1:0.00}m ", gm.playerDist, gm.bestDist);
    }
}
