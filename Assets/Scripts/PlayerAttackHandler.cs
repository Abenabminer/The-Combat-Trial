using UnityEngine;

public class PlayerAttackHandler : MonoBehaviour
{
    private PlayerControls controls;
    private RangedAttack rangedAttack;
    private MouseDirectionTracker mouseDirection;

    void Awake()
    {
        controls = new PlayerControls();
        rangedAttack = GetComponent<RangedAttack>();
        mouseDirection = GetComponent<MouseDirectionTracker>();
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
        if (controls.Player.RangedAttack.WasPressedThisFrame())
        {
            rangedAttack.CreateProjectile(mouseDirection.mouseDirection);
        }
    }
}
