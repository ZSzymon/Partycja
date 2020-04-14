using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class EnemyController : AttackingSystemEnemy
{
    [SerializeField] private float seeingRadious=6f;
    [SerializeField] private GameObject target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private bool seePlayer=false;
    private float nextAttack = 0;
    [SerializeField] private float attackOffset = 0.3f;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (!agent)
            Debug.LogError("Agent not Found");
        target = PlayerManger.instance.player;
        if (!target)
            Debug.LogError("Target not Found.");
        else
            Debug.Log("Found Player");

        
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector3.Distance(transform.position, target.transform.position);
        if(distance <= seeingRadious)
        {
            seePlayer = true;
            agent.SetDestination(target.transform.position);
            if(distance <= agent.stoppingDistance && Time.time > nextAttack + attackOffset )
            {
                //Atack Target.
                nextAttack = Time.time + attackOffset;
                this.Attack(target.GetComponent<Attacable>());
                //Debug.Log("Attacking Player");
                

            }
            FaceTarget();
            Die();//jezeli zrobimy atak z dlugiego dystansu to bedzie trzeba to przeniesc poza tego ifa. 
        }
        
        else
        {
     
            seePlayer = false;
            
        }
    }
    void FaceTarget()
    {
        Vector3 directrion = (target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(directrion.x, 0, directrion.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);


    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, seeingRadious);
    }
    
}
