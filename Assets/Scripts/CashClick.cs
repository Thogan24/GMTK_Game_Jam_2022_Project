using UnityEngine;

public class CashClick : MonoBehaviour
{


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Minigame_Cash")
                {
                    Debug.Log("Bruh");
                }
            }
        }



    }
}
