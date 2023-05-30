using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //変数
    public float snowAmount = 16;//雪量
    public float decrease = 4;//雪が減る量
    public bool m_bIsPlayerSnowSet = true;
    public bool m_bIsOnSnow = false;

    public GameObject snowPrefab;
    GameObject snow1, snow2, snow3, snow4, snow5, snow6;

    private void OnTriggerEnter2D(Collider2D m_collision)
    {

        if (m_collision.gameObject.CompareTag("Player"))
        {
            if (m_bIsPlayerSnowSet == true)
            {
                //　プレイヤーが雪上にいる　フラグをTrueに
                m_bIsOnSnow = true;

                // 雪上　かつ　プレイヤーが雪纏できる
                if (m_bIsOnSnow && m_bIsPlayerSnowSet)
                {
                    GameManagerScript gamaManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
                    gamaManagerScript.OnSnow();

                    snow1 = Instantiate(snowPrefab, new Vector3(m_collision.transform.position.x, m_collision.transform.position.y - 0.5f, 0), Quaternion.identity);
                    snow2 = Instantiate(snowPrefab, new Vector3(m_collision.transform.position.x, m_collision.transform.position.y - 0.5f, 0), Quaternion.identity);
                    snow3 = Instantiate(snowPrefab, new Vector3(m_collision.transform.position.x, m_collision.transform.position.y - 0.5f, 0), Quaternion.identity);
                    snow4 = Instantiate(snowPrefab, new Vector3(m_collision.transform.position.x, m_collision.transform.position.y - 0.5f, 0), Quaternion.identity);
                    snow5 = Instantiate(snowPrefab, new Vector3(m_collision.transform.position.x, m_collision.transform.position.y - 0.5f, 0), Quaternion.identity);
                    snow6 = Instantiate(snowPrefab, new Vector3(m_collision.transform.position.x, m_collision.transform.position.y - 0.5f, 0), Quaternion.identity);

                    snowAmount -= decrease;
                }

                // プレイヤーの雪纏いを不可に変更
                m_bIsPlayerSnowSet = false;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {
            // 雪上にいる　フラグをfalseに
            m_bIsOnSnow = false;

            // プレイヤーの雪纏いを可に変更
            m_bIsPlayerSnowSet = true;

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (snowAmount <= 0)
        {
            Destroy(gameObject);
        }
    }




}
