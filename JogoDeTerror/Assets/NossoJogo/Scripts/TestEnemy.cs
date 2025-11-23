using UnityEngine;
using UnityEngine.AI;

public class TestEnemy : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float chaseSpeed = 4f;
    public float patrolSpeed = 2f;

    private NavMeshAgent agent;
    private int currentPoint = 0;

    public enum EnemyState { Patrol, Chase, Return }
    public EnemyState state = EnemyState.Patrol;

    public Transform player;

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
        return false;
    }
}
