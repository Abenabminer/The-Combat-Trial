using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public int damage;
    public float lifetime;

    void Update()
    {
        transform.position += (Vector3)direction * speed * Time.deltaTime;
        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Impact()
    {
        Destroy(gameObject);
    }
}
