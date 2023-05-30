using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //�ϐ�
    public float snowAmount = 16;//���
    public float decrease = 4;//�Ⴊ�����
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
                //�@�v���C���[�����ɂ���@�t���O��True��
                m_bIsOnSnow = true;

                // ���@���@�v���C���[����Z�ł���
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

                // �v���C���[�̐�Z����s�ɕύX
                m_bIsPlayerSnowSet = false;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {
            // ���ɂ���@�t���O��false��
            m_bIsOnSnow = false;

            // �v���C���[�̐�Z�����ɕύX
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
