using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_HighscoreScript : MonoBehaviour
{
    public Text g_BestObject;
    // Start is called before the first frame update
    void Start()
    {
        g_BestObject.text = "Best : " +PlayerPrefs.GetInt("Birdie_HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
