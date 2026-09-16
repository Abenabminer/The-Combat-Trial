using UnityEngine;
using UnityEngine.InputSystem;

public class MouseDirectionTracker : MonoBehaviour
{
    private Camera playerCamera;
    public Vector2 directionFromPlayer;
    public Vector2 mouseDirection;

    void Start()
    {
        playerCamera = Camera.main;
    }
  

    void Update()
    {
        Vector3 mouseWorldPosition = (Vector2)playerCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mouseDirection = mouseWorldPosition - transform.position;
        mouseDirection = mouseDirection.normalized;
        directionFromPlayer = mouseDirection + (Vector2)transform.position;


        Debug.DrawLine(transform.position, directionFromPlayer, Color.white, Time.deltaTime);
    }
}