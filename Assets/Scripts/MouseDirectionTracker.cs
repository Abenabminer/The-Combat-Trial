using UnityEngine;
using UnityEngine.InputSystem;

public class MouseDirectionTracker : MonoBehaviour
{
    private Camera playerCamera;

    void Start()
    {
        playerCamera = Camera.main;
    }
  

    void Update()
    {
        Vector3 mouseWorldPosition = (Vector2)playerCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 mouseDirection = mouseWorldPosition - transform.position;
        mouseDirection = mouseDirection.normalized;
        Vector2 positionFromPlayer = mouseDirection * 5 + (Vector2)transform.position;


        Debug.DrawLine(transform.position, positionFromPlayer, Color.white, Time.deltaTime);
    }
}