using UnityEngine;
using UnityEngine.InputSystem;

public class KharacterController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float normalTurnSpeed = 100f;
    [SerializeField] private float boostedTurnSpeed = 200f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody rb;
    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        float moveForward = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + transform.forward * moveForward * moveSpeed * Time.fixedDeltaTime);

        float currentTurnSpeed = Input.GetKey(KeyCode.LeftShift) ? boostedTurnSpeed : normalTurnSpeed;

        float turn = Input.GetAxisRaw("Horizontal");
        rb.MoveRotation(rb.rotation * Quaternion.Euler(Vector3.up * turn * currentTurnSpeed * Time.fixedDeltaTime));
    }

    private void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.otherCollider.CompareTag("Ground"))
                isGrounded = true;
                return;
        }

        isGrounded = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}