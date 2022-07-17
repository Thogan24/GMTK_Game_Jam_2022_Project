using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    private GameManager gm;

    public GameObject GameManager;
    public GameObject MainMenu;
    public GameObject WorkMenu;
    public GameObject CasinoMenu;
    public GameObject BusinessMenu;
    public GameObject InputBox;
    public GameObject ShopMenu;
    public GameObject MiniGameMenu;
    public GameObject DiceGameMenu;
    public GameObject SlotMachineMenu;
    public TextMeshProUGUI BusinessNameTextbox;


    public GameObject WorkAtJobButton;
    public GameObject StartBusinessButton;
    public GameObject CurrentBusinessButton1;
    public GameObject CurrentBusinessButton2;
    public bool CurrentBusinessButton1Active = false;

    public string businessName;
    public int overworkedRandom;
    

    void Start()
    {
        gm = GameManager.GetComponent<GameManager>();
    }

    private void Update()
    {
        if (MainMenu.activeSelf)
        {
            WorkMenu.SetActive(false);
        }
    }

    public void WorkButton()
    {       
        MainMenu.SetActive(false);
        WorkMenu.SetActive(true); 
    }
    public void ShopButton()
    {
        MainMenu.SetActive(false);
        ShopMenu.SetActive(true);
    }



    public void HomeButton()
    {
        MainMenu.SetActive(true);
        BusinessMenu.SetActive(false);
        CasinoMenu.SetActive(false);
        ShopMenu.SetActive(false);
        
    }

    public void WorkAtJob()
    {
        if (gm.CannotWork == false)
        {
            MiniGameMenu.SetActive(true);
            WorkMenu.SetActive(false);
            if (gm.Overworked == true)
            {
                overworkedRandom = Random.Range(1, 5);
                if (overworkedRandom == 1)
                {
                    gm.status -= 1;
                }
            }
        }
        else
        {
            //Display text
        }
    }


    public void StartBusiness()
    {
        
        
        if (CurrentBusinessButton1Active == true)
        {
            CurrentBusinessButton2.SetActive(false);
            StartBusinessButton.SetActive(false);
        }
        else
        {
            CurrentBusinessButton1.SetActive(true);
            CurrentBusinessButton1Active = true;
        }
        WorkMenu.SetActive(false);
        BusinessMenu.SetActive(true);
        
    }
    public void CurrentBusiness()
    {
        BusinessMenu.SetActive(true);
        WorkMenu.SetActive(false);
    }

    public void CasinoButton()
    {
        MainMenu.SetActive(false);
        CasinoMenu.SetActive(true);
    }

    public void DiceGameButton()
    {
        DiceGameMenu.SetActive(true);
        CasinoMenu.SetActive(false);
    }

    public void SlotMachineButton()
    {
        SlotMachineMenu.SetActive(true);
        CasinoMenu.SetActive(false);
    }

    public void playerInput(string s)
    {
        businessName = s;
        InputBox.SetActive(false);
        BusinessNameTextbox.text = s;
    }

    public void NextDayButton()
    {
        gm.days += 1;
        gm.Overworked = false;
    }


}
