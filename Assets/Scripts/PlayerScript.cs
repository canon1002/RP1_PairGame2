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
        // �ړ��̃L�[����
        if (m_playerController.Player.Move.triggered)
        {
            m_bIsMove = true;
        }
        else
        {
            m_bIsMove = false;
        }


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
