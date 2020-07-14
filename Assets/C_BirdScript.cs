using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C_BirdScript : MonoBehaviour
{
    public Rigidbody2D g_RigidBody;
    float g_velocity = 3;
    public GameObject g_ScoreMgr;
    public Vector2 g_pos;
    float g_YLimit;
    // Start is called before the first frame update
    void Start()
    {
        g_YLimit = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        m_JumpHandler();
        m_LimitBirdJump();
    }
    void m_LimitBirdJump()
    {
        g_pos = this.transform.position;
        if(g_pos.y >= g_YLimit)
        {
            g_pos.y = g_YLimit;
            this.transform.position = g_pos;
        }
    }
    void m_JumpHandler()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            g_RigidBody.velocity = Vector2.up * g_velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Game Over");
        if (PlayerPrefs.GetInt("Birdie_HighScore") < g_ScoreMgr.GetComponent<C_ScoreMgrScript>().g_Score)
        {
            PlayerPrefs.SetInt("Birdie_HighScore", g_ScoreMgr.GetComponent<C_ScoreMgrScript>().g_Score);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        g_ScoreMgr.GetComponent<C_ScoreMgrScript>().m_increaseScore();
    }
}