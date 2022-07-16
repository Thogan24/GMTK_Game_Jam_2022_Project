using UnityEngine;

public class RandomCashMiniGame : MonoBehaviour
{
    public float PosX = 0f;
    public float PosNegX = 0f;

    public float PosY = 0f;
    public float PosNegY = 0f;

    public GameObject prefab;

    // Click the "Instantiate!" button and a new prefab will be instantiated
    // somewhere within -10.0 and 10.0 (inclusive) on the x-z plane
    public void Update()
    {
        var position = new Vector2(Random.Range(PosX, PosNegX), Random.Range(PosY, PosNegY));
        Instantiate(prefab, position, Quaternion.identity);

        
    }
}