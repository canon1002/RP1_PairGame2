using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    // �v���C���[�R���g���[���[
    PlayerController m_playerController;
    public Rigidbody2D m_rigidbody;
    public CircleCollider2D m_CircleCollider;
    public bool m_bIsMove;

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

        // �ړ��̃L�[����
        if (m_playerController.Player.Move.triggered)
        {
            m_bIsMove = true;

            

        }
        else
        {
            m_bIsMove = false;
        }

        // �ړ�����
        m_rigidbody.velocity = new Vector3(
        m_fAxisHorizontal * m_fHorizontalSpeed,
        m_rigidbody.velocity.y
        );

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
