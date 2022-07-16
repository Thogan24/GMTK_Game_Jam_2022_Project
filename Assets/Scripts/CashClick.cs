using UnityEngine;

public class CashClick : MonoBehaviour
{
    public int MinigameScore = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("AAAAA");
                if (hit.transform.tag == "Minigame_Cash")
                {
                    Debug.Log("Bruh");
                    MinigameScore += 5;
                }
            }
        }



    }
}
