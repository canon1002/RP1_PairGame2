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

    // ���E�ړ��p
    private float m_fAxisHorizontal;
    public float m_fHorizontalSpeed = 5f;

    // ���͐���
    public bool m_bIsControll;

    // ��ɐG�ꂽ�ۂ̃T�C�Y�����l
    public float m_fonSnowUpSize = 0.1f;

    // �����������Ă��邩�ǂ���
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
            // �ړ�����
            m_rigidbody.velocity = new Vector3(
                m_fAxisHorizontal * m_fHorizontalSpeed,
                m_rigidbody.velocity.y
                );
        }
        else
        {
            // �ړ�����
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

    // ��̏����s
    public void OnSnow()
    {
        transform.localScale += new Vector3(m_fonSnowUpSize, m_fonSnowUpSize, 0);
    }

    // �S�[��
    public void OnGoal()
    {
        m_playerController.Disable();
        m_bIsControll = false;
    }

}
