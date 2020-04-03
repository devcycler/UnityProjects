using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroneManager : MonoBehaviour
{
    public static ThroneManager singleton;
    public Canvas throneMenu;
    public Camera cam;
    public GameObject king;
    public GameObject dummyKing;
    public bool kingIsAvailable = false;


    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        cam = Camera.main;
        throneMenu = throneMenu.GetComponent<Canvas>();
    }
    public void ThroneMenuOn()
    {
        throneMenu.enabled = true;
        TakeOverCamera();
        TurnOffPlayerRenderer();
    }
    public void ThroneMenuOff()
    {
        throneMenu.enabled = false;
        ReleaseCamera();
    }
    
    public void TakeOverCamera()
    {
        CameraFollow.singleton.SetControllable(false);
        CameraManager.singleton.CameraActivate();
    }
    public void ReleaseCamera()
    {
        CameraManager.singleton.CameraDeactivate();
        CameraFollow.singleton.SetControllable(true);
        king.SetActive(true);
        dummyKing.SetActive(false);
    }

    public void TurnOffPlayerRenderer()
    {
        dummyKing.SetActive(true);
        king.SetActive(false);
    }



    public void TreasuryMenu()
    {
        Debug.Log("Treasury Menu Button Pressed");
    }
    public void FoodStocks()
    {
        Debug.Log("Food Stocks Button Pressed");
    }
    public void LawAndOrder()
    {
        Debug.Log("Law & Order Button Pressed");
    }
    public void Lineage()
    {
        Debug.Log("Lineage Button Pressed");
    }
    public void MattersOfCourt()
    {
        kingIsAvailable = true;
        Debug.Log("Matters of Court Button Pressed");
    }
    public void CloseThroneMenu()
    {
        kingIsAvailable = false;
        ThroneManager.singleton.ThroneMenuOff();
    }

}
//Need a call to turn off or transfer the audio listener