using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player_transform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�½�һ������
        Vector3 pos;
        //��������������
        pos = player_transform.position;
        //��Զ����һ���̶��ľ���
        pos.z  = pos.z - 5f;
        pos.y = pos.y + 2f;
        //���µ����
        transform.position = pos;
    }
}
