using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public int damage; 

    void Update()
    {
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }
}
