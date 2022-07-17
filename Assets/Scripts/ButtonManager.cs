using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

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
    public GameObject CosmeticsMenu;
    public GameObject UpgradesMenu;
    public GameObject BetButton;
    public TextMeshProUGUI BusinessNameTextbox;
    public TextMeshProUGUI WorkersTextbox;
    public TextMeshProUGUI BetterCashTextbox;
    public TextMeshProUGUI BetterWorkersTextbox;



    public GameObject WorkAtJobButton;
    public GameObject StartBusinessButton;
    public GameObject CurrentBusinessButton1;
    public GameObject CurrentBusinessButton2;
    public bool CurrentBusinessButton1Active = false;

    public string businessName;
    public int overworkedRandom;
    public int bet;
    public int diceSide;

    public GameObject prefab;
    public TMP_InputField betInput;
    public TMP_Dropdown diceInput;
    

    void Start()
    {
        betInput.characterValidation = TMP_InputField.CharacterValidation.Integer;
        gm = GameManager.GetComponent<GameManager>();
    }

    private void Update()
    {
        if (MainMenu.activeSelf)
        {
            WorkMenu.SetActive(false);
            CasinoMenu.SetActive(false);
            ShopMenu.SetActive(false);
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
            gm.AmountOfWork += 1;
            if (gm.Overworked == true)
            {
                overworkedRandom = UnityEngine.Random.Range(1, 5);
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


        //if (CurrentBusinessButton1Active == true)
        //{
        //    CurrentBusinessButton2.SetActive(false);
        //    StartBusinessButton.SetActive(false);
        //}
        if (gm.playerMoney >= 1000)
        {
            CurrentBusinessButton1.SetActive(true);
            CurrentBusinessButton1Active = true;
            StartBusinessButton.SetActive(false);
            gm.playerMoney -= 1000;

            WorkMenu.SetActive(false);
            BusinessMenu.SetActive(true);
        }
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
        Debug.Log(s);
        businessName = s;
        //Debug.Log(businessName);
        InputBox.SetActive(false);
        

    }

    public void Bet()
    {
        bet = Int32.Parse(betInput.text);
        diceSide = diceInput.value;

        betInput.gameObject.SetActive(false);
        diceInput.gameObject.SetActive(false);
        BetButton.SetActive(false);

    }

    public void NextDayButton()
    {
        gm.days += 1;
        gm.Overworked = false;
        gm.CannotWork = false;
    }

    public void HireEmployee()
    {
        if (gm.playerMoney >= 100)
        {
            gm.playerMoney -= 100;
            gm.AmountOfWorkers += 1;

            WorkersTextbox.text = "Workers: " + gm.AmountOfWorkers.ToString();
            //var position = new Vector2(-3 + gm.AmountOfWorkers, -4);
            //GameObject clone = Instantiate(prefab, position, Quaternion.identity);

        }
    }

    public void BackButton()
    {
        ShopMenu.SetActive(true);
        CosmeticsMenu.SetActive(false);
        UpgradesMenu.SetActive(false);
    }

    public void UpgradesButton()
    {
        ShopMenu.SetActive(false);
        UpgradesMenu.SetActive(true);
    }
    public void CosmeticsButton()
    {
        ShopMenu.SetActive(false);
        CosmeticsMenu.SetActive(true);
    }
    public void BetterWorkersButton()
    {
        if (gm.playerMoney >= 200)
        { 
            gm.playerMoney -= 200;
            gm.BetterWorkersUpgrade += 1;
            BetterWorkersTextbox.text = "200$ - Better Workers (Business) (" + gm.BetterWorkersUpgrade.ToString() + ")";
            
        }
    }

    public void BetterCashButton()
    {
        if (gm.playerMoney >= 200)
        {
            gm.playerMoney -= 200;
            gm.BetterCashUpgrade += 1;
            BetterCashTextbox.text = "200$ - Better Cash (Work) (" + gm.BetterCashUpgrade.ToString() + ")";
            
        }
    }

    public void InstructionsArrow()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.tag == "Arrow_Instructions")
                {

                    

                }
            }
        }
    }



}
