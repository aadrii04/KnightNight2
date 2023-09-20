using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreBehavior : MonoBehaviour
{
    public int score;
    public UnityEvent<int> OnchangeScore;
    public GameObject[] key;

  
    private void Start()
    {
        RestartScore();
    }

    public void AddScore()
    {
        score += 1;
        OnchangeScore.Invoke(score);
        ActiveKey();

    }

    public void RestartScore()
    {
        score = 0;
        OnchangeScore.Invoke(score);
    }

    public void ActiveKey()
    {
        if (score == 3)
        {
            for(int i = 0; i < 3; i++)
            {
                key[i].SetActive(true);
            }
        }
    }

    public void DesactiveKey()
    {
        for (int i = 0; i < 3; i++)
        {
            key[i].SetActive(false);
        }
    }
}