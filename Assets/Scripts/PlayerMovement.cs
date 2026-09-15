using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerControls controls;
    private Rigidbody2D rigidBody;
    private Vector2 movement;
    public float moveSpeed = 5f;

    void Awake()
    {
        controls = new PlayerControls();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        movement = controls.Player.Move.ReadValue<Vector2>();
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}