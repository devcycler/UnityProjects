using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_RandomOutfit : MonoBehaviour
{
    [SerializeField] GameObject character;
    [SerializeField] Material[] outfits;
    private Material myTexture;
    private Material currentOutfit;
    private int index;


    // Start is called before the first frame update
    void Start()
    {
        currentOutfit = character.GetComponent<Renderer>().material;
        RandomOutfit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomOutfit()
    {
        index = Random.Range(0, outfits.Length);
        myTexture = outfits[index];
        character.GetComponent<Renderer>().material = myTexture;
    }
}



//****************************************************************************************
// if the script is on another gameObject:
/*
private gameObject player; // or set this to public and ignore the code in Start method
public Texture myTexture;

void Start()
{
    player = GameObject.FindGameObjectWithTag("player");
    // obviously you would need to tag the player

    // you could also do
    player = GameObject.Find("nameofplayer");
}

void Update()
{
    if (Input.GetKeyDown("c"))
    {
        player.renderer.material.mainTexture = myTexture;

    }

*/