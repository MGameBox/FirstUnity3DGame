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
        //�������������ص�ǰ����
        //LoadScene�Ǽ��س���
        //GetActiveScene�ǻ�ȡ��ǰ����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompeleteLevel()
    {
        Debug.Log("level win");
        panel.SetActive(true);
    }

}
