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

    // 入力制限
    public bool m_bIsControll;

    // 雪に触れた際のサイズ増加値
    public float m_fonSnowUpSize = 0.1f;

    // 頭がくっついているかどうか
    private bool m_bIsStickHead = false;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
        m_playerController = new PlayerController();
        m_playerController.Enable();
        m_bIsControll = true;
        m_bIsStickHead = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_fAxisHorizontal = Input.GetAxisRaw("Horizontal");

        if (m_bIsControll)
        {

            if (0f < m_fAxisHorizontal)
            {
                //GetComponent<Animator>().Play("MoveRight");
                //transform.localScale = new Vector2(1f, 2f);
                m_bIsMove = true;

                if (!m_bIsStickHead)
                {
                    transform.Rotate(0f, 0f, -2f);
                }
            }
            else if (m_fAxisHorizontal < 0f)
            {
                //GetComponent<Animator>().Play("MoveLeft");
                //transform.localScale = new Vector2(-1f, 2f);
                m_bIsMove = true;
                if (!m_bIsStickHead)
                {
                    transform.Rotate(0f, 0f, 2f);
                }
            }
            else
            {
                m_bIsMove = false;
            }

            if (Input.GetKeyDown((KeyCode)Key.R))
            {
                GameManagerScript gamaManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
                gamaManagerScript.SceneReset();
            }

        }

    }

    private void FixedUpdate()
    {
        if (m_bIsControll)
        {
            // 移動処理
            m_rigidbody.velocity = new Vector3(
                m_fAxisHorizontal * m_fHorizontalSpeed,
                m_rigidbody.velocity.y
                );
        }
        else
        {
            // 移動処理
            m_rigidbody.velocity = new Vector3(
                0,
                m_rigidbody.velocity.y
                );
        }

    }

    public void StickHead()
    {
        m_bIsStickHead = true;
    }

    public bool GetIsStickHead()
    {
        return m_bIsStickHead;
    }

    // 雪の上を歩行
    public void OnSnow()
    {
        transform.localScale += new Vector3(m_fonSnowUpSize, m_fonSnowUpSize, 0);
    }

    // ゴール
    public void OnGoal()
    {
        m_playerController.Disable();
        m_bIsControll = false;
    }

}
