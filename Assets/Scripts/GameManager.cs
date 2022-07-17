using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI dayText;
    public TextMeshProUGUI statusText;


    public int playerMoney = 0;
    public int days = 0;
    public int status = 0;
    public string statusString = "";
    public int AmountOfWork = 0;
    public bool CannotWork = false;
    public bool Overworked = false;
    public GameObject OverworkedPNG;

    void Start()
    {
        status = Random.Range(3, 6);
    }

    
    void Update()
    {
        moneyText.text = "Cash: " + playerMoney.ToString();
        dayText.text = "Day: " + days.ToString();
        
        statusText.text = "Status: " + getStatusString(); ;

        if (AmountOfWork >= 6)
        {
            CannotWork = true;
        }

        
        OverworkedPNG.SetActive(Overworked);


        
    }

    


    private string getStatusString()
    {
        if (status == 0)
        {
            return "Dead";
        }
        else if (status == 1)
        {
            return "Depressed";
        }
        else if (status == 2)
        {
            return "Sad";
        }
        else if (status == 3)
        {
            return "Okay";
        }
        else if (status == 4)
        {
            return "Happy";
        }
        else if (status == 5)
        {
            return "Very Happy";
        }
        return "Extremely Happy";
    }
}
