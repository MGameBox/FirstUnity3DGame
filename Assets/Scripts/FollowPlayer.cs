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
        //新建一个坐标
        Vector3 pos;
        //坐标等于玩家坐标
        pos = player_transform.position;
        //永远保持一个固定的距离
        pos.z  = pos.z - 5f;
        pos.y = pos.y + 2f;
        //更新到相机
        transform.position = pos;
    }
}
