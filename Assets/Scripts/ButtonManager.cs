using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject WorkMenu;
    public GameObject CasinoMenu;
    public GameObject BusinessMenu;
    public GameObject InputBox;
    public GameObject ShopMenu;
    public TextMeshProUGUI BusinessNameTextbox;

    public GameObject WorkAtJobButton;
    public GameObject StartBusinessButton;
    public GameObject CurrentBusinessButton1;
    public GameObject CurrentBusinessButton2;
    public bool CurrentBusinessButton1Active = false;

    public string businessName;

    void Update()
    {
        
    }

    public void WorkButton()
    {
        MainMenu.SetActive(false);
        WorkMenu.SetActive(true);
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

    public void playerInput(string s)
    {
        businessName = s;
        InputBox.SetActive(false);
        BusinessNameTextbox.text = businessName;


    }
}
