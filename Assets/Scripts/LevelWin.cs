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
        //��ȡ����ǰ���������
        int index = SceneManager.GetActiveScene().buildIndex;
        //������һ������
        Debug.Log(index);
        SceneManager.LoadScene(index + 1);
    }
}
