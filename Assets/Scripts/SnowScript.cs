using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //変数
    public float snowAmount = 8;//雪量
    public float decrease = 4;//雪が減る量
    bool isTrue = false;

    private void OnTriggerEnter2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {

            //これらがエラーになる
            GameManagerScript gamaManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
            gamaManagerScript.OnSnow();
            isTrue = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrue)
        {
            snowAmount -= decrease;
        }
        if (snowAmount <= 0)
        {
            Destroy(gameObject);
        }
    }




}
