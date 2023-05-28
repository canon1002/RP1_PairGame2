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

    private CharacterController m_characterController;

    // 移動量
    public float m_fMoveSpeed = 5;
    private Vector2 m_inputMove;

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

        if(Input.GetKeyDown(KeyCode.A))
        {
            m_bIsMove = true;
            transform.position.Set(m_fMoveSpeed, m_rigidbody.velocity.y, 1f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            m_bIsMove = true;
        }else
        {
            m_bIsMove = false;
        }

        // 移動のキー入力
        if (m_playerController.Player.Move.triggered)
        {
            m_bIsMove = true;
        }
        else
        {
            m_bIsMove = false;
        }

        // 操作入力と鉛直方向速度から、現在速度を計算
        //var m_moveVelocity = new Vector3(m_inputMove.x * m_fMoveSpeed, m_rigidbody.velocity.y,m_inputMove.y * m_fMoveSpeed);

        // 現在フレームの移動量を移動速度から計算
        //var moveDelta = m_moveVelocity * Time.deltaTime;
        //m_characterController.Move(moveDelta);

        // 移動処理
        if (m_inputMove != Vector2.zero) ;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // 入力値を保持しておく
        m_inputMove = context.ReadValue<Vector2>();
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
