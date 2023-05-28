using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowScript : MonoBehaviour
{
    //
    private void OnTriggerEnter2D(Collider2D m_collision)
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {
            GameManagerScript gamaManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
            gamaManagerScript.OnSnow();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
