using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.EventSystems.StandaloneInputModule;

public class PlayerScript : MonoBehaviour
{
    // �v���C���[�R���g���[���[
    PlayerController m_playerController;
    public Rigidbody2D m_rigidbody;
    public CircleCollider2D m_CircleCollider;
    public bool m_bIsMove;

    private CharacterController m_characterController;

    // �ړ���
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

        // �ړ��̃L�[����
        if (m_playerController.Player.Move.triggered)
        {
            m_bIsMove = true;
        }
        else
        {
            m_bIsMove = false;
        }

        // ������͂Ɖ����������x����A���ݑ��x���v�Z
        //var m_moveVelocity = new Vector3(m_inputMove.x * m_fMoveSpeed, m_rigidbody.velocity.y,m_inputMove.y * m_fMoveSpeed);

        // ���݃t���[���̈ړ��ʂ��ړ����x����v�Z
        //var moveDelta = m_moveVelocity * Time.deltaTime;
        //m_characterController.Move(moveDelta);

        // �ړ�����
        if (m_inputMove != Vector2.zero) ;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // ���͒l��ێ����Ă���
        m_inputMove = context.ReadValue<Vector2>();
    }

    // ��̏����s
    public void OnSnow()
    {
        transform.localScale += new Vector3(1, 1, 0);
    }

    // �S�[��
    public void OnGoal()
    {

    }

}
