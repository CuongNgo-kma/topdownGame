using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_speedPlayer;
    private Rigidbody2D m_Rigidbody;
    private float horizontal;
    private float vertical;
    private enum MovementState
    {
        PlayerIdle, VerticalMovement, HorizalMovement
    }

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Tạo một Vector3 mới với giá trị horizontal và vertical
        Vector3 movement = new Vector2(horizontal, vertical) * m_speedPlayer;

        // Gán Vector3 làm vận tốc cho Rigidbody
        m_Rigidbody.velocity = movement;
    }
}
