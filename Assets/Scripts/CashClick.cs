using UnityEngine;

public class CashClick : MonoBehaviour
{
    public int MinigameScore = 0;
    public RandomCashMiniGame mg;
    public GameObject Panel;
    public GameObject GameManager;
    private GameManager gm;

    private void Start()
    {
        mg = Panel.GetComponent<RandomCashMiniGame>();
        gm = GameManager.GetComponent<GameManager>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.tag == "Minigame_Cash")
                {
                    
                    MinigameScore += 5 + gm.playerMoney;
                    
                }
            }
        }



    }
}
