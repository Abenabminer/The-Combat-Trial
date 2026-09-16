using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    [SerializeField] private string projectileTag;

    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log ($"Health Remaing {health}");
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(projectileTag))
        {
            ProjectileBase projectile = other.GetComponent<ProjectileBase>();
            TakeDamage(projectile.damage);
            projectile.Impact();
        }
        else
        {
            return;
        }
    }
}
