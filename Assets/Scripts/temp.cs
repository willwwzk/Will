using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    float speed = 0.5f;
    int health = 100f;
    bool alive = true;
    string playerName = "Player1"

    void Awake()//无论代码是否唤醒都会执行一遍
    {

    } 

    void Start()//脚本刚开始时最先执行的函数，一般只执行一次
    {

    }

    void Update()每帧都会更新
    {
        if(health<0)
{
    Debug.Log("game over")
}
else if(health>0)
{
    Debug.Log("game continues")
}
    }

}


if(health<0)
{
    Debug.Log("game over")
}
else if(health>0)
{
    Debug.Log("game continues")
}


void AddHealth(int health)
{
    health += 1;
}
