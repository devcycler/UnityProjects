using System.Collections;
using UnityEngine;

public class TimeBasedScore : MonoBehaviour
{
    [SerializeField] private float _score;
    [SerializeField] private float scoreTick;

    private void Start()
    {
        StartCoroutine(IncreaseScoreByTime());
    }

    private IEnumerator IncreaseScoreByTime()
    {
        while (GameManager.Instance.GetCurrentGameState() == GameState.PLAYING)
        {
            _score += scoreTick * Time.deltaTime;
            yield return null;
        }
        yield break;
    }
}

