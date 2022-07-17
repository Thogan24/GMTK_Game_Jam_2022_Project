using UnityEngine;
using UnityEngine.UI;
public class DiceRolling : MonoBehaviour
{
    float time = 0f;
    float timeDelay = 0.3f;
    float time2 = 0f;
    float timeDelay2 = 5f;

    public int roll;
    public bool isRolling = false;
    public Texture2D[] diceSide;
    public RawImage dice;
    private ButtonManager bm;
    public GameObject GameManager;
    private GameManager gm;
    public GameObject MainCanvas;
    public GameObject DiceGameMenu;
    public GameObject MainMenu;
    public GameObject MainMenuButton;
    //public string thing;


    private void Start()
    {
        bm = MainCanvas.GetComponent<ButtonManager>();
        gm = GameManager.GetComponent<GameManager>();
    }
    void Update()
    {
        if (isRolling)
        {
            time = time + 1f * Time.deltaTime;
            time2 = time2 + 1f * Time.deltaTime;

            if (time >= timeDelay && time2 < timeDelay2)
            {
                time = 0f;
                RollDice();
            }
            else
            {
                if (roll == bm.diceSide - 1)
                {
                    bm.bet *= 6;
                    gm.playerMoney += bm.bet;
                }
                else
                {
                    gm.playerMoney -= bm.bet;
                    bm.bet = 0;
                    
                }
                
                MainMenuButton.SetActive(true);

            }
        }
    }

    void RollDice()
    {

        roll = Random.Range(0, 6);
        dice.texture = diceSide[roll];
    }

    public void HomeButton()
    {
        DiceGameMenu.SetActive(false);
        MainMenu.SetActive(true);
        MainMenuButton.SetActive(false);
    }
}
