using UnityEngine;

public class DiceRolling : MonoBehaviour
{
    float time = 0f;
    float timeDelay = 0.3f;

    public GameObject Dice1;
    public GameObject Dice2;
    public GameObject Dice3;
    public GameObject Dice4;
    public GameObject Dice5;
    public GameObject Dice6;
    public int roll;
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
        //thing = "Dice" + roll;

        if (roll == 1)
        {
            Dice1.SetActive(true);
            Dice2.SetActive(false);
            Dice3.SetActive(false);
            Dice4.SetActive(false);
            Dice5.SetActive(false);
            Dice6.SetActive(false);
        }
        else if (roll == 2)
        {
            Dice2.SetActive(true);
            Dice1.SetActive(false);
            Dice3.SetActive(false);
            Dice4.SetActive(false);
            Dice5.SetActive(false);
            Dice6.SetActive(false);
        }
        else if (roll == 3)
        {
            Dice3.SetActive(true);
            Dice2.SetActive(false);
            Dice1.SetActive(false);
            Dice4.SetActive(false);
            Dice5.SetActive(false);
            Dice6.SetActive(false);
        }
        else if (roll == 4)
        {
            Dice4.SetActive(true);
            Dice2.SetActive(false);
            Dice3.SetActive(false);
            Dice1.SetActive(false);
            Dice5.SetActive(false);
            Dice6.SetActive(false);
        }
        else if (roll == 5)
        {
            Dice5.SetActive(true);
            Dice2.SetActive(false);
            Dice3.SetActive(false);
            Dice4.SetActive(false);
            Dice1.SetActive(false);
            Dice6.SetActive(false);
        }
        else if (roll == 6)
        {
            Dice6.SetActive(true);
            Dice2.SetActive(false);
            Dice3.SetActive(false);
            Dice4.SetActive(false);
            Dice5.SetActive(false);
            Dice1.SetActive(false);
        }
    }
}
