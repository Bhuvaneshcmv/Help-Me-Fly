using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_EnemyManagerScript : MonoBehaviour
{
    public GameObject g_PipePrefab;
    float g_MaxHeight;
    float g_MinHeight;
    int g_InitialXPos;
    int g_PresentIndex;
    Vector2 g_PipePos;
    GameObject[] g_ArrayOfPipes;
    // Start is called before the first frame update
    void Start()
    {
        g_InitialXPos = 5;
        g_MaxHeight = 3.4f;
        g_MinHeight = 0.5f;
        g_ArrayOfPipes = new GameObject[50];
        g_PresentIndex = 0;
        InvokeRepeating("m_Respawn", 1, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void m_Respawn()
    {
        g_PipePos = new Vector2(g_InitialXPos, UnityEngine.Random.Range(g_MinHeight, g_MaxHeight));
        g_ArrayOfPipes[g_PresentIndex] = Instantiate(g_PipePrefab, g_PipePos, Quaternion.identity);
        g_PresentIndex++;
        if(g_PresentIndex >=20)
        {
            g_PresentIndex = 0;
        }
    }
}
