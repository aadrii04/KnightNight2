using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextBehavior : MonoBehaviour
{

    public void SetScoretext(int score)
    {
        GetComponent<TMP_Text>().text = "Coin: " + score;
    }
}

