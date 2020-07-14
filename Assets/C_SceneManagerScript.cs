using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class C_SceneManagerScript : MonoBehaviour
{
    public void m_OnClickStart()
    {
        SceneManager.LoadScene("Game");
    }
    public void m_OnClickHome()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
