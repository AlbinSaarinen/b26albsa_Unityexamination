using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public float patrolDistance = 4f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(
            Time.time * speed,
            patrolDistance
        );

        transform.position = new Vector3(
            startPosition.x + movement - patrolDistance / 2f,
            startPosition.y,
            startPosition.z
        );
    }
}