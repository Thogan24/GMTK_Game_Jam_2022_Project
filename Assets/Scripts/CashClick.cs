using UnityEngine;

public class CashClick : MonoBehaviour
{
    public int MinigameScore = 0;
    public RandomCashMiniGame mg;
    public GameObject Panel;

    private void Start()
    {
        mg = Panel.GetComponent<RandomCashMiniGame>();
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
                    
                    MinigameScore += 5;
                    
                }
            }
        }



    }
}
