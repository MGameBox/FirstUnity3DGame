using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextLevel()
    {
        //获取到当前场景的序号
        int index = SceneManager.GetActiveScene().buildIndex;
        //加载下一个场景
        Debug.Log(index);
        SceneManager.LoadScene(index + 1);
    }
}
