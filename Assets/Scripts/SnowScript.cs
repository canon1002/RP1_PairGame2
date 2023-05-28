using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //ïœêî
    public float snowAmount = 100;//ê·ó 
    public float decrease = 4;//ê·Ç™å∏ÇÈó 
    private void OnTriggerEnter2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {
            GameManagerScript gamaManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
            gamaManagerScript.OnSnow();
            snowAmount -= decrease;
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
            Destroy(gameObject, 0.2f);
        }
    }



}
