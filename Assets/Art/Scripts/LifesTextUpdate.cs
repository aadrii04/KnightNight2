using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifesTextUpdate : MonoBehaviour
{
    public void SetLifestext(float lifes)
    {
        GetComponent<TMP_Text>().text = "Lifes:" + lifes;
    }
}
