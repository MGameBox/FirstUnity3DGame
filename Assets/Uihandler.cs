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
        //程序退出函数，我们用引擎调试的时候并不会产生实际效果，但是打包发布后会退出游戏程序
        Application.Quit();
    }

    public void Go()
    {
        //加载生成序列的下一个场景
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

