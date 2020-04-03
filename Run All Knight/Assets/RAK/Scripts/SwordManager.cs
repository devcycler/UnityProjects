using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordManager : MonoBehaviour
{
    public static SwordManager singleton;

    public GameObject player;
    public Texture emptySword;
    public Texture fullSword;
    public RawImage Sword1;
    public RawImage Sword2;
    public RawImage Sword3;
    public bool swordMovement = false;
    public GameObject swordProjectile;
    public GameObject swordInHand;
    public GameObject swordOnBack1;
    public GameObject swordOnBack2;

    private bool hasSwords = true;
    private GameObject swordP;
    private Animator anim;
    private int swordCount;


    private int SwordCount
        {
            get { return swordCount; }
            set
            {
                swordCount = value;
                PlayerPrefs.SetInt("SwordCount", swordCount);
            }
        }

    void Awake()
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
        SwordCount = PlayerPrefs.GetInt("SwordCount", 3);
        anim = player.GetComponent<Animator>();
    }

    void Update()
    {
        if (swordMovement)
        {
            SwordMovement(swordP);
        }
    }
    

    public void PickUpSwordCheck()
    {
        if (SwordCountCheck())
        {
            switch (SwordCount)
            {
                case 3 :
                    Debug.Log("Arsenal Full. Ignoring Sword");
                    break;
                case 2:
                    anim.SetBool("PickUp",true);
                    SwordCount++;
                    break;
                case 1:
                    anim.SetBool("PickUp", true);
                    SwordCount++;
                    break;
                case 0:
                    anim.SetBool("PickUp", true);
                    SwordCount++;
                    break;
                default:
                    Debug.LogError("SwordManager.PickUpSwordCheck defaulted! SwordCount variable returned: " + SwordCount);
                    break;
            }
        }
    }

    public bool SwordCountCheck()
    {
        Debug.Log("Sword Count Requested!");
        if(SwordCount > 0)
        {
            return hasSwords = true;
        }
        else
        {
            return hasSwords = false;
        }
        //return hasSwords;
    }

    private void SwordMovement(GameObject sword)
    {
        swordP = sword;
        sword.transform.position += KnightController.player.transform.forward * 0.4f;
    }

    public void SwordPickUp()
    {
        Debug.Log("ANIMATION EVENT WORKED! PICK UP CALLED!");
    }

    private bool SwordUseCheck(int sc)
    {
        int swords = sc;

        if (swords > 0)
        {
            hasSwords = true;
            anim.SetBool("hasSwords", true);
        }
        else
        {
            hasSwords = false;
            anim.SetBool("hasSwords", false);
        }
        return hasSwords;
    }

    private void SwordPickUpCheck()
    {
        if (SwordCount > 2)
        {
            //use sword in hand code
            if (SwordCount > 1)
            {
                //use sword on back 2
                if (SwordCount < 1)
                {
                    //use sword on back 1
                }
            }
        }
    }

    private void DrawSword()
    {
        Debug.Log("DRAW SWORD PLAYED");
        if (SwordCountCheck())
        {
            anim.SetTrigger("DrawSword");
        }
        
    }
    public void SwordProjectile()
    {
        GameObject sword = Instantiate(swordProjectile, new Vector3(transform.position.x, 1.25f, -3f), Quaternion.Euler(-90, 0, 0));
        sword.transform.position += KnightController.player.transform.forward * 1f;
        swordMovement = true;
        SwordMovement(sword);
    }


    private void HideSwordInHand()
    {
        swordInHand.SetActive(false);
    }
    private void HideSwordOnBack1()
    {
        swordOnBack1.SetActive(false);
    }
    private void HideSwordOnBack2()
    {
        swordOnBack2.SetActive(false);
    }

    private void ShowSwordInHand()
    {
        swordInHand.SetActive(true);
    }
    private void ShowSwordOnBack1()
    {
        swordOnBack1.SetActive(true);
    }
    private void ShowSwordOnBack2()
    {
        swordOnBack2.SetActive(true);
    }
}
