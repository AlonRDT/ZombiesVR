using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_Zombies;
    [SerializeField] private float m_MonsterSpeed = 10;
    [SerializeField] private float m_MonsterDistanceToDefeat = 1;

    // Update is called once per frame
    void Update()
    {
        bool isVictory = true;
        bool isDefeat = false;

        foreach (var monster in m_Zombies)
        {
            if(monster != null)
            {
                isVictory = false;
                monster.transform.position = Vector3.MoveTowards(monster.transform.position, transform.position, m_MonsterSpeed * Time.deltaTime);
                monster.transform.LookAt(transform);
                monster.transform.eulerAngles = new Vector3(0, monster.transform.eulerAngles.y, 0);
                //Debug.Log(Vector3.Distance(monster.transform.position, transform.position));
                if(Vector3.Distance(monster.transform.position, transform.position) < m_MonsterDistanceToDefeat)
                {
                    isDefeat = true;
                }
            }
        }

        if(isVictory == true)
        {
            SceneManager.LoadScene(0);
        }
        else if(isDefeat == true)
        {
            SceneManager.LoadScene(0);
        }
    }
}
