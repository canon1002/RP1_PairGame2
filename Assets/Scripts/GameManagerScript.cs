using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject GoalPanelObject;

    // Start is called before the first frame update
    void Start()
    {
       GoalPanelObject.SetActive(false);
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

    //  
    public void OnSnow()
    {
        PlayerScript player = GameObject.FindObjectOfType<PlayerScript>();
        player.OnSnow();

    }

    // �S�[��
    public void OnGoal()
    {
        GoalPanelObject.SetActive(true);
        PlayerScript player = GameObject.FindObjectOfType<PlayerScript>();
        player.OnGoal();
    }
}
