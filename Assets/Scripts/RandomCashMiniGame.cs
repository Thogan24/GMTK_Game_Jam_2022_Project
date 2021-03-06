using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomCashMiniGame : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI finishedText;
    private CashClick cc;
    private GameManager gm;

    public GameObject GameManager;
    public GameObject MainMenu;
    public GameObject MiniGame;
    float timerTime = 20f;

    
    float time = 0f;
    float timeDelay = 1f;
    public float PosX = 0f;
    public float PosNegX = 0f;
    public float PosY = 0f;
    public float PosNegY = 0f;

    public GameObject prefab;
    

    // Click the "Instantiate!" button and a new prefab will be instantiated
    // somewhere within -10.0 and 10.0 (inclusive) on the x-z plane
    public void Start()
    {
        cc = MiniGame.GetComponent<CashClick>();
        gm = GameManager.GetComponent<GameManager>();
    }
    public void Update()
    {
        if (timerTime > 0f)
        {
            timerTime = timerTime - 1f * Time.deltaTime;
            time = time + 1f * Time.deltaTime;

            if (time >= timeDelay)
            {
                time = 0f;
                SpawnMoney();
            }

            timerText.text = "Time Remaining: " + timerTime.ToString("F1");

        }
        else
        {
            timerText.text = "0";
            finishedText.text = "Score: " + cc.MinigameScore.ToString();
            Invoke("finished", 2);
            
            


        }

    }

    public void finished()
    {
        timerTime = 20;
        finishedText.text = "";
        MainMenu.SetActive(true);
        MiniGame.SetActive(false);
        gm.playerMoney += cc.MinigameScore;
        cc.MinigameScore = 0;

    }

    public void SpawnMoney()
    {
        var position = new Vector2(Random.Range(PosX, PosNegX), Random.Range(PosY, PosNegY));
        GameObject clone = Instantiate(prefab, position, Quaternion.identity);

        Destroy(clone, 1);

        
    }

    
}