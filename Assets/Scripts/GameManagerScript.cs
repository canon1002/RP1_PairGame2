using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ���X�^�[�g
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    // �V�[���؂�ւ�
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    // �S�[��
    public void OnGoal()
    {
        
    }
}
