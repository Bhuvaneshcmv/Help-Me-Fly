using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PipePrefabScipt : MonoBehaviour
{
    int g_MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        g_MoveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        m_Move();
        m_Destroy();
    }
    void m_Move()
    {
        this.transform.Translate(Vector2.left * g_MoveSpeed * Time.deltaTime);
    }
    void m_Destroy()
    {
        if (this.transform.position.x < -25)
        {
            Destroy(this.gameObject);
        }
    }
}
