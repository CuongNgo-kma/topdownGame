using UnityEngine;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_speedPlayer;
    private Rigidbody2D m_Rigidbody;
    private float horizontal;
    private float vertical;
    private Animator anim;

    private enum MovementState
    {
        idle, top, left, right, bot
    }
    private MovementState State = MovementState.idle;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Tạo một Vector3 mới với giá trị horizontal và vertical
        Vector3 movement = new Vector2(horizontal, vertical) * m_speedPlayer;

        // Gán Vector3 làm vận tốc cho Rigidbody
        m_Rigidbody.velocity = movement;
        StateMovement();
    }
    private void StateMovement()
    {
        if (horizontal >0f)
        {
            State = MovementState.right;
        }
        else if (horizontal <0f)
        {
            State = MovementState.left;
        }
        else if(vertical >0f)
        {
            State = MovementState.top;
        }
        else if (vertical <0f)
        {
            State = MovementState.bot;
        }
        else State = MovementState.idle;
        anim.SetInteger("State", (int)State);
    }
}
