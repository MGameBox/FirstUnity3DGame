using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GameOver");
            gameHasEnded = true;
            Invoke("ReStart", 3f);
           

        }
        
    }

    void ReStart()
    {
        //场景管理器加载当前场景
        //LoadScene是加载场景
        //GetActiveScene是获取当前场景
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompeleteLevel()
    {
        Debug.Log("level win");
        panel.SetActive(true);
    }

}
