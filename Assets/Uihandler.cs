using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uihandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quite()
    {
        //�����˳�������������������Ե�ʱ�򲢲������ʵ��Ч�������Ǵ����������˳���Ϸ����
        Application.Quit();
    }

    public void Go()
    {
        //�����������е���һ������
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

