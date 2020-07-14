using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_ScoreMgrScript : MonoBehaviour
{
    public Text g_TextObject;
    public int g_Score;
    // Start is called before the first frame update
    void Start()
    {
        g_Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        g_TextObject.text = " SCORE : " + g_Score;
    }
    public void m_increaseScore()
    {
        g_Score++;
    }
}
