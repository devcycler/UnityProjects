using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightController : MonoBehaviour
{
    private Animator anim;
    public static GameObject player;
    private float firstDelay = 0.50f;
    private float secondDelay = 1f;
    private float slideDelay = 1f;
    public ParticleSystem dirtSlide;
    private float slideRayLength = 10f;
    private RaycastHit hit;
    private Color color;

    public Color bridgeMaterial;
    public Color grassMaterial;
    public Color canalMaterial;
    public Color dirtMaterial;
    private bool equipped;
    private GameObject swordP;


    void Start()
    {
        anim = GetComponent<Animator>();
        player = this.gameObject;
        equipped = SwordManager.singleton.SwordCountCheck();
}
    void Update()
    {
        KnightControls();
        SlideRayCasting();
    }
    
    private void SlideRayCasting()
    {
        
        Ray slideParticleRay = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(slideParticleRay, out hit, slideRayLength))
        {
            if (hit.collider != null)
            {
                color = ColorSwap(hit.collider.gameObject);
                ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
                ParticleSystem.MainModule ma = ps.main;
                ma.startColor = color;
                //Debug.Log(color);
            }
            else
            {
                Debug.Log("No Collider found!");
            }
        }
    }
    private Color ColorSwap(GameObject obj)
    {
        GameObject _gameObject = obj;
        switch (_gameObject.tag)
        {
            case "Bridge":
                color = bridgeMaterial;
                break;
            case "Grass":
                color = grassMaterial;
                break;
            case "Canal":
                color = canalMaterial;
                break;
            case "Dirt":
                color = dirtMaterial;
                break;
            default:
                color = dirtMaterial;
                break;
        }
        return color;
    }

    //Control scheme for animation sets
    private void KnightControls()
    {

    }

    private void SwordProjectile()
    {
        SwordManager.singleton.SwordProjectile();
    }

    /// <summary>
    /// UI BUTTON METHODS
    /// </summary>
    public void SwordThrow()
    {
        //private bool equipped = SwordManager.singleton.SwordCountCheck();
        if (equipped)
        {
            anim.SetTrigger("Attack");
            Debug.Log("ATTACKED with SWORDTHROW!");
        }
        else
        {
            Debug.Log("Sword Check returned 0 swords");
        }
    }
    public void SwordSmash()
    {
        if (equipped)
        {
            anim.SetTrigger("JumpAttack");
            Debug.Log("ATTACKED with SWORDSMASH!");
        }
        else
        {
            Debug.Log("Sword Check returned 0 swords");
        }
    }

    public void Slide()
    {
        anim.SetTrigger("Slide");
        Debug.Log("SLIDE!");
    }
    /// <summary>
    /// UI BUTTON METHODS
    /// </summary>

    public void StopLevelMovement()
    {
        LevelManager.Instance.PlatformSpeed = 0f;
    }
    public void ResetSpeed()
    {
        Debug.Log("RESET SPEED");
        LevelManager.Instance.PlatformSpeed = -0.15f;
    }

    public IEnumerator Attack1Delay()
    {
        anim.ResetTrigger("JumpAttack");
        anim.ResetTrigger("Jump");
        anim.ResetTrigger("Slide");
        anim.ResetTrigger("RollRight");
        anim.ResetTrigger("RollLeft");
        yield return new WaitForSeconds(0f);
        LevelManager.Instance.PlatformSpeed = -0.03f;
        //SwordThrow();
    }

    public IEnumerator Attack2Delay(float prevSpeed)
    {
        yield return new WaitForSeconds(firstDelay);
        LevelManager.Instance.PlatformSpeed = 0.015f;
        SwordSmash();
        yield return new WaitForSeconds(secondDelay);
    }

    public IEnumerator SlideDelay(float prevSpeed)
    {
        LevelManager.Instance.PlatformSpeed = (LevelManager.Instance.PlatformSpeed*2);   //Speed up the movement for the slide
        yield return new WaitForSeconds(slideDelay);
        LevelManager.Instance.PlatformSpeed = prevSpeed;   //Reset to normal speed
    }






    //     ****************************OLD CODE******************************
    //
    //
    //     ******************************************************************
    /*  private void SwordThrow()
    {
        if (swordOnBack2.activeSelf)
        {
            if (swordOnBack1.activeSelf)
            {
                if (swordInHand.activeSelf)
                {
                    anim.SetTrigger("Attack");
                    Sword3.texture = emptySword;
                    Debug.Log("Sword In Hand used!");
                    return;
                }
                anim.SetTrigger("Attack");
                Sword2.texture = emptySword;
                Debug.Log("Sword On Back 1 used!");
                return;
            }
            anim.SetTrigger("Attack");
            Sword1.texture = emptySword;
            Debug.Log("Sword On Back 2 used!");
            return;
        }
        else
        {
            Debug.Log("No sword to attack with!");
        }
    }
    */
}



