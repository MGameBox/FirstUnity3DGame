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
    //��ײʱ�Żᷢ������������ײ���Ķ���
    private void OnCollisionEnter(Collision collision)
    {
        //�����ײ���Ķ����ǩ�Ƿ�ΪBox
        if (collision.collider.tag == "Box")
        {
            pl.enabled = false;
            //�������Ͳ���ָ������,��ִ���亯��
            FindObjectOfType<GameManager>().EndGame();
           
        }

    }
}
