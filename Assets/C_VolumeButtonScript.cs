using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_VolumeButtonScript : MonoBehaviour
{ 
    public Sprite g_VolumeUp;
    public Sprite g_Mute;
    public Image g_Image;

    // Start is called before the first frame update
    void Start()
    {
        m_SetImage();
    }
    public void m_OnVolumeBtnClick()
    {
        if (PlayerPrefs.HasKey("Birdie_Volume") == false || PlayerPrefs.GetInt("Birdie_Volume") == 0)
        {
            PlayerPrefs.SetInt("Birdie_Volume", 1);
            m_SetImage();
        }
        else
        {
            PlayerPrefs.SetInt("Birdie_Volume", 0);
            m_SetImage();
        }
        print(PlayerPrefs.HasKey("Birdie_Volume") == false);
    }
    void m_SetImage() 
    {
        if (PlayerPrefs.HasKey("Birdie_Volume") == false || PlayerPrefs.GetInt("Birdie_Volume") == 0)
        {
            g_Image.sprite = g_Mute;
        }
        if (PlayerPrefs.GetInt("Birdie_Volume") == 1)
        {
            g_Image.sprite = g_VolumeUp;
        }
    }

}
