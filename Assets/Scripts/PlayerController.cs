using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//默认情况下 会生成两个函数Start和Update
public class PlayerController : MonoBehaviour
{
    //public代表是公开使用，Rigidbody是类型  rb是一个名字或者称之为标签
    //这一行再此处的作用是，公开一个插槽到引擎界面上这个插槽的类型是Rigidbody,再脚本中他的代言人是rb我们通过rb来使用他
    //实际上可以理解为这把引擎的对象和脚本连接起来的桥梁
    //哦对了  用双斜杠开头的文本都是注释文本只是给人看的没有实际意义不会被执行，这方便维护和快速理解代码

    public Rigidbody rb;
    //前进方向 Z轴的力
    public float forwardForce = 1000f;
    public float rightForce = 500f;
    // Start is called before the first frame update
    //游戏运行的时候执行一次
    void Start()
    {
        

    }

    // Update is called once per frame
    //每一帧都会执行


    void FixedUpdate()
    {
        //向前移动的力不需要任何条件触发，会一直保持向前
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //像右移动的力需要D键按下的时候才会触发
        if (Input.GetKey(KeyCode.D))
        {
            //仅仅只改变x轴的力
            rb.AddForce(rightForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        //像左移动的力需要a键按下时才会触发
        if (Input.GetKey(KeyCode.A))
        {
            //仅仅只改变x轴的力
            rb.AddForce(-rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
