using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //�ϐ�
    public float snowAmount = 16;//���
    public float decrease = 4;//�Ⴊ�����
    bool isTrue = false;

    private void OnTriggerEnter2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {

            //����炪�G���[�ɂȂ�
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
