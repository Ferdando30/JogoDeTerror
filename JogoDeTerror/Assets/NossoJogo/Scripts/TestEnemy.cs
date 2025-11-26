using UnityEngine;
using UnityEngine.AI;

public class TestEnemy : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float chaseSpeed = 4f;
    public float patrolSpeed = 2f;
    [Range(5, 50)] public float viewDistance = 10f;
    [Range(30, 180)] public float viewAngle = 45f;
    public LayerMask visionMask;
    public float stoppingDistance = 0.5f;
    public float chaseTimeout = 5f;

    public Transform player;

    private NavMeshAgent agent;
    private int currentPoint = 0;
    private float chaseTimer;
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

        if (patrolPoints.Length == 0)
        {
            Debug.LogError("No patrol points assigned!");
            enabled = false;
            return;
        }

        agent.speed = patrolSpeed;
        agent.stoppingDistance = stoppingDistance;
        agent.autoBraking = true;

        currentPoint = 0;
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
                chaseTimer += Time.deltaTime;

                if (!CanSeePlayer() && chaseTimer >= chaseTimeout)
                    state = EnemyState.Return;
                break;

            case EnemyState.Return:
                ReturnToPatrol();
                if (CanSeePlayer()) StartChase();
                break;
        }
    }

    void GoToNextPoint()
    {
        if (patrolPoints.Length == 0) return;

        currentPoint = (currentPoint + 1) % patrolPoints.Length;

        if (Vector3.Distance(transform.position, patrolPoints[currentPoint].position) > 0.01f)
        {
            agent.SetDestination(patrolPoints[currentPoint].position);
        }
        else
        {
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
            agent.SetDestination(patrolPoints[currentPoint].position);
        }
    }

    void Patrol()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance + 0.1f)
        {
            if (agent.velocity.sqrMagnitude < 0.1f || !agent.hasPath)
            {
                GoToNextPoint();
            }
        }
    }

    void StartChase()
    {
        state = EnemyState.Chase;
        agent.speed = chaseSpeed;
        agent.stoppingDistance = 0f;
        chaseTimer = 0f;
    }

    void Chase()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            state = EnemyState.Return;
        }
    }

    void ReturnToPatrol()
    {
        agent.speed = patrolSpeed;
        agent.stoppingDistance = stoppingDistance;
        agent.SetDestination(patrolPoints[currentPoint].position);

        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            if (agent.velocity.sqrMagnitude < 0.1f)
            {
                state = EnemyState.Patrol;
            }
        }
    }

    bool CanSeePlayer()
    {
        if (!player) return false;

        Vector3 direction = player.position - transform.position;
        float sqrDist = direction.sqrMagnitude;

        if (sqrDist > viewDistance * viewDistance)
            return false;

        direction.Normalize();

        if (Vector3.Angle(transform.forward, direction) > viewAngle / 2)
            return false;

        Vector3 origin = transform.position + Vector3.up * 1f;
        Vector3 target = player.position + Vector3.up * 1f;
        Vector3 dirToTarget = (target - origin).normalized;

        Debug.DrawRay(origin, dirToTarget * viewDistance, Color.red);

        if (Physics.Raycast(origin, dirToTarget, out RaycastHit hit, viewDistance, visionMask))
        {
            return hit.transform == player;
        }

        return false;
    }

    void OnDrawGizmosSelected()
    {
        if (agent != null && patrolPoints != null && currentPoint < patrolPoints.Length)
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawLine(transform.position, patrolPoints[currentPoint].position);
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, viewDistance);

        Vector3 leftBound = Quaternion.Euler(0, -viewAngle / 2, 0) * transform.forward * viewDistance;
        Vector3 rightBound = Quaternion.Euler(0, viewAngle / 2, 0) * transform.forward * viewDistance;

        Gizmos.DrawLine(transform.position, transform.position + leftBound);
        Gizmos.DrawLine(transform.position, transform.position + rightBound);
    }
}