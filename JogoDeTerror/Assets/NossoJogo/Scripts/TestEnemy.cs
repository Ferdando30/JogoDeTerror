using UnityEngine;
using UnityEngine.AI;

public class TestEnemy : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float chaseSpeed = 4f;
    public float patrolSpeed = 2f;
    public float viewDistance = 10f;
    public float viewAngle = 45f;
    public LayerMask visionMask;

    private NavMeshAgent agent;
    private int currentPoint = 0;
    public Transform player;

    public enum EnemyState
    {
        Patrol,
        Chase,
        Return
    }
    public EnemyState state = EnemyState.Patrol;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = patrolSpeed;
        agent.SetDestination(patrolPoints[currentPoint].position);
    }


    void Update()
    {
        switch (state)
        {
            case EnemyState.Patrol:
                Patrol();
                if (CanSeePlayer()) StartChase();
                break;

            case EnemyState.Chase:
                Chase();
                if (!CanSeePlayer()) state = EnemyState.Return;
                break;

            case EnemyState.Return:
                ReturnToPatrol();
                break;
        }
    }

    void Patrol()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.3f)
        {
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
            agent.SetDestination(patrolPoints[currentPoint].position);
            if (CanSeePlayer() ) StartChase();
        }
    }

    void StartChase()
    {
        state = EnemyState.Chase;
        agent.speed = chaseSpeed;
    }

    void Chase()
    {
        agent.SetDestination(player.position);
    }

    void ReturnToPatrol()
    {
        agent.speed = patrolSpeed;
        agent.SetDestination(patrolPoints[currentPoint].position);

        if (!agent.pathPending && agent.remainingDistance < 0.3f)
            state = EnemyState.Patrol;
    }

    bool CanSeePlayer()
    {
        if (player == null) return false;

        Vector3 dirToPlayer = (player.position - transform.position).normalized;
        Vector3 origin = transform.position + Vector3.up * 0.5f;

        if (Vector3.Angle(transform.forward, dirToPlayer) > viewAngle)
            return false;

        if (Vector3.Distance(transform.position, player.position) > viewDistance)
            return false;

        if (Physics.Raycast(origin, dirToPlayer, out RaycastHit hit, viewDistance, visionMask))
        {
            return hit.transform == player;
        }

        return false;
    }
    void OnDrawGizmos()
    {
#if UNITY_EDITOR
        if (!UnityEditor.EditorApplication.isPlaying)
        {
            // Draw Gizmos ONLY in Editor Mode
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, viewDistance);

            Vector3 leftBoundary = Quaternion.Euler(0, -viewAngle, 0) * transform.forward * viewDistance;
            Vector3 rightBoundary = Quaternion.Euler(0, viewAngle, 0) * transform.forward * viewDistance;

            Gizmos.DrawLine(transform.position, transform.position + leftBoundary);
            Gizmos.DrawLine(transform.position, transform.position + rightBoundary);
        }
#endif
    }
}
