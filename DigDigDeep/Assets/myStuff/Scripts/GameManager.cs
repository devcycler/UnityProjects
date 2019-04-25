using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public bool GameStarted { get; set; }
    public bool GameEnded { get; set; }
    public int Score { get; set; }
    public int BlocksDestroyed { get; set; }
    public int MissedBlocks { get; set; }
    
    [SerializeField] GameObject[] randomTile;
    [SerializeField] Vector3 spawnTile1;
    [SerializeField] Vector3 spawnTile2;
    [SerializeField] Vector3 spawnTile3;
    [SerializeField] Vector3 spawnTile4;
    [SerializeField] float _tileSpeed = 1.25f;
    [SerializeField] float _delayOfNextTile = 2f;
    [SerializeField] float[] myTilePositions;
    
    //Set up single GM entity
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        } else if (singleton !=this)
        {
            Destroy(gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnTileRow();
    }
    //Spawns a row of 4 random tiles at the spawn location
    public void SpawnTileRow()
    {
        Instantiate(randomTile[Random.Range(0, randomTile.Length)], spawnTile1, Quaternion.identity);
        Instantiate(randomTile[Random.Range(0, randomTile.Length)], spawnTile2, Quaternion.identity);
        Instantiate(randomTile[Random.Range(0, randomTile.Length)], spawnTile3, Quaternion.identity);
        Instantiate(randomTile[Random.Range(0, randomTile.Length)], spawnTile4, Quaternion.identity);
        StartCoroutine(WaitForNextTile());
    }

    public void EndGame()
    {
        GameEnded = true;
        Invoke("GameOver", 2f);
        SoundManager.singleton.PlayEndSound();
    }

    private void GameOver()
    {
        //this loads another scene (scene = index reference) I.E our menu
        //Advertisement.Show();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    //Destroy block and 'clear material count'
    public void DestroyBlock(GameObject gameObject)
    {
        Destroy(gameObject);
    }
    //Increase Score
    public void IncreaseScore(int valueToAdd)
    {
        Score += valueToAdd;
        if (Score < 0)
        {
            Score = 0;
        }
        PlayerPrefs.SetInt("Score", Score);
    }

    //Track Players Total Hits
    public void BlocksMined (int blocks_mined)
    {
        BlocksDestroyed += blocks_mined;
        PlayerPrefs.SetInt("TotalBlocksDestroyed", BlocksDestroyed);
    }

    //Track Players Total Misses
    public void BlockMisses(int missedBlocks)
    {
        MissedBlocks += missedBlocks;
        PlayerPrefs.SetInt("TotalBlocksMissed", MissedBlocks);
    }
    //This waits the appropriate time before spawning the tile row of tiles
    IEnumerator WaitForNextTile()
    {
        yield return new WaitForSeconds(_delayOfNextTile);
        SpawnTileRow();
    }
}
