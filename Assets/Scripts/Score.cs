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
        //�����Z����������С����ת�����ı����µ�UI��ʾ
        socreText.text = pl.position.z.ToString("0");
    }
}
