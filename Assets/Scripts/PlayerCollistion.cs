using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollistion : MonoBehaviour
{
    public PlayerController pl;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //碰撞时才会发生，并传入碰撞到的对象
    private void OnCollisionEnter(Collision collision)
    {
        //检测碰撞到的对象标签是否为Box
        if (collision.collider.tag == "Box")
        {
            pl.enabled = false;
            //根据类型查找指定物体,并执行其函数
            FindObjectOfType<GameManager>().EndGame();
           
        }

    }
}
