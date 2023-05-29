using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.EventSystems.StandaloneInputModule;

public class PlayerScript : MonoBehaviour
{

    // プレイヤーコントローラー
    PlayerController m_playerController;
    public Rigidbody2D m_rigidbody;
    public CircleCollider2D m_CircleCollider;
    public bool m_bIsMove;

    // 左右移動用
    private float m_fAxisHorizontal;
    public float m_fHorizontalSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
        m_playerController = new PlayerController();
        m_playerController.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        m_fAxisHorizontal = Input.GetAxisRaw("Horizontal");

        if (0f < m_fAxisHorizontal)
        {
            //GetComponent<Animator>().Play("MoveRight");
            //transform.localScale = new Vector2(1f, 2f);
            m_bIsMove = true;
        }
        else if (m_fAxisHorizontal < 0f)
        {
            //GetComponent<Animator>().Play("MoveLeft");
            //transform.localScale = new Vector2(-1f, 2f);
            m_bIsMove = true;
        }
        else
        {
            m_bIsMove = false;
        }

    }

    private void FixedUpdate()
    {

        // 移動処理
        m_rigidbody.velocity = new Vector3(
        m_fAxisHorizontal * m_fHorizontalSpeed,
        m_rigidbody.velocity.y
        );

    }

    // 雪の上を歩行
    public void OnSnow()
    {
        transform.localScale += new Vector3(1, 1, 0);
    }

    // ゴール
    public void OnGoal()
    {

    }

}
