using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float patrolSpeed = 2f;
    public float chaseSpeed = 4f;
    private int currentPoint = 0;

    public float viewDistance = 10f;
    public float viewAngle = 45f;
    public LayerMask visionMask;
    public Transform player;

    public enum EnemyState 
    { 
        Patrol,
        Chase,
        Return
    }

    public EnemyState state = EnemyState.Patrol;

    void Update()
    {
        switch (state)
        {
            case EnemyState.Patrol:
                Patrol();
                if (CanSeePlayer())
                    state = EnemyState.Chase;
                break;

            case EnemyState.Chase:
                Chase();
                if (!CanSeePlayer())
                    state = EnemyState.Return;
                break;

            case EnemyState.Return:
                ReturnToPatrol();
                break;
        }
    }

    void Patrol()
    {
        Transform target = patrolPoints[currentPoint];
        MoveTowardsTarget(target.position, patrolSpeed);

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
        }
    }

    void Chase()
    {
        MoveTowardsTarget(player.position, chaseSpeed);
    }

    void ReturnToPatrol()
    {
        Transform target = patrolPoints[currentPoint];
        MoveTowardsTarget(target.position, patrolSpeed);

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            state = EnemyState.Patrol;
        }
    }

    void MoveTowardsTarget(Vector3 targetPos, float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        Vector3 direction = targetPos - transform.position;
        direction.y = 0;

        if (direction.sqrMagnitude > 0.001f)
        {
            Quaternion targetRot = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.deltaTime * 5f);
        }
    }

    bool CanSeePlayer()
    {
        Vector3 origin = transform.position + Vector3.up * 0.5f;
        Vector3 dirToPlayer = (player.position - origin).normalized;

        if (Vector3.Angle(transform.forward, dirToPlayer) > viewAngle)
            return false;

        if (Vector3.Distance(origin, player.position) > viewDistance)
            return false;

        if (Physics.Raycast(origin, dirToPlayer, out RaycastHit hit, viewDistance, visionMask))
        {
            if (hit.transform == player)
                return true;
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