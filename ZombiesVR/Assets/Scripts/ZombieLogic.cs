using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLogic : MonoBehaviour
{
    private float m_AccumulatedTime;
    private bool m_IsStaring;
    [SerializeField] float m_StareTimeToDeath = 2;

    void Start()
    {
        m_AccumulatedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_IsStaring)
        {
            m_AccumulatedTime += Time.deltaTime;
            if(m_AccumulatedTime >= m_StareTimeToDeath)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            m_AccumulatedTime = 0;
        }
    }

    public void StartStare()
    {
        m_IsStaring = true;
    }

    public void StopStare()
    {
        m_IsStaring = false;
    }
}
