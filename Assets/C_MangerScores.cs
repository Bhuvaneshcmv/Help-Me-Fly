using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_MangerScores : MonoBehaviour
{
    public Text g_LastScore;
    public Text g_BestScore;

    // Start is called before the first frame update
    void Start()
    {
        g_LastScore.text = "SCORE : "+ PlayerPrefs.GetInt("Birdie_LastScore");
        g_BestScore.text = "BEST : " + PlayerPrefs.GetInt("Birdie_HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
