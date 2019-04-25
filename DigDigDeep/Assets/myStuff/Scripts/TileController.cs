using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public int clearMaterial = 0;
    public Sprite newBrickSprite;
    public Sprite newStoneSprite;
    public Sprite LastStoneSprite;
    public ParticleSystem tileDust;
    void OnMouseDown()
    {
        //need a method that will determine the type of material, then 4 methods to house each materials "click req"
        clearMaterial++;
        tileDust.Play();
        CheckMaterial(gameObject);
    }
    //Check material and increase score accordingly
    private void CheckMaterial (GameObject gameObject)
    {
        if (gameObject.CompareTag("Grass") && clearMaterial > 0)
        {
            GameManager.singleton.IncreaseScore(1);
            GameManager.singleton.BlocksMined(1);
            GameManager.singleton.DestroyBlock(gameObject);
        }
        if (gameObject.CompareTag("Sand") && clearMaterial > 0)
        {
            GameManager.singleton.IncreaseScore(1);
            GameManager.singleton.BlocksMined(1);
            GameManager.singleton.DestroyBlock(gameObject);
        }
        if (gameObject.CompareTag("Brick") && clearMaterial > 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = newBrickSprite;
            if (gameObject.CompareTag("Brick") && clearMaterial > 1)
            {
                GameManager.singleton.IncreaseScore(2);
                GameManager.singleton.BlocksMined(1);
                GameManager.singleton.DestroyBlock(gameObject);
            }
        }
        if (gameObject.CompareTag("Stone") && clearMaterial > 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = newStoneSprite;
            if (gameObject.CompareTag("Stone") && clearMaterial > 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = LastStoneSprite;
                if (gameObject.CompareTag("Stone") && clearMaterial > 2)
                {
                    GameManager.singleton.IncreaseScore(3);
                    GameManager.singleton.BlocksMined(1);
                    GameManager.singleton.DestroyBlock(gameObject);
                }
            }
        }
    }

    public void MoveTile()
    {
        transform.Translate(Vector2.up * Time.deltaTime);
    }


    void IfLeftScreen(GameObject gameObject)
    {
        if (gameObject.CompareTag("Grass"))
        {
            GameManager.singleton.IncreaseScore(-1);
            GameManager.singleton.BlockMisses(1);
        }
        if (gameObject.CompareTag("Sand"))
        {
            GameManager.singleton.IncreaseScore(-1);
            GameManager.singleton.BlockMisses(1);
        }
        if (gameObject.CompareTag("Brick"))
        {
            GameManager.singleton.IncreaseScore(-2);
            GameManager.singleton.BlockMisses(1);
        }
        if (gameObject.CompareTag("Stone"))
        {
            GameManager.singleton.IncreaseScore(-3);
            GameManager.singleton.BlockMisses(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 6)
        {
            IfLeftScreen(gameObject);
            Destroy(gameObject);
        } else
        {
            MoveTile();
        }
        
    }
}
