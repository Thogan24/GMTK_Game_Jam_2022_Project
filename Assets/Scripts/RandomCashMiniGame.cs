using UnityEngine;

public class RandomCashMiniGame : MonoBehaviour
{
    float timerTime = 0f;

    float time = 0f;
    float timeDelay = 1f;
    public float PosX = 0f;
    public float PosNegX = 0f;
    public float PosY = 0f;
    public float PosNegY = 0f;

    public GameObject prefab;

    // Click the "Instantiate!" button and a new prefab will be instantiated
    // somewhere within -10.0 and 10.0 (inclusive) on the x-z plane

    public void Update()
    {
        timerTime = timerTime + 1f * Time.deltaTime;
        time = time + 1f * Time.deltaTime;

        if (time >= timeDelay)
        {
            time = 0f;
            OnClickGUI();
        }
    }
    public void OnClickGUI()
    {
        var position = new Vector2(Random.Range(PosX, PosNegX), Random.Range(PosY, PosNegY));
        Instantiate(prefab, position, Quaternion.identity);

        
    }
}