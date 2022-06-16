using UnityEngine;
public enum GameState
{
    PLAYING,
    PAUSED,
    GAMEOVER
}
public class GameManager: MonoBehaviour
{
    private GameManager gameManager;
    public static GameManager Instance;
    private GameState state;

    private void Awake()
    {
        Instance = this;
        state = GameState.PLAYING;
    }

    public GameState GetCurrentGameState()
    {
        return state;
    }
}