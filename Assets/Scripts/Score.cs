using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform pl;
    public Text socreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //将玩家Z轴坐标舍弃小数点转换成文本更新到UI显示
        socreText.text = pl.position.z.ToString("0");
    }
}
