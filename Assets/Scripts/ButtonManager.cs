using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject WorkMenu;
    public GameObject CasinoMenu;
    public GameObject BusinessMenu;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void WorkButton()
    {
        MainMenu.SetActive(false);
        WorkMenu.SetActive(true);
    }

    public void WorkAtJobButton()
    {

    }
    public void StartBusiness()
    {

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
}
