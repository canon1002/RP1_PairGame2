using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //ïœêî
    public float snowAmount = 16;//ê·ó 
    public float decrease = 4;//ê·Ç™å∏ÇÈó 
    bool isTrue = false;

    private void OnTriggerEnter2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {

            //Ç±ÇÍÇÁÇ™ÉGÉâÅ[Ç…Ç»ÇÈ
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
