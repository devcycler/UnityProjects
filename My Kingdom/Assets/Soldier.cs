using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    private Animator anim;
    //public bool AtAttention1;
    //public bool AtAttention2;
    //public bool AtEase;

    public enum SoldierPose
    {
        //At_Ease,
        At_Attention_1,
        At_Attention_2
    }
    public SoldierPose pose;





    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (pose)
        {
            //case SoldierPose.At_Ease:
            //    anim.SetBool("isAtAttention1", false);
            //    anim.SetBool("isAtAttention2", false);
            //    anim.SetBool("isAtEase", true);
            //    break;
            case SoldierPose.At_Attention_1:
                //anim.SetBool("isAtEase", false);
                anim.SetBool("isAtAttention2", false);
                anim.SetBool("isAtAttention1", true);
                break;
            case SoldierPose.At_Attention_2:
                //anim.SetBool("isAtEase", false);
                anim.SetBool("isAtAttention1", false);
                anim.SetBool("isAtAttention2", true);
                break;
        };
    }
}
