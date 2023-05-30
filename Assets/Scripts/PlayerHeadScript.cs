using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadScript : MonoBehaviour
{

    public GameObject Player;
    
    private void OnTriggerEnter2D(Collider2D m_collision)//“ª‚Æ‘Ì‚Ì“–‚½‚è”»’è
    {
        if (m_collision.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<PlayerScript>().StickHead();
            transform.SetParent(Player.transform);
           
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
