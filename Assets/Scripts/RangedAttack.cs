using UnityEngine;

public class RangedAttack : MonoBehaviour
{  
    public GameObject projectilePrefab;

    public void CreateProjectile(Vector2 direction)
    {
        if (projectilePrefab == null) return;

        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.LookRotation(Vector3.forward, direction));
        ProjectileBase projectileScript = projectile.GetComponent<ProjectileBase>();
        projectileScript.direction = direction; 
    }

}
