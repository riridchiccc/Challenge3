using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    

    public TextMeshProUGUI coinCountText;
    public int coinCount = 0;

    // Start is called before the first frame update
    void Start()
    {
       /* if (PlayerPrefs.HasKey("TNCoin"))
        {
            coinCount = PlayerPrefs.GetInt("TNCoin");
        }*/

        coinCountText.text = coinCount.ToString();
    }



    public void AddScore(int _coinCount)
    {
       coinCount += _coinCount;
    }
}