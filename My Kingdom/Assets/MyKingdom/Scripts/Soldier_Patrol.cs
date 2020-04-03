using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Soldier_Patrol : MonoBehaviour
{
    private float patrolRadius;
    private float AtAttentionTimer;
    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    private Animator anim;
    private float speed = 0f;


    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        timer = AtAttentionTimer;
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0f;
        timer += Time.deltaTime;
        AtAttentionTimer = Random.Range(10f, 90f);
        if (timer >= AtAttentionTimer)
        {
            speed = 1f;
            anim.SetFloat("Forward", speed);
            patrolRadius = Random.Range(0f, 100f);
            Vector3 newPos = RandomNavSphere(transform.position, patrolRadius, -1);
            agent.SetDestination(newPos);
            timer = 0f;
        }
        speed = 0f;
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
