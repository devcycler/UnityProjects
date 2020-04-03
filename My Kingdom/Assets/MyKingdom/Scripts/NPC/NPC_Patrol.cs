using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class NPC_Patrol : MonoBehaviour

{
    private float wanderRadius;
    private float wanderTimer;
    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    private bool kingisReady;

    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        kingisReady = ThroneManager.singleton.kingIsAvailable;
        if (kingisReady)
        {
            //select a random civy and have them approach
        }
        timer += Time.deltaTime;
        wanderTimer = Random.Range(10f, 90f);
        if (timer >= wanderTimer)
        {
            wanderRadius = Random.Range(0f, 1000f);
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        return navHit.position;
    }
}