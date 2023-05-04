using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Ĭ������� ��������������Start��Update
public class PlayerController : MonoBehaviour
{
    //public�����ǹ���ʹ�ã�Rigidbody������  rb��һ�����ֻ��߳�֮Ϊ��ǩ
    //��һ���ٴ˴��������ǣ�����һ����۵���������������۵�������Rigidbody,�ٽű������Ĵ�������rb����ͨ��rb��ʹ����
    //ʵ���Ͽ������Ϊ�������Ķ���ͽű���������������
    //Ŷ����  ��˫б�ܿ�ͷ���ı�����ע���ı�ֻ�Ǹ��˿���û��ʵ�����岻�ᱻִ�У��ⷽ��ά���Ϳ���������

    public Rigidbody rb;
    //ǰ������ Z�����
    public float forwardForce = 1000f;
    public float rightForce = 500f;
    // Start is called before the first frame update
    //��Ϸ���е�ʱ��ִ��һ��
    void Start()
    {
        

    }

    // Update is called once per frame
    //ÿһ֡����ִ��


    void FixedUpdate()
    {
        //��ǰ�ƶ���������Ҫ�κ�������������һֱ������ǰ
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //�����ƶ�������ҪD�����µ�ʱ��Żᴥ��
        if (Input.GetKey(KeyCode.D))
        {
            //����ֻ�ı�x�����
            rb.AddForce(rightForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        //�����ƶ�������Ҫa������ʱ�Żᴥ��
        if (Input.GetKey(KeyCode.A))
        {
            //����ֻ�ı�x�����
            rb.AddForce(-rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
