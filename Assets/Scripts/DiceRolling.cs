using UnityEngine;
using UnityEngine.UI;
public class DiceRolling : MonoBehaviour
{
    float time = 0f;
    float timeDelay = 0.3f;

    public int roll;
    public Texture2D[] diceSide;
    public RawImage dice;
   //public string thing;



    void Update()
    {
        time = time + 1f * Time.deltaTime;

        if (time >= timeDelay)
        {
            time = 0f;
            RollDice();
        }
    }

    void RollDice()
    {

        roll = Random.Range(1, 7);
        dice.texture = diceSide[roll];
    }
}
