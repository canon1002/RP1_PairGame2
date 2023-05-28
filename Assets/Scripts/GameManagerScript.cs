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

    // リスタート
    private IEnumerator Restart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // シーン切り替え
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    // ゴール
    public void OnGoal()
    {
        
    }
}
