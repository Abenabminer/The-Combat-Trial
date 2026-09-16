using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed;
    private Rigidbody2D rigidBody;
    private EnemyAttackHandler enemyAttack;
  

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rigidBody = GetComponent<Rigidbody2D>();
        enemyAttack = GetComponent<EnemyAttackHandler>();
    }

    void FixedUpdate()
    {
        Vector3 playerPosition = (Vector3)player.transform.position;
        Vector2 playerDirection = playerPosition - transform.position;
        playerDirection = playerDirection.normalized;
        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if (distanceToPlayer > enemyAttack.attackRange)
        {
            rigidBody.MovePosition((Vector2)rigidBody.position + playerDirection * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rigidBody.linearVelocity = Vector2.zero;
        }
    }
}
